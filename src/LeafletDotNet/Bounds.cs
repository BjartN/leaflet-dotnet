
namespace LeafletDotNet
{
    public class Bounds
    {
        public double East { get; set; }
        public double North { get; set; }
        public double South { get; set; }
        public double West { get; set; }

        public bool Contains(double lat, double lon)
        {
            return lat > South && lat < North && lon > West && lon < East;
        }
        public bool Contains(LatLon p)
        {
            return p.Lat > South && p.Lat < North && p.Lon > West && p.Lon < East;
        }
    }
}
