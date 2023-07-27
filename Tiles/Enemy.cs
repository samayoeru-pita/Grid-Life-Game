using GridLife.src;

namespace GridLife.Tiles
{
    public class Enemy : Entity
    {
        public Enemy(Vector2 pos, ref Terrain ter, int team) : base(pos, ref ter, team) {
            this.color = Color.DarkRed;
        }

        void Pathfind()
        {

        }
    }
}
