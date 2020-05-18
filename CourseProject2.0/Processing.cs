using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace CourseProject2._0
{
    public class Processing
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }

        public MainForm MainForm { get; set; }
        public Processing(int a, int b, int c, int d, MainForm mainForm)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            MainForm = mainForm;
        }
        public virtual double DetivativeFunction(double x, double y)
        {
            return Math.Sqrt(1 +
                            Math.Pow(2 * A * x + C * Math.Exp(-x), 2) +
                            Math.Pow(2 * B * y + D * Math.Exp(-y), 2));
        }

        public double IntegrateDerivative(int xMin, int xMax, int nX, int yMin, int yMax, int nY)
        {
            int xIter = (int)((xMax - xMin) / nX);
            int yIter = (int)((yMax - yMin) / nY);
            double x, y, w, sum = 0;
            for (var i = 0; i <= xIter; i++)
            {
                x = xMin + i * nX;
                for (var j = 0; j <= yIter; j++)
                {
                    if (i > 0 && i < xIter && j > 0 && j < yIter)
                    {
                        w = 1;
                    }
                    else if ((i == 0 || i == yIter) && (j == 0 || j == xIter))
                    {
                        w = 0.25;
                    }
                    else
                    {
                        w = 0.5;
                    }
                    y = yMin + j * nY;
                    sum += w * DetivativeFunction(x, y);
                }
            }
            return Math.Abs(nX * nY * sum);
        }
        public double ParallelIntegrateDetivate(int xMin, int xMax, int nX, int yMin, int yMax, int nY)
        {
            object lockObject = new object();
            string filePath = string.Empty;
            int xIter = (int)((xMax - xMin) / nX);
            int yIter = (int)((yMax - yMin) / nY);
            double x, y, w, sum = 0;
            //ThreadPool.SetMinThreads(Convert.ToInt32(MainForm.threadCount.SelectedItem.ToString()), Convert.ToInt32(MainForm.threadCount.SelectedItem.ToString()));
            
            Parallel.For(0, xIter,  i =>
            {
                x = xMin + i * nX;
                for (var j = 0; j <= yIter; j++)
                {
                    if (i > 0 && i < xIter && j > 0 && j < yIter)
                    {
                        w = 1;
                    }
                    else if ((i == 0 || i == yIter) && (j == 0 || j == xIter))
                    {
                        w = 0.25;
                    }
                    else
                    {
                        w = 0.5;
                    }
                    y = yMin + j * nY;
                    sum += w * DetivativeFunction(x, y);
                }
                lock (lockObject)
                {
                    StreamWriter streamWriter = new StreamWriter("Thread" + i + ".txt");
                    streamWriter.WriteLine(Math.Abs(sum));
                    streamWriter.Dispose();
                }
            });
            return Math.Abs(nX * nY * sum);
        }
        
        
    }
}
