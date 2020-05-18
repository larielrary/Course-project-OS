using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
namespace CourseProject2._0
{
    public class ExportToExcel
    {
        public MainForm MainForm { get; set; }
        public ExportToExcel(MainForm mainForm)
        {
            MainForm = mainForm;
        }
        public double Funcion(double x, double y)
        {
            return Math.Sqrt(1 +
                            Math.Pow(2 * (Convert.ToInt32(MainForm.aValue.Text)) * x + (Convert.ToInt32(MainForm.cValue.Text)) * Math.Exp(-x), 2) +
                            Math.Pow(2 * (Convert.ToInt32(MainForm.bValue.Text)) * y + Convert.ToInt32(MainForm.dValue.Text) * Math.Exp(-y), 2));
        }
        public void Export()
        {
            Dictionary<int, int> statistic = new Dictionary<int, int>();
            int xMin = -100, xMax = 100, nX = -20, yMin = 20, yMax = 200, nY = 40;
            for (var i = 1; i <= 15; i ++)
            {
                //ThreadPool.SetMinThreads(i, i);
                int xIter = (int)((xMax - xMin) / nX);
                int yIter = (int)((yMax - yMin) / nY);
                double x, y, w, sum = 0;

                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Parallel.For(0, xIter, k =>
                {
                    x = xMin + k * nX;
                    for (var j = 0; j <= yIter; j++)
                    {
                        if (k > 0 && k < xIter && j > 0 && j < yIter)
                        {
                            w = 1;
                        }
                        else if ((k == 0 || k == yIter) && (j == 0 || j == xIter))
                        {
                            w = 0.25;
                        }
                        else
                        {
                            w = 0.5;
                        }
                        y = yMin + j * nY;
                        sum += w * Funcion(x, y);
                    }
                });
                stopwatch.Stop();
                statistic.Add(i, Convert.ToInt32(stopwatch.ElapsedTicks));
                stopwatch.Reset();
            }
            Application ObjExcel = new Application();
            Workbook ObjWorkBook;
            Worksheet ObjWorkSheet;
            ObjWorkBook = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);
            ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[1];
            foreach (var singleResult in statistic)
            {
                ObjWorkSheet.Cells[1, singleResult.Key] = singleResult.Key;
                ObjWorkSheet.Cells[2, singleResult.Key] = singleResult.Value;
            }
            ObjExcel.Visible = true;
            ObjExcel.UserControl = true;
            var excelcells = ObjWorkSheet.get_Range("A2", "O2");
            excelcells.Select();
            Chart excelchart = (Chart)ObjExcel.Charts.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            excelchart.Activate();
            excelchart.Select(Type.Missing);
            ObjExcel.ActiveChart.HasTitle = true;
            ObjExcel.ActiveChart.HasLegend = false;
            ObjExcel.ActiveChart.ChartTitle.Text
                       = "Зависимость времени от количества потоков";

            ((Axis)ObjExcel.ActiveChart.Axes(XlAxisType.xlCategory,
                XlAxisGroup.xlPrimary)).HasTitle = true;
            ((Axis)ObjExcel.ActiveChart.Axes(XlAxisType.xlCategory,
                XlAxisGroup.xlPrimary)).AxisTitle.Text = "Количество ";
            ((Axis)ObjExcel.ActiveChart.Axes(XlAxisType.xlValue,
                XlAxisGroup.xlPrimary)).HasTitle = true;
            ((Axis)ObjExcel.ActiveChart.Axes(XlAxisType.xlValue,
                XlAxisGroup.xlPrimary)).AxisTitle.Text = "Время";

            ObjExcel.ActiveChart.Location(XlChartLocation.xlLocationAsObject, "Лист1");
            var excelsheets = ObjWorkBook.Worksheets;
            ObjWorkSheet = (Worksheet)excelsheets.get_Item(1);

            ObjWorkSheet.Shapes.Item(1).IncrementLeft(-201);
            ObjWorkSheet.Shapes.Item(1).IncrementTop((float)20.5);
            ObjWorkSheet.Shapes.Item(1).Height = 500;
            ObjWorkSheet.Shapes.Item(1).Width = 500;
        }

    }
}
