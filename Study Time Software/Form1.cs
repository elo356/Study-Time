using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Time_Software
{
    //rgb(125, 66, 50) escala color fl
    public partial class Form1 : Form
    {
        newTxtDb configDb = new newTxtDb();
      
        public int totalTime;
        public int totalDecTime;

        bool isPauseBtn= false;
        bool startDescTimer = false;
        bool timerRunning = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StopBtn.Enabled = false;
            //crear config db
            configDb.createTxtFile("ConfigDb");

            ConfigB.Hide();
            RegistroGb.Hide();

            for (int i = 0; i < 61; i++)
            {
                TmEstMinCb.Items.Add(i.ToString());
                TmEstSecCb.Items.Add(i.ToString());
                TmDescMinCb.Items.Add(i.ToString());
                TmDescSecCb.Items.Add(i.ToString());
            }

            string[] configDbLines = configDb.ReadTxtLines("configDb");
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
            RegistroGb.Hide();
        }

        private void ConfigMenu_Click(object sender, EventArgs e)
        {
            ConfigB.Show();
            InicioBox.Hide();
            RegistroGb.Hide();
        }
        private void RegistroMenu_Click(object sender, EventArgs e)
        {
            RegistroGb.Show();
            InicioBox.Hide();
            ConfigB.Hide();
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
                StudyTimer.Stop();
                Alarm alm = new Alarm();
                alm.PlaySound(MusicCB);
                IPCBtn.Text = "Iniciar";
                timeTxt.Text = "0:00";
                MessageBox.Show("El tiempo de estudio se termino","Fin",MessageBoxButtons.OK,MessageBoxIcon.Information);
                alm.Stop();
                timerRunning = false;
                //-------------------------------------time desc--------------------------------------------------------------------------
                MessageBox.Show("Iniciar tiempo de descanso", "Tiempo de descanso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                startDescTimer = true;
                StopBtn.Enabled = true;
                IPCBtn.Text = "Pausar";
                isPauseBtn = true;

                int minutes = int.Parse(TmDescMinCb.SelectedItem.ToString());
                int seconds = int.Parse(TmDescSecCb.SelectedItem.ToString());
                totalDecTime = (minutes * 60) + seconds;
                DescTimer.Enabled = true;

            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //crear      
            configDb.createTxtFile("ConfigDb");

            //leer
            string[] lines = configDb.ReadTxtLines("configDb");

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
