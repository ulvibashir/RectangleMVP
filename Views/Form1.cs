using System;
using System.Windows.Forms;
using RectangleCalc.Presenters;
using RectangleCalc.Views;

namespace RectangleCalc
{
    public partial class Form1 : Form, IRectangle
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string LengthText { get => txtLength.Text; set => txtLength.Text = value; }
        public string BreadthText { get => txtBreadth.Text; set => txtBreadth.Text = value; }
        public string Areatext { get => lblArea.Text; set => lblArea.Text = value; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RectanglePresenter rectanglePresenter = new RectanglePresenter(this);
            rectanglePresenter.CalculateArea();
        }
    }
}
