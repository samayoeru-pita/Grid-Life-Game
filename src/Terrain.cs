using System.IO;

namespace GridLife.src
{
    public class Terrain
    {
        public Tile[,] loadedTiles;
        public Tile[,] tiles;
        public readonly int width, height;
        private Vector2 loadedPos;
        public readonly Vector2 maxBounds;
        public Entity[] entities;

        public Terrain(Vector2 loadRes, Vector2 bounds, Vector2 loadPos)
        {
            width = loadRes.x;
            height = loadRes.y;
            maxBounds = bounds;
            loadedPos = loadPos;
            tiles = new Tile[bounds.x, bounds.y];
            loadedTiles = new Tile[width, height];
            Console.WriteLine($"Terrain width: {width}, height: {height}");
            GenerateTerrain(ref tiles);
            LoadTiles();
            entities = new Entity[3];
        }

        private void GenerateTerrain(ref Tile[,] t)
        {
            Random random = new();
            for (int x = 0; x < maxBounds.x; x++)
            {
                for (int y = 0; y < maxBounds.y; y++)
                {
                    int id = random.Next(6);
                    t[x, y] = id switch
                    {
                        0 => new EmptyTile(),
                        1 => new Wall(),
                        _ => new EmptyTile(),
                    };
                }
            }
            Console.WriteLine("Tile generation completed.");
        }

        public bool CheckForTile(Vector2 pos)
        {
            if (pos.x < 0 || pos.y < 0 || pos.x >= maxBounds.x || pos.y >= maxBounds.y)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Tile? GetTile(Vector2 pos)
        {
            if(CheckForTile(pos)) {
                return tiles[pos.x, pos.y];
            }
            else {
                return null;
            }
        }

        public Vector2 GetTileIndex(Tile t)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (t.Equals(loadedTiles[x, y]))
                    {
                        return new Vector2(x, y);
                    }
                }
            }
            return new Vector2(0, 0);
        }

        public void LoadTiles()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    loadedTiles[x, y] = tiles[x + loadedPos.x, y + loadedPos.y];
                }
            }
        }

        public void MoveLoadedPos(Vector2 dir)
        {
            Vector2 newLoadedPos = loadedPos + dir;
            if (newLoadedPos.x >= 0 && newLoadedPos.y >= 0 && newLoadedPos.x + width - 1 < maxBounds.x && newLoadedPos.y + height - 1 < maxBounds.y)
            {
                loadedPos = newLoadedPos;
                LoadTiles();
            }
        }

        public Vector2 GetLoadedPos(Vector2 globalPos)
        {
            return globalPos - loadedPos;
        }

        public static Vector2 GetDir(Vector2 pos, Vector2 target)
        {
            Vector2 dist = target - pos;
            Vector2 dir = new(0, 0)
            {
                x = dist.x > 0 ? 1 : dist.x < 0 ? -1 : 0,
                y = dist.y > 0 ? 1 : dist.y < 0 ? -1 : 0
            };
            return dir;
        }

        private Tile[,] LoadTerrain(int chunkX, int chunkY)
        {
            string chunkPath = "Chunks\\chunk" + chunkX + '_' + chunkY + ".glchunk";
            if (File.Exists(chunkPath + chunkX + '_' + chunkY))
            {
                StreamReader sr = new(chunkPath);
                int[,] ids = new int[50, 50];
                string id = "";
                int i = 0, j = 0;
                while (sr.ReadLine() != null)
                {
                    foreach (char c in sr.ReadLine())
                    {
                        id.Append(c);
                        if (c == ' ')
                        {
                            ids[i, j] = int.Parse(id);
                            id = "";
                            j++;
                        }
                    }
                    i++;
                }
                sr.Close();
                Console.WriteLine($"Loaded chunk {chunkX}, {chunkY}");
                return new Tile[10, 10];
            }
            else
            {
                Console.WriteLine($"Generating a new chunk {chunkX}, {chunkY}.");
                return new Tile[10, 10];
            }
        }
        private void SaveTerrain(Tile[,] tArr)
        {
            int[,] ids = new int[50, 50];

            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                }
            }
        }
    }
}