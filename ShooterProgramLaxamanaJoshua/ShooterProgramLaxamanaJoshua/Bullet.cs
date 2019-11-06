﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ShooterProgramLaxamanaJoshua
{
    class Bullet
    {
        public int X;
        public int Y;
        public int Size = 20;
        public int Speed = 10;
        public bool Active = true;
        public int LifeSpanLimit = 30;
        public int LifeSpan = 0;

        public void DrawBullet(Graphics g, Pen p)
        {
            if (LifeSpan <= LifeSpanLimit)
            {
                g.DrawEllipse(p, X - (Size / 2), Y - (Size / 2), Size, Size);
                Y = Y - Speed;
                LifeSpan++;
            }
            else
            {
                Active = false;
            }
        }

        public void ResetBullet()
        {
            LifeSpan = 0;
            Active = true;
        }
    }
}
