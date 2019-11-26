using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace QiblaCalculator
{
  public partial class CompassForm : Form
  {
    double angle = 0;
    Bitmap bmp = new Bitmap(Properties.Resources.compass);

    public CompassForm(double angle)
    {
      this.angle = angle;
      InitializeComponent();
    }

    private void CompassForm_Load(object sender, EventArgs e)
    {
      

    }

    private void CompassForm_Paint(object sender, PaintEventArgs e)
    {
      float x1=125, x2=125, y1=200, y2=200;

      Graphics g = e.Graphics;
      g.Clear(System.Drawing.SystemColors.Control);
      g.DrawImage(bmp, 0, 0);

      Matrix matrix = new Matrix();
      PointF pointF = new PointF(x1, y1);
      matrix.RotateAt((float)45, pointF);
      g.Transform = matrix;

      //SolidBrush myBrush = new SolidBrush(Color.Blue);
      Pen pen = new Pen(Color.Red);
      pen.Alignment = PenAlignment.Inset;
      pen.LineJoin = LineJoin.Round;
      g.DrawLine(pen, 125, 125, 125, 25);



      //SolidBrush brush = new SolidBrush(Color.Magenta);
      //grfx.FillRectangle(brush, 25, 25, 5, 5);   
    }
  }
}
