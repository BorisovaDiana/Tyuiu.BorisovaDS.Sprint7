using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.BorisovaDS.Sprint7.Project.V4.Lib;

namespace Tyuiu.BorisovaDS.Sprint7.Project.V4
{
    public partial class FormIformationAboutBooks_BDS : Form
    {
        public FormIformationAboutBooks_BDS()
        {
            InitializeComponent();
        }


        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void ToolStripMenuItemOpen_BDS_Click(object sender, EventArgs e)
        {
            openFileDialogBooks_BDS.ShowDialog();
            openFilePath = openFileDialogBooks_BDS.FileName;

            string[,] matrix = ds.LoadFromDataFile(openFilePath);

            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);

            dataGridViewTable_BDS.RowCount = rows + 1;
            dataGridViewTable_BDS.ColumnCount = columns;

            //добавление данных
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewTable_BDS.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            dataGridViewTable_BDS.AutoResizeColumns();
            dataGridViewTable_BDS.ScrollBars = ScrollBars.Both;

            dataGridViewTable_BDS.Rows.RemoveAt(0);

        }

        private void ToolStripMenuItemSave_BDS_Click(object sender, EventArgs e)
        {
            
            saveFileDialogBooks_BDS.FileName = "OutPutFileProject.csv";
            saveFileDialogBooks_BDS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogBooks_BDS.ShowDialog();

            string path = saveFileDialogBooks_BDS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewTable_BDS.RowCount;
            int columns = dataGridViewTable_BDS.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewTable_BDS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewTable_BDS.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonExit_BDS_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain FormM = new FormMain();
            FormM.Show();
        }

        


    }
}

//contactbindingSourceTable_BDS.Filter = "Автор = \'" + toolStripTextBox_BDS.Text + "\'";     toolStripTextBox_BDS       contactbindingSourceTable_BDS