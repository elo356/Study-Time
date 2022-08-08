using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Study_Time_Software
{
    class Theme
    {
        GroupBox Inicio;
        GroupBox Config;
        GroupBox Registro;
        MenuStrip Menu;

        public Theme(GroupBox Inicio, GroupBox Config, GroupBox Registro, MenuStrip Menu)
        {
            this.Inicio = Inicio;
            this.Config = Config;
            this.Registro = Registro;
            this.Menu = Menu;
        }

        public void LightTheme()
        {
            Inicio.BackColor = Control.DefaultBackColor;
            Config.BackColor = Control.DefaultBackColor;
            Registro.BackColor = Control.DefaultBackColor;
            Menu.BackColor = Control.DefaultBackColor;
        }
        public void DarkTheme()
        {
            Inicio.BackColor = Color.DarkGray;
            Config.BackColor = Color.DarkGray;
            Registro.BackColor = Color.DarkGray;
            Menu.BackColor = Color.Gray;
        }
        
        public void LukthakTheme()
        {
            Inicio.BackColor = Color.FromArgb(125, 66, 50);
            Config.BackColor = Color.FromArgb(125, 66, 50);
            Registro.BackColor = Color.FromArgb(125, 66, 50);
            Menu.BackColor = Color.FromArgb(112, 59, 46);
        }
    }
}
