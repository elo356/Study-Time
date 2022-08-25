using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Study_Time_Software
{
    //rgb(125, 66, 50) escala color fl
    /*           //-------------------------------registro----------------------------------
           
    */
    public partial class Form1 : System.Windows.Forms.Form
    {
        newTxtDb configDb = new newTxtDb();
        Form1 f;
        public string configFileName = "ConfigDb";
        public int totalTime;
        public int totalDecTime;

        bool isPauseBtn= false;
        bool startDescTimer = false;
        bool timerRunning = false;
        int themeIndex;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f = this;
            //crear config db
            configDb.createTxtFile(configFileName);
            string[] configDbLines = configDb.ReadTxtLines(configFileName);
            FormRegistros frg = new FormRegistros();
            frg.Show();
            frg.Close();
            //tema
            Theme theme = new Theme(InicioBox, ConfigB, Menu, Timer, timeTxt, label2, label4, label7, groupBox1, groupBox2, f);

            ThemeCb.Items.Add("Light Theme");
            ThemeCb.Items.Add("Dark Theme");
            ThemeCb.Items.Add("Lukthak Theme");
            themeIndex = ThemeCb.SelectedIndex;

            ThemeCb.SelectedIndex = int.Parse(configDbLines[6]);

            switch (themeIndex)
            {
                case 0:
                    {
                        theme.LightTheme();
                        break;
                    }
                case 1:
                    {
                        theme.DarkTheme();
                        break;
                    }
                case 2:
                    {
                        theme.LukthakTheme();       
                        break;
                    }
            }
           
            StopBtn.Enabled = false;

            ConfigB.Hide();

            for (int i = 0; i < 61; i++)
            {
                TmEstMinCb.Items.Add(i.ToString());
                TmDescMinCb.Items.Add(i.ToString());
                if(i > 9)
                {
                    TmEstSecCb.Items.Add(i.ToString());
                    TmDescSecCb.Items.Add(i.ToString());
                }
                else
                {
                    TmEstSecCb.Items.Add("0" + i.ToString());
                    TmDescSecCb.Items.Add("0" + i.ToString());
                }     
            }

            TmEstMinCb.SelectedIndex = int.Parse(configDbLines[1]);
            TmEstSecCb.SelectedIndex = int.Parse(configDbLines[2]);
            TmDescMinCb.SelectedIndex = int.Parse(configDbLines[3]);
            TmDescSecCb.SelectedIndex = int.Parse(configDbLines[4]);

            MusicCB.Items.Add("Calido Amanecer");
            MusicCB.Items.Add("Alarma de Carro");
            MusicCB.Items.Add("Disculpe");
            MusicCB.Items.Add("Tu Mujer");
            MusicCB.Items.Add("Hey");
            MusicCB.SelectedIndex = int.Parse(configDbLines[5]);
        }

        private void InicioMenu_Click_1(object sender, EventArgs e)
        {
            InicioBox.Show();
            ConfigB.Hide();
        }

        private void ConfigMenu_Click(object sender, EventArgs e)
        {
            ConfigB.Show();
            InicioBox.Hide();
        }
        private void RegistroMenu_Click(object sender, EventArgs e)
        {
            FormRegistros fr = new FormRegistros();
            fr.Show();
        }

        private void IPCBtn_Click(object sender, EventArgs e)
        {
            if (!startDescTimer)
            {
                if (!timerRunning)
                {
                    if (TmEstMinCb.SelectedItem == null || TmEstSecCb.SelectedItem == null || TmDescSecCb.SelectedItem == null || TmDescMinCb.SelectedItem == null)
                    {
                        MessageBox.Show("Debes llenar los campos en Configuración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        StopBtn.Enabled = true;
                        timerRunning = true;
                        IPCBtn.Text = "Pausar";
                        isPauseBtn = true;
                        int minutes = int.Parse(TmEstMinCb.SelectedItem.ToString());
                        int seconds = int.Parse(TmEstSecCb.SelectedItem.ToString());
                        totalTime = (minutes * 60) + seconds;
                        StudyTimer.Enabled = true;
                    }
                }
                else
                {
                    if (!isPauseBtn)
                    {
                        IPCBtn.Text = "Pausar";
                        isPauseBtn = true;
                        StudyTimer.Start();
                    }
                    else
                    {
                        IPCBtn.Text = "Continuar";
                        isPauseBtn = false;
                        StudyTimer.Stop();
                    }
                }
            }
            else
            {
                if (!isPauseBtn)
                {
                    IPCBtn.Text = "Pausar";
                    isPauseBtn = true;
                    DescTimer.Start();
                }
                else
                {
                    IPCBtn.Text = "Continuar";
                    isPauseBtn = false;
                    DescTimer.Stop();
                }
            }
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            StudyTimer.Stop();
            DescTimer.Stop();
            StudyTimer.Enabled = false;
            DescTimer.Enabled = false;
            timeTxt.Text = "0:00";
            timerRunning = false;
            startDescTimer = false;
            IPCBtn.Text = "Iniciar";
            StopBtn.Enabled = false;
        }

        private void StudyTimer_Tick(object sender, EventArgs e)
        {

            if (totalTime > 0)
            {
                totalTime--;
                int minute = totalTime / 60;
                int second = totalTime - (minute * 60);
                timeTxt.Text = minute.ToString() + ":" + second.ToString();
            }
            else
            {
                int minutes = int.Parse(TmEstMinCb.SelectedItem.ToString());
                int seconds = int.Parse(TmEstSecCb.SelectedItem.ToString());

                StudyTimer.Stop();
                Alarm alm = new Alarm();
                alm.PlaySound(MusicCB);
                IPCBtn.Text = "Iniciar";
                timeTxt.Text = "0:00";

                //guardar en registro de estudio
                StudyTimer.Enabled = false;

                string[] l = new string[5];
                string[] lo = File.ReadAllLines("RegistroDataDb.txt");
                minutes = 60;
                int hour = minutes / 60;
                int min = minutes % 60;
            
                Console.WriteLine(hour);
                l[0] = $"{int.Parse(lo[0]) + minutes}";
                l[1] = $"{ int.Parse(lo[1]) + seconds}";
                File.WriteAllLines("RegistroDataDb.txt",l);
                //----------------------------------------------------------------------
                FormRegistros frg = new FormRegistros();
                frg.Show();
                frg.Close();
                MessageBox.Show("El tiempo de estudio se termino","Fin",MessageBoxButtons.OK,MessageBoxIcon.Information);
                alm.Stop();
                timerRunning = false;
                //-------------------------------------time desc--------------------------------------------------------------------------
                MessageBox.Show("Iniciar tiempo de descanso", "Tiempo de descanso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                startDescTimer = true;
                StopBtn.Enabled = true;
                IPCBtn.Text = "Pausar";
                isPauseBtn = true;

                int minutesD = int.Parse(TmDescMinCb.SelectedItem.ToString());
                int secondsD = int.Parse(TmDescSecCb.SelectedItem.ToString());
                totalDecTime = (minutesD * 60) + secondsD;
                DescTimer.Enabled = true;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //crear      
            configDb.createTxtFile(configFileName);

            //leer
            string[] lines = configDb.ReadTxtLines(configFileName);

            if (TmEstMinCb.SelectedItem == null || TmEstSecCb.SelectedItem == null || TmDescSecCb.SelectedItem == null || TmDescMinCb.SelectedItem == null)
            {
                MessageBox.Show("Debes llenar los campos en Configuración antes de guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //guardar tiempo de estudio minutos
                lines[1] = TmEstMinCb.SelectedItem.ToString();

                //guardar tiempo de estudio segundos
                lines[2] = TmEstSecCb.SelectedItem.ToString();

                //guardar minutos tiempo de descanso
                lines[3] = TmDescMinCb.SelectedItem.ToString();

                //guardar segundos tiempo de descanso
                lines[4] = TmDescSecCb.SelectedItem.ToString();

                //guardar musica
                lines[5] = MusicCB.SelectedIndex.ToString();

                //guardar tema
                lines[6] = ThemeCb.SelectedIndex.ToString();
                //escribirlo
                configDb.WriteInTxt("ConfigDb", lines);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DescTimer_Tick(object sender, EventArgs e)
        {
            if (totalDecTime > 0)
            {
                totalDecTime--;
                int minute = totalDecTime / 60;
                int second = totalDecTime - (minute * 60);
                timeTxt.Text = minute.ToString() + ":" + second.ToString();
            }
            else
            {
                DescTimer.Stop();
                Alarm alm = new Alarm();
                alm.PlaySound(MusicCB);
                IPCBtn.Text = "Iniciar";
                timeTxt.Text = "0:00";
                MessageBox.Show("El tiempo de descanso se termino", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                alm.Stop();
                startDescTimer = false;
                isPauseBtn = false;
            }
        }

        private void ThemeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Theme theme = new Theme(InicioBox, ConfigB, Menu, Timer, timeTxt, label2, label4, label7, groupBox1, groupBox2, f);

            themeIndex = ThemeCb.SelectedIndex;
            switch (themeIndex)
            {
                case 0:
                    {
                        theme.LightTheme();
                        break;
                    }
                case 1:
                    {
                        this.BackColor = Color.FromArgb(54, 57, 63);
                        theme.DarkTheme();
                        break;
                    }
                case 2:
                    {
                        theme.LukthakTheme();
                        break;
                    }
            }
        }
    }
}
