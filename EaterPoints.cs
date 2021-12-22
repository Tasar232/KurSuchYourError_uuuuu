﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class EaterPoints : IImpactPoint
    {
        public int countShaval = 0;
        public static Random rand = new Random();
        public int Radius; // радиус частицы
        public int X; // X координата положения частицы в пространстве
        public int Y; // Y координата положения частицы в пространстве
        public int Power = 100;
        public int LifeET = 2000;
        public List<IImpactPoint> impactPoints = new List<IImpactPoint>();

        public EaterPoints()
        {
            Radius = 80;
            LifeET = 2000;
        }
        public override void ImpactParticle(Particle particle)
        {

            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);
            // particle.SpeedX += gX* Power / r2; // тут минусики вместо плюсов
            //particle.SpeedY += gY* Power / r2; // и тут
            double r = Math.Sqrt(gX * gX + gY * gY);
            if (r + particle.Radius < 50)
            {
                particle.Life = 0;
                countShaval++;
                LifeET--;

                //particle.SpeedX += gX * Power / r2; // тут минусики вместо плюсов
                //particle.SpeedY += gY* Power / r2; // и тут
            }

        }

        

        public override void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.Black),
                    X - Radius / 2,
                    Y - Radius / 2,
                    Radius ,
                    Radius
                );
            g.DrawEllipse(
                    new Pen(Color.Red),
                    X - Radius / 2,
                    Y - Radius / 2,
                    Radius,
                    Radius
                );

            var stringFormat = new StringFormat(); // создаем экземпляр класса
            stringFormat.Alignment = StringAlignment.Center; // выравнивание по горизонтали
            stringFormat.LineAlignment = StringAlignment.Center; // выравнивание по вертикали
            var text = $"Емкость {LifeET}";
            var font = new Font("Verdana", 10);
            var size = g.MeasureString(text, font);
            g.FillRectangle(
            new SolidBrush(Color.Red),
            X - size.Width / 2, // так как я выравнивал текст по центру то подложка должна быть центрирована относительно X,Y
            Y - size.Height / 2,
            size.Width,
            size.Height
            );
            g.DrawString(
            text, // надпись, можно перенос строки вставлять (если вы Катя, то может не работать и надо использовать \r\n)
            font, // шрифт и его размер
            new SolidBrush(Color.Black), // цвет шрифта
            X, // расположение в пространстве
            Y,
            stringFormat
        );
        }
        //public virtual void Draw(Graphics g)
        //{
        //    // рассчитываем коэффициент прозрачности по шкале от 0 до 1.0
        //    //float k = Math.Min(1f, Life / 100);
        //    // рассчитываем значение альфа канала в шкале от 0 до 255
        //    // по аналогии с RGB, он используется для задания прозрачности
        //    //int alpha = (int)(k * 255);
        //
        //    // создаем цвет из уже существующего, но привязываем к нему еще и значение альфа канала
        //    var color = Color.Blue;
        //    var b = new SolidBrush(color);
        //
        //    // остальное все так же
        //    g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);
        //
        //    b.Dispose();
        //}

    }
}
