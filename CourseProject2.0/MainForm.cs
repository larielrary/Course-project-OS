using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CourseProject2._0
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            CheckData checkData = new CheckData(this);
            checkData.CheckAsync();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AValue_Click(object sender, EventArgs e)
        {
            aValue.Clear();
        }

        private void BValue_Click(object sender, EventArgs e)
        {
            bValue.Clear();
        }

        private void CValue_Click(object sender, EventArgs e)
        {
            cValue.Clear();
        }

        private void DValue_Click(object sender, EventArgs e)
        {
            dValue.Clear();
        }

        private void ExportToExcelBtn_Click(object sender, EventArgs e)
        {
            ExportToExcel exportToExcel = new ExportToExcel(this);
            exportToExcel.Export();
        }

        private void ShowSurfaceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(aValue.Text);
                int b = Convert.ToInt32(bValue.Text);
                int c = Convert.ToInt32(cValue.Text);
                int d = Convert.ToInt32(dValue.Text);

                Process pythonProcess = new Process();
                string fileName = "course.txt";
                using (FileStream fstream = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(a.ToString() + "\n" + b.ToString() + "\n" +
                        c.ToString() + "\n" + d.ToString());
                    fstream.WriteAsync(array, 0, array.Length);
                }
                pythonProcess.StartInfo.FileName = Application.StartupPath + @"\dist\CourseProj.exe";
                pythonProcess.Start();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error", "Введены неверные данные", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Error", "Ошибка преобразования типов", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error", "Выход за пределы допустимых значений", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error", "Введена пустая строка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
