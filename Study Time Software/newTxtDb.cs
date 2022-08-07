using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Study_Time_Software
{
    class newTxtDb
    {
        StreamWriter sw;

        public void createTxtFile(string fileName)
        {
            if (File.Exists(Application.StartupPath + "\\" + fileName + ".txt") == false)
            {
                sw = new StreamWriter(Application.StartupPath + "\\" + fileName + ".txt");
                sw.WriteLine("No elimine ni cambie nada en este archivo");
                sw.WriteLine("25");
                sw.WriteLine("0");
                sw.WriteLine("5");
                sw.WriteLine("0");
                sw.WriteLine("0");
                Console.WriteLine("archivo txt " + fileName + " creado");
                sw.Close();
            }
            else
            {
                Console.WriteLine("Archivo txt " + fileName + " ya existe");
            }
        }

        public string[] ReadTxtLines(string fileName)
        {
            string[] txtLines = File.ReadAllLines(Application.StartupPath + "\\" + fileName + ".txt");
            return txtLines;
        }

        public void WriteInTxt(string fileName, string[] message)
        {
            File.WriteAllLines(Application.StartupPath + "\\" + fileName + ".txt", message);
        }
    }
}
