using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Emitter
    {
        public int X; // координата X центра эмиттера, будем ее использовать вместо MousePositionX
        public int Y; // соответствующая координата Y 
        public int Direction = 180; // вектор направления в градусах куда сыпет эмиттер
        public int Spreading = 360; // разброс частиц относительно Direction
        public int SpeedMin = 1; // начальная минимальная скорость движения частицы
        public int SpeedMax = 10; // начальная максимальная скорость движения частицы
        public int RadiusMin = 2; // минимальный радиус частицы
        public int RadiusMax = 10; // максимальный радиус частицы
        public int LifeMin = 20; // минимальное время жизни частицы
        public int LifeMax = 100; // максимальное время жизни частицы
        public int RndSizeDirection = 0;

        public int ParticlesPerTick = 1; // добавил новое поле

        public Color ColorFrom = Color.White; // начальный цвет частицы
        public Color ColorTo = Color.FromArgb(0, Color.Black); // конечный цвет частиц
        Random rnd = new Random();

        public List<IImpactPoint> impactPoints = new List<IImpactPoint>();

        public float GravitationX = 0;
        public float GravitationY = 1;
        public List<Particle> particles = new List<Particle>();

        public int ParticlesCount = 10;

        public void UpdateState()
        {
            


            int particlesToCreate = ParticlesPerTick; // фиксируем счетчик сколько частиц нам создавать за тик

            foreach (var particle in particles)
            {
                

                particle.Life -= 1; // уменьшаю здоровье
                                    // если здоровье кончилось
                if (particle.Life < 0)
                {
                    particle.Life = 0;
                    if (particlesToCreate > 0)
                    {
                        //Direction = rnd.Next(RndSizeDirection);
                        /* у нас как сброс частицы равносилен созданию частицы */
                        particlesToCreate -= 1; // поэтому уменьшаем счётчик созданных частиц на 1
                        ResetParticle(particle);
                    }
                }
                else
                {
                    // а это наш старый код
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;

                    foreach (var point in impactPoints)
                    {
                        point.ImpactParticle(particle);
                    }
                    
                    //particle.SpeedX += GravitationX;
                    //particle.SpeedY += GravitationY;
                    
                }
            }
            
            while (particlesToCreate >= 1)
            {
                //Direction = rnd.Next(RndSizeDirection);
                particlesToCreate -= 1;
                var particle = CreateParticle();
                ResetParticle(particle);
                particles.Add(particle);
            }
        }
        public bool UpdateStateBlackEater()
        {
            foreach (var eater in impactPoints)
            {
                if (eater is EaterPoints)
                {
                    if ((eater as EaterPoints).LifeET < 1)
                    {
                        int spreading = Spreading;
                        int x = X;
                        int y = Y;
                        X = (eater as EaterPoints).X;
                        Y = (eater as EaterPoints).Y;
                        for (int i = 0; i < (eater as EaterPoints).countShaval; i++)
                        {
                            var particle = CreateParticle(); // и собственно теперь тут его вызываем
                            ResetParticle(particle);
                            particles.Add(particle);
                            Spreading = 360;


                        }
                        Spreading = spreading;
                        
                        X = x;
                        Y = y;
                        
                        impactPoints.Remove(eater);
                        
                        return true;
                    }
                }
            }
            return false;
        }


        // добавил новый метод, виртуальным, чтобы переопределять можно было
        public virtual void ResetParticle(Particle particle)
        {
            particle.Life = Particle.rand.Next(LifeMin, LifeMax);

            particle.X = X;
            particle.Y = Y;

            var direction = Direction
                + (double)Particle.rand.Next(Spreading)
                - Spreading / 2;

            var speed = Particle.rand.Next(SpeedMin, SpeedMax);
            particle.Speed = speed;
            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.Radius = Particle.rand.Next(RadiusMin, RadiusMax);
        }

        public virtual Particle CreateParticle()
        {
            var particle = new ParticleColorful();
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;

            return particle;
        }

        public void Render(Graphics g)
        {
            // ну тут так и быть уж сам впишу...
            // это то же самое что на форме в методе Render
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }

            foreach (var point in impactPoints)
            {
                point.Render(g);
            }
        }
    }
}
