using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // собственно список, пока пустой
        List<Particle> particles = new List<Particle>();

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

             
            for (var i = 0; i < 500; ++i)
            {
                var particle = new Particle();
                // переношу частицы в центр изображения
                //particle.X = picDisplay.Image.Width / 2;
                //particle.Y = picDisplay.Image.Height / 2;
                particle.X = Particle.rand.Next(1920);
                particle.Y = Particle.rand.Next(1080);
                // добавляю список
                particles.Add(particle);
            }
        }

        private void picDisplay_Click(object sender, EventArgs e)
        {
            
        }

        // добавил функцию обновления состояния системы
        private void UpdateState()
        {
            foreach (var particle in particles)
            {
                particle.Life -= 1; // уменьшаю здоровье
                                    // если здоровье кончилось
                if (particle.Life < 0)
                {
                    // восстанавливаю здоровье
                    particle.Life = 20 + Particle.rand.Next(100);
                    // перемещаю частицу в центр
                    particle.X = Particle.rand.Next(1920);
                    particle.Y = Particle.rand.Next(1080);
           
                    particle.Direction = Particle.rand.Next(360);
                    particle.Speed = 1 + Particle.rand.Next(10);
                    particle.Radius = 2 + Particle.rand.Next(10);
                }
                else
                {
                    // а это наш старый код
                    var directionInRadians = particle.Direction / 180 * Math.PI;
                    particle.X += (float)(particle.Speed * Math.Cos(directionInRadians));
                    particle.Y -= (float)(particle.Speed * Math.Sin(directionInRadians));
                }
            }

           // // добавил генерацию частиц
           // // генерирую не более 10 штук за тик
           // for (var i = 0; i < 10; ++i)
           // {
           //     if (particles.Count < 500) // пока частиц меньше 500 генерируем новые
           //     {
           //         var particle = new Particle();
           //         particle.X = Particle.rand.Next(360);
           //         particle.Y = Particle.rand.Next(360);
           //         particles.Add(particle);
           //     }
           //     else
           //     {
           //         break; // а если частиц уже 500 штук, то ничего не генерирую
           //     }
           // }
        }

        // функция рендеринга
        private void Render(Graphics g)
        {
            // утащили сюда отрисовку частиц
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
        }

        int counter = 0; // добавлю счетчик чтобы считать вызовы функции
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateState(); // каждый тик обновляем систему

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.White);
                Render(g); // рендерим систему
            }

            picDisplay.Invalidate();
        }

        

    }
}
