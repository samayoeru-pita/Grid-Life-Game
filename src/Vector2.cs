namespace GridLife.src
{
    public class Vector2
    {
        public int x { get; set; }
        public int y { get; set; }

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x + v2.x, v1.y + v2.y);
        }
        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x - v2.x, v1.y - v2.y);
        }
        public static Vector2 operator *(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x * v2.x, v1.y * v2.y);
        }
        public static Vector2 operator *(Vector2 v1, int i)
        {
            return new Vector2(v1.x * i, v1.y * i);
        }
        public static bool operator ==(Vector2 v1, Vector2 v2)
        {
            return (v1.x == v2.x && v1.y == v2.y);
        }
        public static bool operator !=(Vector2 v1, Vector2 v2)
        {
            return (v1.x != v2.x || v1.y != v2.y);
        }
        public override bool Equals(Object obj)
        {
            if (obj == null || obj is not Vector2) return false;

            Vector2 other = (Vector2)obj;
            return (x == other.x && y == other.y);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(x, y);
        }
    }
}