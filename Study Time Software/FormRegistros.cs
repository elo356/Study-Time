using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Time_Software
{
    public partial class FormRegistros : Form
    {
        public FormRegistros()
        {
            InitializeComponent();
        }
        FormRegistros f;

        private void FormRegistros_Load(object sender, EventArgs e)
        {
            f = this;
            newTxtDb config = new newTxtDb();
            string[] configDbLines = config.ReadTxtLines("configDb");
            int themeIndex = int.Parse(configDbLines[6]);

            switch (themeIndex)
            {
                case 0:
                    {
                        f.BackColor = Control.DefaultBackColor;
                        label2.ForeColor = Color.Black;
                        break;
                    }
                case 1:
                    {
                        f.BackColor = Color.FromArgb(54, 57, 63);
                        label2.ForeColor = Color.White;
                        break;
                    }
                case 2:
                    {
                        f.BackColor = Color.FromArgb(125, 66, 50);
                        label2.ForeColor = Color.White;
                        break;
                    }
            }

            Registro registro = new Registro();
            registro.createFile("RegistroDB");
            registro.writeColumnOnLoad(SesionDGV);
            registro.ImportTxtInDGV("RegistroDB");
            registro.NewSesion(SesionDGV);
        }

        private void DeleteRowBtn_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.DeleteSelectedRow(SesionDGV);
        }
    }
}
