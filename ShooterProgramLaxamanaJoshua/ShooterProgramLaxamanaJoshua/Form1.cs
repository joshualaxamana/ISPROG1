using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShooterProgramLaxamanaJoshua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ship player1 = new Ship();
        Graphics gfx;
        Pen pen;
        Bullet b = new Bullet();

        private void Form1_Load(object sender, EventArgs e)
        {
            gfx = CreateGraphics();
            pen = new Pen(Color.Red, 4.0f);
        }

        private void tRender_Tick(object sender, EventArgs e)
        {
            gfx.Clear(this.BackColor);
            player1.DrawShip(gfx, pen);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "A")
            {
                player1.IsMovingLeft = true;
            }
            if (e.KeyCode.ToString() == "D")
            {
                player1.IsMovingRight = true;
            }
            if (e.KeyCode.ToString() == "W")
            {
                player1.IsMovingUp = true;
            }
            if (e.KeyCode.ToString() == "S")
            {
                player1.IsMovingDown = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                player1.IsMovingLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                player1.IsMovingRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                player1.IsMovingUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                player1.IsMovingDown = true;
            }
            if (e.KeyCode.ToString() == "Space")
            {
                b.X = player1.X;
                b.Y = player1.Y;
                tBullet.Enabled = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "A")
            {
                player1.IsMovingLeft = false;
            }
            if (e.KeyCode.ToString() == "D")
            {
                player1.IsMovingRight = false;
            }
            if (e.KeyCode.ToString() == "W")
            {
                player1.IsMovingUp = false;
            }
            if (e.KeyCode.ToString() == "S")
            {
                player1.IsMovingDown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                player1.IsMovingLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                player1.IsMovingRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                player1.IsMovingUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                player1.IsMovingDown = false;
            }


        }

        private void tBullet_Tick(object sender, EventArgs e)
        {
            b.DrawBullet(gfx, pen);
            if (b.Active == false)
            {
                tBullet.Enabled = false;
                b.ResetBullet();
            }
        }
    }
}

