using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class AntiGravityPoint : IImpactPoint
    {
        public int Power = 30; // сила отторжения

        // а сюда по сути скопировали с минимальными правками то что было в UpdateState
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX -= gX * Power / r2; // тут минусики вместо плюсов
            particle.SpeedY -= gY * Power / r2; // и тут
        }
        public override void Render(Graphics g)
        {
            // буду рисовать окружность с диаметром равным Power

            g.FillEllipse(
                    new SolidBrush(Color.Blue),
                    X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
                );
        }
    }

}
