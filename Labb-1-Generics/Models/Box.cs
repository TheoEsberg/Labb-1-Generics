using Labb_1_Generics.Controllers;

namespace Labb_1_Generics.Models
{
    public class Box : IEquatable<Box>
    {
        public Box(int w, int h, int l)
        {
            height = h;
            length = l;
            width = w;
        }
        public int height { get; set; }
        public int length { get; set; }
        public int width { get; set; }

        public bool Equals(Box? other)
        {
            return new BoxSameDimensions().Equals(this, other) || new BoxSameVolume().Equals(this, other);
        }
        public override bool Equals(object obj) { return base.Equals(obj); }
        public override int GetHashCode() { return base.GetHashCode(); }
    }
}
