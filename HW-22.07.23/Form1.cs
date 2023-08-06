namespace HW_22._07._23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black,5);
            Brush b = new SolidBrush(Color.Black);
            g.FillRectangle(Brushes.Black, 50, 50, 350, 360);
            b= new SolidBrush(Color.FromArgb(0, 255, 0));
            g.FillEllipse(b, 150, 150, 150, 200);
            p= new Pen(Color.FromArgb(0,150,0),5);
            g.DrawEllipse(p, 150, 150, 150, 200);
            g.FillEllipse(b, 130, 270, 30, 30);
            g.FillEllipse(b, 290, 270, 30, 30);
            g.FillEllipse(b, 180, 130, 90, 60);
            g.FillEllipse(b, 190, 110, 70, 60);
            g.FillRectangle(b, 180, 325, 20, 60);
            g.FillRectangle(b, 250, 325, 20, 60);
            b = new SolidBrush(Color.FromArgb(153, 0, 153));
            g.FillRectangle(b, 180, 365, 20, 10);
            g.FillRectangle(b, 250, 365, 20, 10);
            g.FillRectangle(b, 190, 120, 70, 15);
            b = new SolidBrush(Color.FromArgb(102, 102, 0));
            g.FillRectangle(b, 300, 130, 15, 250);
            b = new SolidBrush(Color.FromArgb(178, 102, 255));
            g.FillRectangle(b, 300, 230, 15, 80);
            g.FillRectangle(Brushes.Yellow, 180, 190, 90, 100);
            g.FillEllipse(Brushes.Yellow, 180, 265, 90, 60);

        }
    }
}