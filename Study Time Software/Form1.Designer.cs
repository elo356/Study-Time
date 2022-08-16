
namespace Study_Time_Software
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StopBtn = new System.Windows.Forms.Button();
            this.IPCBtn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Label();
            this.InicioBox = new System.Windows.Forms.GroupBox();
            this.timeTxt = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.InicioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigB = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ThemeCb = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TmDescSecCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TmDescMinCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TmEstSecCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TmEstMinCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MusicCB = new System.Windows.Forms.ComboBox();
            this.StudyTimer = new System.Windows.Forms.Timer(this.components);
            this.DescTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.InicioBox.SuspendLayout();
            this.Menu.SuspendLayout();
            this.ConfigB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(45, 182);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(111, 49);
            this.StopBtn.TabIndex = 8;
            this.StopBtn.Text = "Detener";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // IPCBtn
            // 
            this.IPCBtn.Location = new System.Drawing.Point(45, 120);
            this.IPCBtn.Name = "IPCBtn";
            this.IPCBtn.Size = new System.Drawing.Size(111, 39);
            this.IPCBtn.TabIndex = 6;
            this.IPCBtn.Text = "Iniciar";
            this.IPCBtn.UseVisualStyleBackColor = true;
            this.IPCBtn.Click += new System.EventHandler(this.IPCBtn_Click);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(77, 16);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(43, 16);
            this.Timer.TabIndex = 5;
            this.Timer.Text = "Timer";
            // 
            // InicioBox
            // 
            this.InicioBox.Controls.Add(this.timeTxt);
            this.InicioBox.Controls.Add(this.Timer);
            this.InicioBox.Controls.Add(this.StopBtn);
            this.InicioBox.Controls.Add(this.IPCBtn);
            this.InicioBox.Location = new System.Drawing.Point(26, 46);
            this.InicioBox.Name = "InicioBox";
            this.InicioBox.Size = new System.Drawing.Size(200, 259);
            this.InicioBox.TabIndex = 9;
            this.InicioBox.TabStop = false;
            // 
            // timeTxt
            // 
            this.timeTxt.AutoSize = true;
            this.timeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTxt.Location = new System.Drawing.Point(44, 49);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(112, 42);
            this.timeTxt.TabIndex = 9;
            this.timeTxt.Text = "00:00";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InicioMenu,
            this.ConfigMenu,
            this.RegistroMenu});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(251, 24);
            this.Menu.TabIndex = 10;
            this.Menu.Text = "menuStrip1";
            // 
            // InicioMenu
            // 
            this.InicioMenu.Name = "InicioMenu";
            this.InicioMenu.Size = new System.Drawing.Size(48, 20);
            this.InicioMenu.Text = "Inicio";
            this.InicioMenu.Click += new System.EventHandler(this.InicioMenu_Click_1);
            // 
            // ConfigMenu
            // 
            this.ConfigMenu.Name = "ConfigMenu";
            this.ConfigMenu.Size = new System.Drawing.Size(95, 20);
            this.ConfigMenu.Text = "Configuración";
            this.ConfigMenu.Click += new System.EventHandler(this.ConfigMenu_Click);
            // 
            // RegistroMenu
            // 
            this.RegistroMenu.Name = "RegistroMenu";
            this.RegistroMenu.Size = new System.Drawing.Size(62, 20);
            this.RegistroMenu.Text = "Registro";
            this.RegistroMenu.Click += new System.EventHandler(this.RegistroMenu_Click);
            // 
            // ConfigB
            // 
            this.ConfigB.Controls.Add(this.label7);
            this.ConfigB.Controls.Add(this.ThemeCb);
            this.ConfigB.Controls.Add(this.groupBox2);
            this.ConfigB.Controls.Add(this.SaveBtn);
            this.ConfigB.Controls.Add(this.groupBox1);
            this.ConfigB.Controls.Add(this.label4);
            this.ConfigB.Controls.Add(this.MusicCB);
            this.ConfigB.Location = new System.Drawing.Point(26, 40);
            this.ConfigB.Name = "ConfigB";
            this.ConfigB.Size = new System.Drawing.Size(200, 265);
            this.ConfigB.TabIndex = 10;
            this.ConfigB.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tema";
            // 
            // ThemeCb
            // 
            this.ThemeCb.FormattingEnabled = true;
            this.ThemeCb.Location = new System.Drawing.Point(45, 198);
            this.ThemeCb.Name = "ThemeCb";
            this.ThemeCb.Size = new System.Drawing.Size(121, 21);
            this.ThemeCb.TabIndex = 8;
            this.ThemeCb.SelectedIndexChanged += new System.EventHandler(this.ThemeCb_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TmDescSecCb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TmDescMinCb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(6, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 71);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiempo de descanso";
            // 
            // TmDescSecCb
            // 
            this.TmDescSecCb.FormattingEnabled = true;
            this.TmDescSecCb.Location = new System.Drawing.Point(111, 44);
            this.TmDescSecCb.Name = "TmDescSecCb";
            this.TmDescSecCb.Size = new System.Drawing.Size(39, 21);
            this.TmDescSecCb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Segundos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TmDescMinCb
            // 
            this.TmDescMinCb.FormattingEnabled = true;
            this.TmDescMinCb.Location = new System.Drawing.Point(22, 44);
            this.TmDescMinCb.Name = "TmDescMinCb";
            this.TmDescMinCb.Size = new System.Drawing.Size(39, 21);
            this.TmDescMinCb.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Minutos";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(63, 236);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Guardar";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TmEstSecCb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TmEstMinCb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiempo de estudio";
            // 
            // TmEstSecCb
            // 
            this.TmEstSecCb.FormattingEnabled = true;
            this.TmEstSecCb.Location = new System.Drawing.Point(121, 41);
            this.TmEstSecCb.Name = "TmEstSecCb";
            this.TmEstSecCb.Size = new System.Drawing.Size(39, 21);
            this.TmEstSecCb.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Segundos";
            // 
            // TmEstMinCb
            // 
            this.TmEstMinCb.FormattingEnabled = true;
            this.TmEstMinCb.Location = new System.Drawing.Point(22, 41);
            this.TmEstMinCb.Name = "TmEstMinCb";
            this.TmEstMinCb.Size = new System.Drawing.Size(39, 21);
            this.TmEstMinCb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minutos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Music";
            // 
            // MusicCB
            // 
            this.MusicCB.FormattingEnabled = true;
            this.MusicCB.Location = new System.Drawing.Point(45, 171);
            this.MusicCB.Name = "MusicCB";
            this.MusicCB.Size = new System.Drawing.Size(121, 21);
            this.MusicCB.TabIndex = 4;
            // 
            // StudyTimer
            // 
            this.StudyTimer.Interval = 1000;
            this.StudyTimer.Tick += new System.EventHandler(this.StudyTimer_Tick);
            // 
            // DescTimer
            // 
            this.DescTimer.Interval = 1000;
            this.DescTimer.Tick += new System.EventHandler(this.DescTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "By: DevElop";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 338);
            this.Controls.Add(this.ConfigB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.InicioBox);
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(267, 377);
            this.MinimumSize = new System.Drawing.Size(267, 377);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InicioBox.ResumeLayout(false);
            this.InicioBox.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ConfigB.ResumeLayout(false);
            this.ConfigB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button IPCBtn;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.GroupBox InicioBox;
        private System.Windows.Forms.Label timeTxt;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem InicioMenu;
        private System.Windows.Forms.ToolStripMenuItem ConfigMenu;
        private System.Windows.Forms.ToolStripMenuItem RegistroMenu;
        private System.Windows.Forms.GroupBox ConfigB;
        private System.Windows.Forms.ComboBox TmEstMinCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MusicCB;
        private System.Windows.Forms.Timer StudyTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TmEstSecCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox TmDescSecCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TmDescMinCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer DescTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ThemeCb;
        private System.Windows.Forms.Label label2;
    }
}

