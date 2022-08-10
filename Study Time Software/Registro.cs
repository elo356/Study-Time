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
        DataGridView dgb;

        public Registro(DataGridView dgb)
        {
            this.dgb = dgb;
        }

        public void createFile(string fileName)
        {
            if (File.Exists(Application.StartupPath + "\\" + fileName + ".txt") == false)
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + fileName + ".txt");
                
                string date = DateTime.Now.ToShortDateString();
                sw.WriteLine("{0}    | 0:00   | 0:00",date);
                Console.WriteLine("archivo txt " + fileName + " creado");
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
            for(int i = 0; i < dgb.Rows.Count - 1; i++)
            {
                for(int l = 0; l < dgb.Columns.Count; l++)
                {
                    if(l == dgb.Columns.Count - 1)
                    {
                        writer.Write("\t" + dgb.Rows[i].Cells[l].Value.ToString());
                    }
                    else
                    {
                        writer.Write("\t" + dgb.Rows[i].Cells[l].Value.ToString() + "\t" + "|");
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
            dgb.DataSource = table;
        }

        public void DeleteSelectedRow()
        {
            if(dgb.CurrentCell != null)
            {
                int rowIndex = dgb.CurrentCell.RowIndex;
                dgb.Rows.RemoveAt(rowIndex);
                SaveDgvInTxt("RegistroDB");
            }
            else
            {
                MessageBox.Show("No puede borrar una celda vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
