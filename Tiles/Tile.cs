namespace GridLife{
    public abstract class Tile{
        public Color color {get; set;}

        public Tile(){
            color = Color.FromArgb(40, 40, 60);
        }
    }
}