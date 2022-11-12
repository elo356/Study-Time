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
        MenuStrip Menu;
        Label l1; 
        Label l2; 
        Label l3; 
        Label l4; 
        Label l5; 
        GroupBox gb1; 
        GroupBox gb2;
        Form f;
        public Theme(GroupBox Inicio, GroupBox Config, MenuStrip Menu, Label l1, Label l2, Label l3, Label l4, Label l5, GroupBox gb1, GroupBox gb2, Form f)
        {
            this.Inicio = Inicio;
            this.Config = Config;
            this.Menu = Menu;
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
            this.l4 = l4;
            this.l5 = l5;
            this.gb1 = gb1;
            this.gb2 = gb2;
            this.f = f;
        }

        public void LightTheme()
        {
            Inicio.BackColor = Control.DefaultBackColor;
            Config.BackColor = Control.DefaultBackColor;
            Menu.BackColor = Control.DefaultBackColor;
            Menu.ForeColor = Color.Black;
            //---------------------------txt---------------------------------
            l1.ForeColor = Color.Black;
            l2.ForeColor = Color.Black;
            l3.ForeColor = Color.Black;
            gb1.ForeColor = Color.Black;
            gb2.ForeColor = Color.Black;
            l4.ForeColor = Color.Black;
            l5.ForeColor = Color.Black;
            f.BackColor = Control.DefaultBackColor;
        }
        public void DarkTheme()
        {
            Inicio.BackColor = Color.FromArgb(54, 57, 63);
            Config.BackColor = Color.FromArgb(54, 57, 63);
            Menu.BackColor = Color.FromArgb(47, 49, 54);
            Menu.ForeColor = Color.White;
            //---------------------------txt---------------------------------
            l1.ForeColor = Color.White;
            l2.ForeColor = Color.White;
            l3.ForeColor = Color.White;
            gb1.ForeColor = Color.White;
            gb2.ForeColor = Color.White;
            l4.ForeColor = Color.White;
            l5.ForeColor = Color.White;
            f.BackColor = Color.FromArgb(54, 57, 63);
        }
        
        public void LukthakTheme()
        {
            Inicio.BackColor = Color.FromArgb(125, 66, 50);
            Config.BackColor = Color.FromArgb(125, 66, 50);
            Menu.BackColor = Color.FromArgb(112, 59, 46);
            f.BackColor = Color.FromArgb(125, 66, 50);
            Menu.ForeColor = Color.White;
            //---------------------------txt---------------------------------
            l1.ForeColor = Color.White;
            l2.ForeColor = Color.White;
            l3.ForeColor = Color.White;
            gb1.ForeColor = Color.White;
            gb2.ForeColor = Color.White;
            l4.ForeColor = Color.White;
            l5.ForeColor = Color.White;
        }
    }
}
