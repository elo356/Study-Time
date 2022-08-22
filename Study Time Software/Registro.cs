using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace Study_Time_Software
{
    class Registro 
    {
        DataTable table;
        DataGridView dgv;
        int studyTimeMin;
        int studyTimeSec;
        int descTimeMin;
        int descTimeSec;

        public Registro(DataGridView dgv, int stm, int sts, int dtm, int dts)
        {
            this.dgv = dgv;
            this.studyTimeMin = stm;
            this.studyTimeSec = sts;
            this.descTimeMin = dtm;
            this.descTimeSec = dts;
        }
        public void createTableFile(string fileName)
        {
            if (File.Exists(Application.StartupPath + "\\" + fileName + ".txt") == false)
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + fileName + ".txt");
                
                string date = DateTime.Now.ToShortDateString();
                sw.WriteLine("{0}   |    |  ",date);
                Console.WriteLine("archivo txt " + fileName + " creado");
                sw.Close();
            }
            else
            {
                Console.WriteLine("Archivo txt " + fileName + " ya existe");
            }
        }

        public void createDataFile(string fileName)
        {
            if (File.Exists(Application.StartupPath + "\\" + fileName + ".txt") == false)
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + fileName + ".txt");

                sw.WriteLine("00");
                sw.WriteLine("00");
                sw.WriteLine("00");
                sw.WriteLine("00");
     
                sw.Close();
            }
            else
            {
                Console.WriteLine("Archivo txt " + fileName + " ya existe");
            }
        }

        public void ImportTxtInDGV(string fileName)
        {
            string[] lines = File.ReadAllLines(Application.StartupPath + "\\" + fileName + ".txt");
            string[] values;

            for(int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];

                for(int l = 0; l < values.Length; l++)
                {
                    row[l] = values[l].Trim();
                }
                table.Rows.Add(row);
            }
        }

        public void SaveDgvInTxt(string fileName)
        {
            TextWriter writer = new StreamWriter(Application.StartupPath + "\\" + fileName + ".txt");
            for(int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                for(int l = 0; l < dgv.Columns.Count; l++)
                {
                    if(l == dgv.Columns.Count - 1)
                    {
                        writer.Write("\t" + dgv.Rows[i].Cells[l].Value.ToString());
                    }
                    else
                    {
                        writer.Write("\t" + dgv.Rows[i].Cells[l].Value.ToString() + "\t" + "|");
                    } 
                }
                writer.WriteLine("");
            }
            writer.Close();
        }

        public void writeColumnOnLoad()
        {
            table = new DataTable();
            table.Columns.Add("Dia", typeof(string));
            table.Columns.Add("Tiempo de Estudio", typeof(string));
            table.Columns.Add("Tiempo de Descanso", typeof(string));
            dgv.DataSource = table;
        }

        public void DeleteSelectedRow()
        {
            if(dgv.CurrentCell != null)
            {
                int rowIndex = dgv.CurrentCell.RowIndex;
                dgv.Rows.RemoveAt(rowIndex);
                SaveDgvInTxt("RegistroTablaDB");
            }
            else
            {
                MessageBox.Show("No puede borrar una celda vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
        public void VerifySesion(string fileName)
        {
            string date = DateTime.Now.ToShortDateString();
            int rowI = dgv.Rows.Count - 2;

            if (dgv.Rows[rowI].Cells[0].Value.ToString() != date)
            {
                //nueva sesion
                table.Rows.Add(date);
                SaveDgvInTxt(fileName);
            }
            else
            {
                //sesion continuada
            }
        }

        public void SetSesionEstTime(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName +".txt");
            int rowI = dgv.Rows.Count - 2;
            dgv.Rows[rowI].Cells[1].Value = lines[0] + ":0" + lines[1];
            SaveDgvInTxt("RegistroTablaDB");
        }

        public void SetSesionDescTime(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

        }
    }
}
