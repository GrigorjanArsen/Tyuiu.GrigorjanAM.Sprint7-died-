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
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using Tyuiu.GrigorjanAM.Sprint7.Project.V9.Lib;

namespace Tyuiu.GrigorjanAM.Sprint7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialog_GAM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }

        
        private void buttonSave_GAM_Click(object sender, EventArgs e)
        {

        }

        static string openFile;
        static int rows;
        static int columns;
        static string[,] matrix;
        DataService ds = new DataService();
        private void buttonInPut_GAM_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_GAM.ShowDialog();
                openFile = openFileDialog_GAM.FileName;

                matrix = ds.LoadDataSet(openFile);
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);
                dataGridViewBase_GAM.RowCount = 250;
                dataGridViewBase_GAM.ColumnCount = 50;

                for (int i = 0; i < rows; i++)
                {
                    dataGridViewBase_GAM.Columns[i].Width = 135;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewBase_GAM.Rows[i].Cells[j].Value = matrix[i, j];
                        dataGridViewBase_GAM.Rows[i].Cells[j].Selected = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
