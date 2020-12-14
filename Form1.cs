using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintCompGraph
{
    public partial class Form1 : Form
    {
        List<PersonFigure> listFigure;
        List<Point> listPoint;

        Color currentColor = Color.Black;
        bool isPressed = false;

        Figure currentFigure = Figure.LINE;

        Point currentPoint;
        Point prevPoint;

        Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
            listFigure = new List<PersonFigure>();
            listPoint = new List<Point>();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            DialogResult dialog = colorDialog1.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            listFigure.Clear();
            pictureBox1.Refresh();
            pictureBox1.CreateGraphics().Clear(Color.White);
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {

        }

        private void DrawingPen()
        {
            Pen pen = new Pen(currentColor);
            graphics.DrawLine(pen, currentPoint, prevPoint);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(currentColor);
            if (currentFigure == Figure.RECT || currentFigure == Figure.OVAL)
            {
                Rectangle rect;
                if (currentPoint.Y > prevPoint.Y)
                {
                    rect = new Rectangle(prevPoint.X, prevPoint.Y,
                        PersonFigure.GetWight(currentPoint, prevPoint),
                        PersonFigure.GetHeight(currentPoint, prevPoint));
                } else
                    rect = new Rectangle(currentPoint.X, currentPoint.Y,
                                PersonFigure.GetWight(currentPoint, prevPoint),
                                PersonFigure.GetHeight(currentPoint, prevPoint));
                if (currentFigure == Figure.OVAL)
                    e.Graphics.DrawEllipse(pen, rect);
                else
                    e.Graphics.DrawRectangle(pen, rect);
            } else
                e.Graphics.DrawLine(pen, currentPoint, prevPoint);
            foreach (PersonFigure personFigure in listFigure)
            {
                Pen tempPen = new Pen(personFigure.color);
                switch (personFigure.figure)
                {
                    case Figure.LINE:
                        e.Graphics.DrawLine(tempPen, personFigure.pointStart, personFigure.pointEnd);
                        break;
                    case Figure.RECT:
                        Rectangle rect = new Rectangle(personFigure.pointStart.X, personFigure.pointStart.Y,
                            personFigure.width, personFigure.height);
                        e.Graphics.DrawRectangle(tempPen, rect);
                        break;
                }
                    
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
            listFigure.Add(new PersonFigure(currentPoint, prevPoint, currentFigure, currentColor));
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            prevPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                if (currentFigure == Figure.PEN)
                {
                    prevPoint = currentPoint;
                    currentPoint = e.Location;
                    DrawingPen();
                }
                else
                {
                    currentPoint = e.Location;
                    if (currentPoint.X == prevPoint.X && 
                        (currentFigure == Figure.RECT || currentFigure == Figure.OVAL))
                        currentPoint.X++;
                    pictureBox1.Invalidate();
                }
            }
        }

        private void buttonPen_Click(object sender, EventArgs e)
        {
            currentFigure = Figure.PEN;
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            currentFigure = Figure.LINE;
        }

        private void buttonOval_Click(object sender, EventArgs e)
        {
            currentFigure = Figure.OVAL;
        }

        private void buttonRect_Click(object sender, EventArgs e)
        {
            currentFigure = Figure.RECT;
        }
    }
}
