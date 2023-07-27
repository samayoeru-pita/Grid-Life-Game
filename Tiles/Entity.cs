using GridLife.src;
using GridLife.Tiles;
using System.Xml.Serialization;

namespace GridLife
{
    public abstract class Entity : Movable
    {
        public int team;
        Dictionary<Vector2, int>? openT;
        Dictionary<Vector2, int>? closedT;
        List<Vector2>? path;

        public Entity(Vector2 pos, ref Terrain ter, int team) : base(pos, ref ter)
        {
            this.team = team;
        }

        public void Pathfind(Vector2 target)
        {
            openT = new Dictionary<Vector2, int>();
            closedT = new Dictionary<Vector2, int>();
            path = new List<Vector2>();
            Dictionary<Vector2, int> fScores = new Dictionary<Vector2, int>();
            Dictionary<Vector2, int> gScores = new Dictionary<Vector2, int>();
            Dictionary<Vector2, Vector2> cameFrom = new Dictionary<Vector2, Vector2>();

            gScores[pos] = 0;
            fScores[pos] = HeuristicCost(pos, target);
            openT.Add(pos, fScores[pos]);

            int iter = 0;
            while (openT.Count > 0 && iter < 90) {
                Vector2 current = openT.OrderBy(t => fScores[t.Key]).First().Key;
                openT.Remove(current);
                closedT.Add(current, fScores[current]);

                if (current == target) {
                    while(cameFrom.ContainsKey(current)) {
                        DebugTools.AddTile(current);
                        path.Insert(0, current);
                        current = cameFrom[current];
                    }
                    Vector2 direction = path.First() - pos;
                    Move(direction);
                    break;
                }

                for(int x = current.x - 1; x <= current.x + 1; x++) {
                    for(int y = current.y - 1; y <= current.y + 1; y++) {
                        Vector2 neighborPos = new Vector2(x, y);
                        if(x != current.x && y != current.y) continue;
                        Tile neighborTile = ter.GetTile(neighborPos);
                        if(neighborTile == null) continue;
                        if((neighborTile is not EmptyTile && neighborTile is not Door && neighborTile is not Entity) || closedT.ContainsKey(neighborPos)) continue;

                        int tentGScore = gScores[current] + 1;

                        if(!gScores.ContainsKey(neighborPos) || tentGScore < gScores[neighborPos]) {
                            gScores[neighborPos] = tentGScore;
                            fScores[neighborPos] = tentGScore + HeuristicCost(neighborPos, target);
                            if(!openT.ContainsKey(neighborPos)) {
                                openT.Add(neighborPos, fScores[neighborPos]);
                            }else {
                                openT[neighborPos] = fScores[neighborPos];
                            }
                            cameFrom[neighborPos] = current;
                        }
                    }
                }
                iter++;
            }
            
        }
        static int HeuristicCost(Vector2 pos, Vector2 target)
        {
            return Math.Abs(pos.x - target.x) + Math.Abs(pos.y - target.y);
        }
    }
}
