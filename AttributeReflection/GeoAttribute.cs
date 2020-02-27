using System;

namespace AttributeReflection
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Constructor | AttributeTargets.Method)]
    public class GeoAttribute : Attribute
    {
        public int X { get; set; }
        public int Y { get; set; }
        public GeoAttribute() { }
        public GeoAttribute(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public override string ToString()
        {
            return $"[{X}; {Y}]";
        }
    }
}
