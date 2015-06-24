using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        RectManager Rect_Manager;

        public Form1(int ScreenWidth,int ScreenHeight)
        {

            InitializeComponent();
            this.Size = new Size(ScreenWidth,ScreenHeight);
            this.CenterToScreen();
            WindowState = FormWindowState.Maximized;

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Start();
            timer.Tick += new EventHandler(UpdateGame);

            Paint += new PaintEventHandler(DrawGame);

            Rect_Manager = new RectManager(ScreenWidth, ScreenHeight);
            Rect_Manager.CreateGrid(Convert.ToInt32(GridW.Text), Convert.ToInt32(GridH.Text));

        }

        void DrawGame(object sender, PaintEventArgs Draw)
        {
            this.Rect_Manager.Draw(Draw.Graphics);
        }

        void UpdateGame(object sender , EventArgs e)
        {
            Update();
            Invalidate();
        }

        private void CreateGrid_Click(object sender, EventArgs e)
        {
            Rect_Manager.CreateGrid(Convert.ToInt32(GridW.Text), Convert.ToInt32(GridH.Text));
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Rect_Manager.SetPaths(e.X, e.Y);
        }

        private void getTargetableRect_Click(object sender, EventArgs e)
        {
            Rect_Manager.GetTargetableRects();
        }
    }
}
