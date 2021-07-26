using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Complex;
using MathNet.Numerics;
using System.Numerics;
namespace ComplexPlane
{
    public partial class Form1 : Form
    {
        DenseMatrix RowLines;
        DenseMatrix ColLines;
        int ReStart = -300;
        int ReEnd = 300;
        int ImStart = -300;
        int ImEnd = 300;

        Complex multiplyComplex;
        Complex powerComplex;

        public Form1()
        {
            InitializeComponent();
            CreateMatrix();

            this.CenterToScreen();
            this.Resize += Form1_Resize;
            ImageShower.Location = new Point(10, 100);
            ImageShower.Width = this.Width - 35;
            ImageShower.Height = this.Height - 150;

            MultiplyRe.Minimum = 0;
            MultiplyRe.Maximum = 100;
            MultiplyRe.Value = 75;

            MultiplyIm.Minimum = 0;
            MultiplyIm.Maximum = 100;
            MultiplyIm.Value = 50;
            
            PowerRe.Minimum = 0;
            PowerRe.Maximum = 100;
            PowerRe.Value = 75;

            PowerIm.Minimum = 0;
            PowerIm.Maximum = 100;
            PowerIm.Value = 50;

            MultiplyReValue.Maximum = 100000;
            MultiplyReValue.Minimum = -1000;

            MultiplyImValue.Maximum = 100000;
            MultiplyImValue.Minimum = -1000;

            PowerReValue.Maximum = 100000;
            PowerReValue.Minimum = -1000;

            PowerImValue.Maximum = 100000;
            PowerImValue.Minimum = -1000;

            SetReImValues();
            makeImage();                        
        }

        public void MakeComplexValues()
        {                                
            multiplyComplex = new Complex((double)MultiplyReValue.Value, (double)MultiplyImValue.Value);
            powerComplex = new Complex((double)PowerReValue.Value, (double)PowerImValue.Value);
        }
        private void CreateMatrix()
        {
           
            int step = 30;

            List<List<Complex>> colLines = new List<List<Complex>>();
            for(int i = ReStart; i <= ReEnd; i+=step)
            {
               List<Complex> colLine = new List<Complex>();

                for (int j = ImStart; j <= ImEnd; j++)
                {
                    colLine.Add(new Complex(i, j));
                }
                colLines.Add(colLine);
            }

            Console.WriteLine(colLines.Count);
                        
            List<List<Complex>> rowLines = new List<List<Complex>>();
            for (int i = ReStart; i <= ReEnd; i ++)
            {
                List<Complex> rowLine = new List<Complex>();

                for (int j = ImStart; j <= ImEnd; j+=step)
                {
                    rowLine.Add(new Complex(i, j));
                }
                rowLines.Add(rowLine);
            }
            
            ColLines = DenseMatrix.OfRows(colLines);
            RowLines = DenseMatrix.OfRows(rowLines);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ImageShower.Location = new Point(10, 100);
            ImageShower.Width = this.Width - 35;
            ImageShower.Height = this.Height - 150;
            
            if(ImageShower.Height>0  && ImageShower.Width>0)
                makeImage();
        }

        private void makeImage()
        {
            Bitmap bmp = new Bitmap(ImageShower.Width, ImageShower.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, bmp.Width, bmp.Height);

           var newColLines = (DenseMatrix)ColLines.PointwisePower(powerComplex).Multiply(multiplyComplex);
           var newRowLines = (DenseMatrix)RowLines.PointwisePower(powerComplex).Multiply(multiplyComplex);

            
            Point center = new Point(bmp.Width / 2, bmp.Height / 2);

            var Points = newRowLines.Clone();
            Points = Points.Add(new Complex(center.X, center.Y));


            for (int r = 0; r < Points.RowCount; r++)
            {
                for (int c = 0; c < Points.ColumnCount; c++)
                {
                    if (Points[r, c].Real.IsFinite() && Points[r, c].Imaginary.IsFinite())
                        g.FillRectangle(new SolidBrush(Color.Blue), (int)Math.Round(Points[r, c].Real), (int)Math.Round(Points[r, c].Imaginary), 2, 2);
                 
                }
            }

            Points = newColLines.Clone();
            Points = Points.Add(new Complex(center.X, center.Y));
            for (int r = 0; r < Points.RowCount; r++)
            {
                for (int c = 0; c < Points.ColumnCount; c++)
                {
                    if (Points[r, c].Real.IsFinite() && Points[r, c].Imaginary.IsFinite())
                        g.FillRectangle(new SolidBrush(Color.Red), (int)Math.Round(Points[r, c].Real), (int)Math.Round(Points[r, c].Imaginary), 2, 2);
                }
            }

            ImageShower.Image = bmp;
        }
        private void SetReImValues()
        {
            MultiplyReValue.Value = (decimal)((MultiplyRe.Value - 50) * 0.04);
            MultiplyImValue.Value = (decimal)((MultiplyIm.Value - 50) * 0.04);

            PowerReValue.Value = (decimal)((PowerRe.Value - 50) * 0.04);
            PowerImValue.Value = (decimal)((PowerIm.Value - 50) * 0.04);
            MakeComplexValues();
        }
        private void MultiplyIm_Scroll(object sender, EventArgs e)
        {
            SetReImValues();
            makeImage();
        }

        private void MultiplyRe_Scroll(object sender, EventArgs e)
        {
            SetReImValues();
            makeImage();
        }

        private void PowerRe_Scroll(object sender, EventArgs e)
        {
            SetReImValues();
            makeImage();
        }

        private void PowerIm_Scroll(object sender, EventArgs e)
        {
            SetReImValues();
            makeImage();
        }
        
        private void MultiplyReValue_ValueChanged(object sender, EventArgs e)
        {
            MakeComplexValues();
            makeImage();
        }

        private void MultiplyImValue_ValueChanged(object sender, EventArgs e)
        {
            MakeComplexValues();
            makeImage();
        }

        private void PowerReValue_ValueChanged(object sender, EventArgs e)
        {
            MakeComplexValues();
            makeImage();
        }

        private void PowerImValue_ValueChanged(object sender, EventArgs e)
        {
            MakeComplexValues();
            makeImage();
        }
    }
}
