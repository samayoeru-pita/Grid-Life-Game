using GridLife.src;
using GridLife.Tiles;
using System.ComponentModel.Design;

namespace GridLife
{
    public class Player : Entity{
        public int selectedTile = 0;
        public Player(Vector2 pos, ref Terrain ter) : base(pos, ref ter, 0){
            color = Color.FromArgb(50, 220, 60);
        }

        public void Interact( Vector2 dir)
        {
            Vector2 newPos = pos + dir;

            if(selectedTile == 0) {
                ter.tiles[newPos.x, newPos.y] = new EmptyTile();
                ter.LoadTiles();
                return;
            }

            if (ter.GetTile(newPos) is Door door) {
                door.ChangeState();
                return;
            }
            if (ter.GetTile(newPos) is Door doorv2) {
                doorv2.ChangeState();
                return;
            }
            if(ter.GetTile(newPos) is not EmptyTile) return;

            if(ter.CheckForTile(newPos)) {
                switch(selectedTile) {
                    case 1:
                        ter.tiles[newPos.x, newPos.y] = new Wall();
                        break;
                    case 2:
                        ter.tiles[newPos.x, newPos.y] = new Door();
                        break;
                    default:
                        ter.tiles[newPos.x, newPos.y] = new EmptyTile();
                        Console.WriteLine("Wrong tile index. Placing empty tile.");
                        break;
                }
                ter.LoadTiles();
            }
        }
    }
}