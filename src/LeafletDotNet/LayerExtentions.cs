using System.Linq;

namespace LeafletDotNet
{
    public static class LayerExtentions
    {
        public static BaseLayer[] NoIntersect(this BaseLayer[] layers, LatLon point)
        {
            return layers.Where(x => !x.IntersectsOrUnknown(point)).ToArray();
        }

        public static bool IntersectsOrUnknown(this BaseLayer b, LatLon point)
        {
            if (b.Bounds == null)
                return true;

            return b.Bounds.Contains(point);
        }
    }
}
