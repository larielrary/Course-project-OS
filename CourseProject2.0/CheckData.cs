using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CourseProject2._0
{
    public class CheckData
    {
        public MainForm MainForm { get; set; }

        public CheckData(MainForm mainForm)
        {
            MainForm = mainForm;
        }
        public async System.Threading.Tasks.Task CheckAsync()
        {
            try
            {
                int a = Convert.ToInt32(MainForm.aValue.Text);
                int b = Convert.ToInt32(MainForm.bValue.Text);
                int c = Convert.ToInt32(MainForm.cValue.Text);
                int d = Convert.ToInt32(MainForm.dValue.Text);
                Processing processing = new Processing(a, b, c, d, MainForm);

                var stopwatch = new Stopwatch();
                stopwatch.Start();
                var squareDer = processing.IntegrateDerivative(-100, 100, 200, -20, 20, 40);
                stopwatch.Stop();
                MainForm.timeTextBox.Text = stopwatch.ElapsedTicks.ToString();
                MainForm.result2TextBox.Text = (squareDer / 100).ToString();

                stopwatch.Reset();
                stopwatch.Start();
                var squareDerPar = processing.ParallelIntegrateDetivate(-100, 100, 200, -20, 20, 40);
                stopwatch.Stop();
                MainForm.timeParTextBox.Text = stopwatch.ElapsedTicks.ToString();
                MainForm.result2ParTextBox.Text = (squareDerPar / 100).ToString();
                string square = string.Empty;
                try
                {
                    using (StreamReader streamReader = new StreamReader("square.txt"))
                    {
                        square = streamReader.ReadLine();
                        MainForm.resultFromPython.Text = square;
                    }
                }
                catch (Exception e)
                {
                    MainForm.resultFromPython.Text = e.Message;
                }
                MainForm.absoluteErrorTextBox.Text = Math.Abs(Convert.ToDouble(square) / (10 ^ 47) - squareDer / (10 ^ 47)).ToString();
                MainForm.relativeErrorTextBox.Text = (Math.Abs(Convert.ToDouble(square) - squareDer) / squareDer).ToString() + "%";

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
