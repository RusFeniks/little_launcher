namespace NORMLauncher
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Download_Bar = new System.Windows.Forms.ProgressBar();
            this.GameVersion_Text = new System.Windows.Forms.Label();
            this.bites_counter = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Folder_Button = new System.Windows.Forms.Button();
            this.MoveList_Button = new System.Windows.Forms.Button();
            this.VK_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Logo_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Download_Bar
            // 
            this.Download_Bar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Download_Bar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Download_Bar.Location = new System.Drawing.Point(290, 135);
            this.Download_Bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Download_Bar.Name = "Download_Bar";
            this.Download_Bar.Size = new System.Drawing.Size(100, 20);
            this.Download_Bar.TabIndex = 6;
            // 
            // GameVersion_Text
            // 
            this.GameVersion_Text.AutoSize = true;
            this.GameVersion_Text.BackColor = System.Drawing.Color.Transparent;
            this.GameVersion_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameVersion_Text.Location = new System.Drawing.Point(197, 6);
            this.GameVersion_Text.Name = "GameVersion_Text";
            this.GameVersion_Text.Size = new System.Drawing.Size(32, 13);
            this.GameVersion_Text.TabIndex = 7;
            this.GameVersion_Text.Text = "0,00";
            this.GameVersion_Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bites_counter
            // 
            this.bites_counter.BackColor = System.Drawing.Color.Transparent;
            this.bites_counter.Font = new System.Drawing.Font("Lucida Sans Unicode", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bites_counter.Location = new System.Drawing.Point(290, 160);
            this.bites_counter.Name = "bites_counter";
            this.bites_counter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bites_counter.Size = new System.Drawing.Size(100, 15);
            this.bites_counter.TabIndex = 9;
            this.bites_counter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Folder_Button
            // 
            this.Folder_Button.Enabled = false;
            this.Folder_Button.Image = global::NORMLauncher.Properties.Resources.folder_open;
            this.Folder_Button.Location = new System.Drawing.Point(290, 5);
            this.Folder_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Folder_Button.Name = "Folder_Button";
            this.Folder_Button.Size = new System.Drawing.Size(50, 50);
            this.Folder_Button.TabIndex = 4;
            this.Folder_Button.UseVisualStyleBackColor = true;
            this.Folder_Button.Click += new System.EventHandler(this.Folder_Button_Click);
            // 
            // MoveList_Button
            // 
            this.MoveList_Button.Enabled = false;
            this.MoveList_Button.Image = global::NORMLauncher.Properties.Resources.file_text2;
            this.MoveList_Button.Location = new System.Drawing.Point(235, 5);
            this.MoveList_Button.Margin = new System.Windows.Forms.Padding(0);
            this.MoveList_Button.Name = "MoveList_Button";
            this.MoveList_Button.Size = new System.Drawing.Size(50, 50);
            this.MoveList_Button.TabIndex = 3;
            this.MoveList_Button.UseVisualStyleBackColor = true;
            this.MoveList_Button.Click += new System.EventHandler(this.MoveList_Button_Click);
            // 
            // VK_Button
            // 
            this.VK_Button.Enabled = false;
            this.VK_Button.Image = global::NORMLauncher.Properties.Resources.vk;
            this.VK_Button.Location = new System.Drawing.Point(345, 5);
            this.VK_Button.Margin = new System.Windows.Forms.Padding(0);
            this.VK_Button.Name = "VK_Button";
            this.VK_Button.Size = new System.Drawing.Size(50, 50);
            this.VK_Button.TabIndex = 2;
            this.VK_Button.UseVisualStyleBackColor = true;
            this.VK_Button.Click += new System.EventHandler(this.VK_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.Enabled = false;
            this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update_Button.ForeColor = System.Drawing.Color.DarkCyan;
            this.Update_Button.Image = ((System.Drawing.Image)(resources.GetObject("Update_Button.Image")));
            this.Update_Button.Location = new System.Drawing.Point(235, 130);
            this.Update_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(50, 50);
            this.Update_Button.TabIndex = 1;
            this.Update_Button.Text = " ";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.Enabled = false;
            this.Start_Button.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_Button.Image = global::NORMLauncher.Properties.Resources.circle_right;
            this.Start_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Start_Button.Location = new System.Drawing.Point(235, 60);
            this.Start_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Padding = new System.Windows.Forms.Padding(6, 0, 10, 0);
            this.Start_Button.Size = new System.Drawing.Size(160, 65);
            this.Start_Button.TabIndex = 0;
            this.Start_Button.Text = "СТАРТ";
            this.Start_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Logo_Image
            // 
            this.Logo_Image.BackColor = System.Drawing.Color.Transparent;
            this.Logo_Image.Image = global::NORMLauncher.Properties.Resources.mini_logo;
            this.Logo_Image.Location = new System.Drawing.Point(-20, 5);
            this.Logo_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logo_Image.Name = "Logo_Image";
            this.Logo_Image.Size = new System.Drawing.Size(250, 180);
            this.Logo_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo_Image.TabIndex = 8;
            this.Logo_Image.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(399, 191);
            this.Controls.Add(this.bites_counter);
            this.Controls.Add(this.GameVersion_Text);
            this.Controls.Add(this.Folder_Button);
            this.Controls.Add(this.MoveList_Button);
            this.Controls.Add(this.VK_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Download_Bar);
            this.Controls.Add(this.Logo_Image);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "NORM Launcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button VK_Button;
        private System.Windows.Forms.Button MoveList_Button;
        private System.Windows.Forms.Button Folder_Button;
        private System.Windows.Forms.Label GameVersion_Text;
        private System.Windows.Forms.PictureBox Logo_Image;
        private System.Windows.Forms.Label bites_counter;
        public System.Windows.Forms.ProgressBar Download_Bar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

