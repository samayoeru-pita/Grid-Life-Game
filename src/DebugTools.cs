namespace GridLife.src
{
    public class DebugTools
    {
        static List<Vector2> resetTiles;
        static Terrain ter;

        public static void Set(ref Terrain terrain)
        {
            resetTiles = new List<Vector2>();
            ter = terrain;
        }

        public static void AddTile(Vector2 tile)
        {
            if(ter.GetTile(tile) is not Entity) {
                ter.tiles[tile.x, tile.y].color = Color.White;
                resetTiles.Add(tile);
            }
        }
        public static bool HasElements()
        {
            return resetTiles.Count > 0;
        }
        public static void Clear()
        {
            lock (resetTiles) {
                if(resetTiles.Count == 0) return;
                foreach(Vector2 v in resetTiles) {
                    if(ter.GetTile(v) is Entity) continue;
                    ter.tiles[v.x, v.y].color = Color.FromArgb(40, 40, 60);
                }
                resetTiles = new List<Vector2>();
            }

        }
    }
}
