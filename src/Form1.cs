using System.Security.Cryptography.X509Certificates;
using System.Timers;
using GridLife.src;
using GridLife.Tiles;

namespace GridLife
{
    public partial class Form1 : Form
    {
        int width = Screen.PrimaryScreen.Bounds.Width;
        int height = Screen.PrimaryScreen.Bounds.Height;
        int tileSize;
        int spacing;
        Terrain terrain;
        Player player;
        private static System.Timers.Timer timer50;
        private static System.Timers.Timer timer200;

        public Form1()
        {
            Console.WriteLine($"Screen width: {width} height: {height}");

            tileSize = 16;
            spacing = 4;

            terrain = new Terrain(new Vector2(width / (tileSize + spacing), height / (tileSize + spacing)), new Vector2(500, 400), new Vector2(400, 100));
            player = new Player(new Vector2(450, 100), ref terrain);

            terrain.entities = new Entity[3];
            terrain.entities[0] = new Enemy(new Vector2(450, 45), ref terrain, 0);
            terrain.entities[1] = new Enemy(new Vector2(405, 100), ref terrain, 0);
            terrain.entities[2] = new Enemy(new Vector2(450, 155), ref terrain, 0);

            InitializeComponent();
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            KeyUp += new KeyEventHandler(Form1_KeyUp);

            MessageStorage.SetNextMessage(ref messageLabel);
            Cursor.Hide();
            SetTimer();

            DebugTools.Set(ref terrain);
        }

        void SetTimer()
        {
            timer50 = new System.Timers.Timer(50);
            timer200 = new System.Timers.Timer(250);
            timer50.Elapsed += GameTime50;
            timer200.Elapsed += GameTime200;
            timer50.Enabled = true;
            timer200.Enabled = true;
        }

        private void GameTime50(object source, ElapsedEventArgs e)
        {
            if(terrain.GetLoadedPos(player.pos).x > terrain.width - 10) terrain.MoveLoadedPos(new Vector2(1, 0));
            if(terrain.GetLoadedPos(player.pos).y > terrain.height - 10) terrain.MoveLoadedPos(new Vector2(0, 1));
            if(terrain.GetLoadedPos(player.pos).x < 10) terrain.MoveLoadedPos(new Vector2(-1, 0));
            if(terrain.GetLoadedPos(player.pos).y < 10) terrain.MoveLoadedPos(new Vector2(0, -1));

            Invalidate();
        }
        private void GameTime200(object source, ElapsedEventArgs e)
        {
            DebugTools.Clear();
            foreach(Entity ent in terrain.entities) {
                ent.Pathfind(player.pos);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            SolidBrush rectBrush = new(Color.White);

            int posX = spacing;
            for(int x = 0; x < terrain.width; x++) {
                int posY = spacing;
                for(int y = 0; y < terrain.height; y++) {
                    rectBrush.Color = terrain.loadedTiles[x, y].color;
                    g.FillRectangle(rectBrush, posX, posY, tileSize, tileSize);
                    posY += tileSize + spacing;
                }
                posX += tileSize + spacing;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode) {
                case Keys.W:
                    player.Move(new Vector2(0, -1));
                    Console.WriteLine("Player moves up.");
                    break;
                case Keys.A:
                    player.Move(new Vector2(-1, 0));
                    Console.WriteLine("Player moves left.");
                    break;
                case Keys.S:
                    player.Move(new Vector2(0, 1));
                    Console.WriteLine("Player moves down.");
                    break;
                case Keys.D:
                    player.Move(new Vector2(1, 0));
                    Console.WriteLine("Player moves right.");
                    break;
                case Keys.Q:
                    Application.Exit();
                    break;
                case Keys.Up:
                    player.Interact(new Vector2(0, -1));
                    break;
                case Keys.Left:
                    player.Interact(new Vector2(-1, 0));
                    break;
                case Keys.Down:
                    player.Interact(new Vector2(0, 1));
                    break;
                case Keys.Right:
                    player.Interact(new Vector2(1, 0));
                    break;
                case Keys.D1:
                    player.selectedTile = 0;
                    SelectedItemLabel.Text = "Break block";
                    break;
                case Keys.D2:
                    player.selectedTile = 1;
                    SelectedItemLabel.Text = "Crimson wall";
                    break;
                case Keys.D3:
                    player.selectedTile = 2;
                    SelectedItemLabel.Text = "Door";
                    break;
                case Keys.Enter:
                    MessageStorage.SetNextMessage(ref messageLabel);
                    break;
                default:
                    break;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
        }
    }
}