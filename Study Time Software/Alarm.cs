using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Study_Time_Software
{
    class Alarm
    {
        SoundPlayer sp;
       
        public void PlaySound(ComboBox cb)
        {
            switch (cb.SelectedIndex) 
            {
                case 0:
                    {
                        sp = new SoundPlayer(Properties.Resources.m1);
                        break;
                    }
                case 1:
                    {
                        sp = new SoundPlayer(Properties.Resources.m2);
                        break;
                    }
                case 2:
                    {
                        sp = new SoundPlayer(Properties.Resources.m3);
                        break;
                    }
                case 3:
                    {
                        sp = new SoundPlayer(Properties.Resources.m4);
                        break;
                    }
                case 4:
                    {
                        sp = new SoundPlayer(Properties.Resources.m5);
                        break;
                    }
            }

            sp.PlayLooping(); 
        }
        public void Stop()
        {
            sp.Stop();
        }
    }
}
