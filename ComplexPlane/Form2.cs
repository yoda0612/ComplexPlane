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
using System.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Interpolation;
namespace ComplexPlane
{
    public partial class Form2 : Form
    {
        int w;
        int h;
        int w2 = 300;
        int h2 = 300;
        List<Vector2> tCord = new List<Vector2>();
        List<Vector3> cord = new List<Vector3>();
        Dictionary<int, int> pairs = new Dictionary<int, int>();
        public Form2()
        {
            var r = OpenTK.Matrix3.CreateRotationY((float)(Math.PI/2));
            

            var detR = r.Determinant;
            var ri = OpenTK.Matrix3.CreateRotationX(0.5f).Inverted();
            var rt = OpenTK.Matrix3.CreateRotationX(0.5f);
            rt.Transpose();

            var q = OpenTK.Quaternion.FromMatrix(r);
            //Console.WriteLine(Math.PI / 2);
            //var q = new OpenTK.Quaternion(0.7f, 0, 0.7f, 0);



            Console.WriteLine(q);
            Console.WriteLine(q.Inverted());



            InitializeComponent();
            this.KeyDown += Form2_KeyDown;
           
            using (StreamReader sr = new StreamReader(@"C:\Users\admin\Documents\3dModels\earth\earth.obj"))
            {
                string line;
                int vn = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("v "))
                    {
                        string subline = line.Substring(line.IndexOf('v') + 1).Trim();
                        float x = float.Parse(subline.Split(' ')[0]);
                        float y = float.Parse(subline.Split(' ')[1]);
                        float z = float.Parse(subline.Split(' ')[2]);
                        cord.Add(new Vector3(x, y, z));
                    }
                    if (line.StartsWith("vt "))
                    {
                        string subline = line.Substring(line.IndexOf("vt") + 2).Trim();
                        float x = float.Parse(subline.Split(' ')[0]);
                        float y = float.Parse(subline.Split(' ')[1]);
                        tCord.Add(new Vector2(x, y));
                    }
                    if (line.StartsWith("f"))
                    {
                        foreach (var vline in line.Split(' ').Skip(1))
                        {
                            if (vline.Trim().Length > 0)
                            {
                                int vi = int.Parse(vline.Split('/')[0]) - 1;
                                int ti = int.Parse(vline.Split('/')[1]) - 1;
                                if (!pairs.ContainsKey(vi))
                                    pairs.Add(vi, ti);
                            }
                        }
                    }
                }
            }
            CreateMap();

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            CreateMap();
        }

        void CreateMap()
        {            
            Bitmap earth = new Bitmap(@"C:\Users\admin\Documents\3dModels\earth\4096_earth.jpg");
            w = earth.Width;
            h = earth.Height;

            Bitmap newMap = new Bitmap(w2, h2);

            Graphics g = Graphics.FromImage(newMap);
            List<Vector2> nCord = new List<Vector2>();

            var rot = OpenTK.Matrix3.CreateRotationY(0.001f);
            for (int vi = 0; vi < cord.Count; vi++)
            {
                var vec = new OpenTK.Vector3(cord[vi].X, cord[vi].Y, cord[vi].Z);
                vec = rot * vec;

                cord[vi] = new Vector3(vec.X, vec.Y, vec.Z);
            }

            for (int vi = 0; vi < cord.Count; vi++)
            {
                float newX = cord[vi].X / (1 - cord[vi].Z);
                float newY = cord[vi].Y / (1 - cord[vi].Z);
                nCord.Add(new Vector2(newX, newY));
            }
            float minX = nCord.Min(c => c.X);
            float minY = nCord.Min(c => c.Y);
            nCord = nCord.Select(c => new Vector2(c.X - minX, c.Y - minY)).ToList();
            float maxX = nCord.Max(c => c.X);
            float maxY = nCord.Max(c => c.Y);
            nCord = nCord.Select(c => new Vector2(c.X / maxX, c.Y / maxY)).ToList();

            for (int vi = 0; vi < cord.Count; vi++)
            {
                var vt = tCord[pairs[vi]];
                var color = earth.GetPixel((int)(vt.X * (w - 1)), (int)(vt.Y * (h - 1)));
                int newX = (int)(nCord[vi].X * (w2 - 1));
                int newY = (int)(nCord[vi].Y * (h2 - 1));
                g.FillRectangle(new SolidBrush(color), newX, newY, 2, 2);

            }

            pictureBox1.Image = newMap;
        }
    }
}
