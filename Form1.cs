using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace NORMLauncher
{
    public partial class MainForm : Form
    {
        string download_type = null;
        List<List<string>> List_of_references = null;
        List<string> Update_Information = null;
        string Game_Folder = Application.StartupPath;
        int db_animframe = 1;



        public MainForm()
        {
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void VK_Button_Click(object sender, EventArgs e)
        {
            Uri VK_Link = new Uri("https://vk.com/atom_tm");
            Process.Start(VK_Link.ToString());
        }

        public void Folder_Button_Click(object sender, EventArgs e)
        {
                Process.Start(Game_Folder + "\\game");
        }

        private void MoveList_Button_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            Downloading_updates_from_the_list();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (db_animframe < 9)
            {
                db_animframe += 1;
            }
            else
            {
                db_animframe = 1;
            }
            switch (db_animframe)
            {
                case 1:
                    Update_Button.Image = Properties.Resources._01;
                    break;
                case 2:
                    Update_Button.Image = Properties.Resources._02;
                    break;
                case 3:
                    Update_Button.Image = Properties.Resources._03;
                    break;
                case 4:
                    Update_Button.Image = Properties.Resources._04;
                    break;
                case 5:
                    Update_Button.Image = Properties.Resources._05;
                    break;
                case 6:
                    Update_Button.Image = Properties.Resources._06;
                    break;
                case 7:
                    Update_Button.Image = Properties.Resources._07;
                    break;
                case 8:
                    Update_Button.Image = Properties.Resources._08;
                    break;
                case 9:
                    Update_Button.Image = Properties.Resources._09;
                    break;

            }
        }

        private bool Check_All()
        {
            if (File.Exists("version"))
            {
                var file = File.OpenText("version");
                var version = file.ReadLine();
                Properties.Settings.Default.Game_Version = version;
                Properties.Settings.Default.Save();
                file.Close();
                File.Delete("version");
            }

            if (Directory.Exists(Game_Folder + "\\game"))
            {
                Folder_Button.Enabled = true;
            }
            else
            {
                Folder_Button.Enabled = false;
            }

            if (File.Exists(Game_Folder + "\\game\\start.exe"))
            {
                Start_Button.Enabled = true;
            }
            else
            {
                Start_Button.Enabled = false;
            }

            if (File.Exists(Game_Folder + "\\movelist\\index.html"))
            {
                MoveList_Button.Enabled = true;
            }
            else
            {
                MoveList_Button.Enabled = false;
            }

            GameVersion_Text.Text = Properties.Settings.Default.Game_Version;

            bool Connection = false;
            Ping Connection_Check = new Ping();
            PingReply Connection_Check_Reply;
            try
            {
                Connection_Check_Reply = Connection_Check.Send(@"google.com");
                Connection = true;
            }
            catch
            {
                Connection = false;
            }

            if (Connection)
            {
                VK_Button.Enabled = true;
            }
            else
            {
                VK_Button.Enabled = false;
            }

            if (List_of_references != null)
            {
                if (List_of_references.Count() > 0)
                {
                    timer2.Stop();
                    Update_Button.Enabled = true;
                    Update_Button.Text = List_of_references.Count().ToString();
                }
                else
                {
                    timer2.Stop();
                    bites_counter.Text = "Done!";
                    Update_Button.Enabled = false;
                }
            }

            return Connection;
        }

        private void DownLoad_File(string download_url, string file_name = null, string dt = null)
        {
            download_type = dt;

            try
            {
                var FileSize = HttpWebRequest.Create(download_url);
                FileSize.Method = "HEAD";
                int fileSize = 0;
                using (var webResponse = FileSize.GetResponse())
                {
                    fileSize = Convert.ToInt32(webResponse.Headers.Get("Content-Length"));
                }
                if (fileSize > 0)
                {
                    Download_Bar.Maximum = fileSize;
                    Download_Bar.Value = 0;
                    WebClient DownLoad = new WebClient();
                    if (file_name == null)
                    {
                        file_name = Path.GetFileName(download_url);
                    }
                    DownLoad.DownloadFileAsync(new Uri(download_url), file_name);
                    DownLoad.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownLoad_Changed);
                    DownLoad.DownloadFileCompleted += new AsyncCompletedEventHandler(DownLoad_Completed);
                } else
                {
                    MessageBox.Show("Файла кажись несуществует :\\");
                    timer2.Stop();
                    bites_counter.Text = "Error! :C";
                }
            } catch
            {
                MessageBox.Show("Во время скачивания взникла ошибка. Попробуйте перезапустить лаунчер.");
                Check_All();
            }
            
        }

        private void DownLoad_Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Download_Bar.Maximum = 0;
                Download_Bar.Value = 0;
                bites_counter.Text = " ";

                switch (download_type)
                {
                    case "updates_list":
                        List_of_references = Creating_an_update_list();
                        Check_All();
                        break;
                    case "Download_update":
                        bites_counter.Text = "Unpacking...";
                        Process.Start(Update_Information.Last() + ".exe").WaitForExit();
                        File.Delete(Update_Information.Last() + ".exe");
                        Properties.Settings.Default.Game_Version = Update_Information.Last();
                        Properties.Settings.Default.Save();
                        GameVersion_Text.Text = Properties.Settings.Default.Game_Version;

                        List_of_references.Remove(List_of_references.Last());
                        Downloading_updates_from_the_list();
                        break;
                }
            } else
            {
                MessageBox.Show("Во время скачивания взникла ошибка. Попробуйте перезапустить лаунчер.");
                Check_All();
            }
        }

        private void DownLoad_Changed(object sender, DownloadProgressChangedEventArgs e)
        {
            Download_Bar.Value = Convert.ToInt32(e.BytesReceived);
            bites_counter.Text = Math.Round(((float)Download_Bar.Value / 1024 / 1024), 2) + " / " + Math.Round(((float)Download_Bar.Maximum / 1024 / 1024), 2) + " МБ";
        }


        private List<List<string>> Creating_an_update_list ()
        {
            List_of_references = new List<List<string>>();
            XmlReader UpdatesXML = new XmlTextReader("updates.xml");
            while (UpdatesXML.Read())
            {
                if (UpdatesXML.Name == "update")
                {
                    float game_version = Convert.ToSingle(Properties.Settings.Default.Game_Version);
                    float update_version = Convert.ToSingle(UpdatesXML.GetAttribute("version"));
                    if(update_version > game_version)
                    {
                        Update_Information = new List<string>();
                        Update_Information.Add(UpdatesXML.GetAttribute("url"));
                        Update_Information.Add(UpdatesXML.GetAttribute("version"));
                        List_of_references.Add(Update_Information);
                        Update_Information = null;
                    }
                }
            }

            UpdatesXML.Close();
            File.Delete("updates.xml");
            List_of_references.Reverse();

            return List_of_references;
        }


        private void Downloading_updates_from_the_list()
        {
            if (List_of_references.Count > 0)
            {
                Update_Button.Enabled = false;
                Start_Button.Enabled = false;
                Update_Button.Text = List_of_references.Count().ToString();
                Update_Information = List_of_references.Last();
                DownLoad_File(Update_Information.First(), Update_Information.Last()+".exe", "Download_update");
            } else
            {
                Start_Button.Enabled = true;
                Update_Button.Text = " ";
                Check_All();
            }
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {

            Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = Game_Folder + "\\game\\start.exe";
            proc.StartInfo.WorkingDirectory = Game_Folder + "\\game\\";
            proc.Start();
            Application.Exit();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Stop();

            if (Check_All())
            {
               DownLoad_File("https://www.dropbox.com/s/ty1eypfbm2nmbnt/updates.xml?dl=1", "updates.xml", "updates_list");
            }
        }
    }
}
