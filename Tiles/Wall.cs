namespace GridLife{
    public class Wall : Tile{

        public Wall(Color col){
            this.color = col;
        }
        public Wall()
        {
            this.color = Color.Crimson;
        }
    }
}