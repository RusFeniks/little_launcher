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
            this.LD_Button = new System.Windows.Forms.Button();
            this.VK_Button = new System.Windows.Forms.Button();
            this.YT_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Start_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Download_Bar
            // 
            this.Download_Bar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Download_Bar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Download_Bar.Location = new System.Drawing.Point(17, 201);
            this.Download_Bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Download_Bar.Name = "Download_Bar";
            this.Download_Bar.Size = new System.Drawing.Size(162, 38);
            this.Download_Bar.TabIndex = 6;
            // 
            // GameVersion_Text
            // 
            this.GameVersion_Text.AutoSize = true;
            this.GameVersion_Text.BackColor = System.Drawing.Color.Transparent;
            this.GameVersion_Text.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameVersion_Text.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GameVersion_Text.Location = new System.Drawing.Point(290, 97);
            this.GameVersion_Text.Name = "GameVersion_Text";
            this.GameVersion_Text.Size = new System.Drawing.Size(96, 58);
            this.GameVersion_Text.TabIndex = 7;
            this.GameVersion_Text.Text = "0,00";
            this.GameVersion_Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bites_counter
            // 
            this.bites_counter.BackColor = System.Drawing.Color.Transparent;
            this.bites_counter.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bites_counter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bites_counter.Location = new System.Drawing.Point(42, 183);
            this.bites_counter.Name = "bites_counter";
            this.bites_counter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bites_counter.Size = new System.Drawing.Size(109, 15);
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
            this.Folder_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Folder_Button.Enabled = false;
            this.Folder_Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Folder_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Folder_Button.Image = global::NORMLauncher.Properties.Resources.folder_open;
            this.Folder_Button.Location = new System.Drawing.Point(144, 9);
            this.Folder_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Folder_Button.Name = "Folder_Button";
            this.Folder_Button.Size = new System.Drawing.Size(42, 42);
            this.Folder_Button.TabIndex = 4;
            this.Folder_Button.Tag = "Open folder";
            this.Folder_Button.UseVisualStyleBackColor = false;
            this.Folder_Button.Click += new System.EventHandler(this.Folder_Button_Click);
            // 
            // MoveList_Button
            // 
            this.MoveList_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MoveList_Button.Enabled = false;
            this.MoveList_Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.MoveList_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveList_Button.Image = ((System.Drawing.Image)(resources.GetObject("MoveList_Button.Image")));
            this.MoveList_Button.Location = new System.Drawing.Point(94, 9);
            this.MoveList_Button.Margin = new System.Windows.Forms.Padding(0);
            this.MoveList_Button.Name = "MoveList_Button";
            this.MoveList_Button.Size = new System.Drawing.Size(42, 42);
            this.MoveList_Button.TabIndex = 3;
            this.MoveList_Button.Tag = "Movelist";
            this.MoveList_Button.UseVisualStyleBackColor = false;
            this.MoveList_Button.Click += new System.EventHandler(this.MoveList_Button_Click);
            // 
            // LD_Button
            // 
            this.LD_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LD_Button.Enabled = false;
            this.LD_Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.LD_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LD_Button.Image = ((System.Drawing.Image)(resources.GetObject("LD_Button.Image")));
            this.LD_Button.Location = new System.Drawing.Point(194, 9);
            this.LD_Button.Margin = new System.Windows.Forms.Padding(0);
            this.LD_Button.Name = "LD_Button";
            this.LD_Button.Size = new System.Drawing.Size(42, 42);
            this.LD_Button.TabIndex = 14;
            this.LD_Button.Tag = "Download launcher update";
            this.LD_Button.UseVisualStyleBackColor = false;
            this.LD_Button.Click += new System.EventHandler(this.LD_Button_Click);
            // 
            // VK_Button
            // 
            this.VK_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.VK_Button.Enabled = false;
            this.VK_Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.VK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VK_Button.Image = global::NORMLauncher.Properties.Resources.vk;
            this.VK_Button.Location = new System.Drawing.Point(244, 9);
            this.VK_Button.Margin = new System.Windows.Forms.Padding(0);
            this.VK_Button.Name = "VK_Button";
            this.VK_Button.Size = new System.Drawing.Size(42, 42);
            this.VK_Button.TabIndex = 2;
            this.VK_Button.Tag = "Discord";
            this.VK_Button.UseVisualStyleBackColor = false;
            this.VK_Button.Click += new System.EventHandler(this.VK_Button_Click);
            // 
            // YT_Button
            // 
            this.YT_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.YT_Button.Enabled = false;
            this.YT_Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.YT_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YT_Button.Image = ((System.Drawing.Image)(resources.GetObject("YT_Button.Image")));
            this.YT_Button.Location = new System.Drawing.Point(294, 9);
            this.YT_Button.Margin = new System.Windows.Forms.Padding(0);
            this.YT_Button.Name = "YT_Button";
            this.YT_Button.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.YT_Button.Size = new System.Drawing.Size(42, 42);
            this.YT_Button.TabIndex = 10;
            this.YT_Button.Tag = "Youtube";
            this.YT_Button.UseVisualStyleBackColor = false;
            this.YT_Button.Click += new System.EventHandler(this.YT_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Update_Button.Enabled = false;
            this.Update_Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update_Button.ForeColor = System.Drawing.Color.AliceBlue;
            this.Update_Button.Image = ((System.Drawing.Image)(resources.GetObject("Update_Button.Image")));
            this.Update_Button.Location = new System.Drawing.Point(187, 193);
            this.Update_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(50, 50);
            this.Update_Button.TabIndex = 1;
            this.Update_Button.Text = " ";
            this.Update_Button.UseVisualStyleBackColor = false;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Start_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Start_Button.Enabled = false;
            this.Start_Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Start_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Button.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Button.Image = global::NORMLauncher.Properties.Resources.circle_right;
            this.Start_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Start_Button.Location = new System.Drawing.Point(245, 201);
            this.Start_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Padding = new System.Windows.Forms.Padding(16, 0, 7, 0);
            this.Start_Button.Size = new System.Drawing.Size(162, 38);
            this.Start_Button.TabIndex = 0;
            this.Start_Button.Text = "LAUNCH";
            this.Start_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Start_Button.UseVisualStyleBackColor = false;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(424, 250);
            this.Controls.Add(this.bites_counter);
            this.Controls.Add(this.GameVersion_Text);
            this.Controls.Add(this.Folder_Button);
            this.Controls.Add(this.MoveList_Button);
            this.Controls.Add(this.LD_Button);
            this.Controls.Add(this.VK_Button);
            this.Controls.Add(this.YT_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Download_Bar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "NTSDZ Launcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button LD_Button;
        private System.Windows.Forms.Button VK_Button;
        private System.Windows.Forms.Button YT_Button;
        private System.Windows.Forms.Button MoveList_Button;
        private System.Windows.Forms.Button Folder_Button;
        private System.Windows.Forms.Label GameVersion_Text;
        private System.Windows.Forms.Label bites_counter;
        public System.Windows.Forms.ProgressBar Download_Bar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

