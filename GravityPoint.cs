using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class GravityPoint : IImpactPoint
    {
        public int Power = 30; // сила притяжения
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);
            particle.SpeedX += gX * Power / r2;
            particle.SpeedY += gY * Power / r2;
        }

        public override void Render(Graphics g)
        {
            // буду рисовать окружность с диаметром равным Power
            g.DrawEllipse(
                        new Pen(Color.Green),
                       X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
                    );
        }
    }
}
