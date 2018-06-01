using System;
using System.Linq;

namespace LeafletDotNet
{
    public static class GeoExtentions
    {

        public static Bounds Bounds(this LatLon[] stream)
        {
            if (stream == null || stream.Length == 0)
                throw new ArgumentException("Cannot find bounds of empty stream");

            return new Bounds
            {
                East = stream.Max(x => x.Lon),
                West = stream.Min(x => x.Lon),
                North = stream.Max(x => x.Lat),
                South = stream.Min(x => x.Lat)
            };
        }

        public static LatLon Center(this Bounds b)
        {
            var lon = b.West + (b.East - b.West) / 2;
            var lat = b.South + (b.North - b.South) / 2;

            return new LatLon
            {
                Lat = lat,
                Lon = lon
            };
        }

    }
}
