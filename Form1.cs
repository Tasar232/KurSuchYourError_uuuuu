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
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        GravityPoint point1; // добавил поле под первую точку
        AntiGravityPoint point2; // добавил поле под вторую точку
        EaterPoints eater = new EaterPoints();
        TelePort input = new TelePort(1);
        TelePort output = new TelePort(2);
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            eater.onLifeEnd = (ep) =>
            {
                emitter.Boom(ep);
                emitter.impactPoints.Remove(ep);

            };

            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 1,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 20,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter); // все равно добавляю в список emitters, чтобы он рендерился и обновлялся

        }

        int counter = 0; // добавлю счетчик чтобы считать вызовы функции
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // каждый тик обновляем систему
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.White);
                emitter.Render(g); // рендерим систему
            }

            picDisplay.Invalidate();
        }

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbEmitter.Checked)
            {
                emitter.X = e.X;
                emitter.Y = e.Y;
            } 
            else if (rbBlackEater.Checked)
            {
                emitter.impactPoints.Remove(eater);
                eater = new EaterPoints();
                
                eater.X = e.X;
                eater.Y = e.Y;
                emitter.impactPoints.Add(eater);
                eater.onLifeEnd = (ep) =>
                {
                    emitter.Boom(ep);

                    emitter.impactPoints.Remove(ep);
                };
            }
            else if (rbTeleport.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    emitter.impactPoints.Remove(input);
                    input = new TelePort(1);

                    input.X = e.X;
                    input.Y = e.Y;

                    input.Xbro = output.X;
                    input.Ybro = output.Y;

                    output.Xbro = input.X;
                    output.Ybro = input.Y;

                    emitter.impactPoints.Add(input);
                }
                else
                {
                    emitter.impactPoints.Remove(output);
                    output = new TelePort(2);

                    output.X = e.X;
                    output.Y = e.Y;

                    output.Xbro = input.X;
                    output.Ybro = input.Y;

                    input.Xbro = output.X;
                    input.Ybro = output.Y;

                    emitter.impactPoints.Add(output);
                }
            }
            else if (rbMagnite.Checked)
            {
                emitter.impactPoints.Remove(point1);
                point1 = new GravityPoint
                {
                    X = e.X,
                    Y = e.Y,
                };
                emitter.impactPoints.Add(point1);
            }
            else if (rbDeMagnite.Checked)
            {
                emitter.impactPoints.Remove(point2);
                point2 = new AntiGravityPoint
                {
                    X = e.X,
                    Y = e.Y,
                };
                emitter.impactPoints.Add(point2);
            }
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpreading.Value;
        }
        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;// направлению эмиттера присваиваем значение ползунка
        }

        private void tbPowerAntiGraviton_Scroll(object sender, EventArgs e)
        {
            point2.Power = tbPowerAntiGraviton.Value;
        }

        private void tbPowerGravitone_Scroll(object sender, EventArgs e)
        {
            point1.Power = tbPowerGravitone.Value;
        }
    }
}
