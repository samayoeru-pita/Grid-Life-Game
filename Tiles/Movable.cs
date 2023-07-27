using GridLife.src;
using GridLife.Tiles;

namespace GridLife
{
    public abstract class Movable : Tile{
        public Vector2 pos;
        public Terrain ter;
        private Door? lastDoor;

        public Movable(Vector2 pos, ref Terrain ter)
        {
            this.pos = pos;
            this.ter = ter;
            ter.tiles[pos.x, pos.y] = this;
        }

        public void Move(Vector2 dir){
            Vector2 newPos = this.pos + dir;

            if(!ter.CheckForTile(newPos)) return;

            else if(ter.GetTile(newPos) is Door door) {
                if(!door.canMoveThrough) return;
                newPos = this.pos + dir * 2;

                if(ter.GetTile(newPos) is not EmptyTile) return;

                ter.tiles[newPos.x, newPos.y] = this;
                ter.tiles[pos.x, pos.y] = new EmptyTile();
                pos = newPos;
                ter.LoadTiles();
            }
            else if((ter.GetTile(newPos) is EmptyTile emptyT)) {
                ter.tiles[pos.x, pos.y] = lastDoor == null ? emptyT : lastDoor;
                ter.tiles[newPos.x, newPos.y] = this;
                pos = newPos;
                lastDoor = null;
                ter.LoadTiles();
            }
        }
        public Vector2 GetDir(Vector2 target)
        {
            Vector2 dist = Distance(target);
            Vector2 dir = new Vector2(0, 0);
            dir.x = dist.x > 0 ? 1 : dist.x < 0 ? -1 : 0;
            dir.y = dist.y > 0 ? 1 : dist.y < 0 ? -1 : 0;
            return dir;
        }
        public Vector2 Distance(Vector2 target)
        {
            return target - this.pos;
        }
    }
}