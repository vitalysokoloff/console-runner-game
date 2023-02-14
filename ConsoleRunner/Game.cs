using System;
using System.Threading;

namespace ConsoleRunner
{
    public class Game
    {
        private int scores = 0;
        private bool playing = true;

        private Graphics graphics = new Graphics(80, 30, ' ');
        private GameObject ground = new GameObject(new Point(0, 29), new Point(80, 1), SpritePack.Ground);
        private Enemy enemy = new Enemy(new Point(70, 24), new Point(3, 6), SpritePack.Enemy);
        private Player player = new Player(new Point(12, 22), new Point(6, 8), SpritePack.Player);

        public void Start()
        {
            KeysController controller = new KeysController();
            controller.Space += player.KeyControl;
            Thread listening = new Thread(new ThreadStart(controller.Listen));
            Thread drawing = new Thread(new ThreadStart(Draw));
            Thread updating = new Thread(new ThreadStart(Update));

            listening.Start();
            drawing.Start();
            updating.Start();

        }

        public void Draw()
        {
            Thread.Sleep(34);

            graphics.Begin();
            ground.Draw(graphics.Context);
            enemy.Draw(graphics.Context);
            player.Draw(graphics.Context);
            graphics.End();

            Console.WriteLine("Scores: " + scores);
            Draw();
        }

        public void Update()
        {
            while (playing)
            {
                if (player.Intersect(enemy))
                {
                    playing = false;
                    graphics.BackGroundChar = '.';
                }
                

                Thread.Sleep(34);

                player.Update();
                enemy.Update();

                scores++;
            }
        }
    }
}
