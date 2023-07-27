namespace GridLife.Tiles
{
    public class Door : Tile
    {
        public bool canMoveThrough;
        public Door()
        {
            this.color = Color.Yellow;
            canMoveThrough = true;
        }
        public void ChangeState()
        {
            canMoveThrough = !canMoveThrough;
            Console.WriteLine($"Door state: {canMoveThrough}");
            this.color = canMoveThrough ? Color.Yellow : Color.Silver;
        }
    }
}
