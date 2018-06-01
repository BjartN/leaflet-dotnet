using GeoJSON.Net.Feature;
using System.Linq;

namespace LeafletDotNet
{
    public static class MapStateExtentions
    {
        const int MapWidthPx = 1000;
        const int MapHeightPx = 200;

        /// <summary>
        /// Make sure starting map bounds will show all within bounds
        /// </summary>
        public static void EnsureRelevantBounds(
            this MapState state,
            Bounds bounds)
        {
            var poi = bounds.Center();

            state.FitBounds = new Bounds
            {
                East = bounds.East,
                North = bounds.North,
                South = bounds.South,
                West = bounds.West
            };
        }

        /// <summary>
        /// Make sure the base layer covers relevant point
        /// </summary>
        public static void EnsureRelevantBaseLayer(this MapState state, Bounds bounds)
        {
            var poi = bounds.Center();
            state.EnsureRelevantBaseLayer(poi);
        }

        public static void EnsureRelevantBaseLayer(this MapState state, LatLon poi)
        {
            var outofBoundLayers = state.BaseLayers.NoIntersect(poi);

            foreach (var layer in outofBoundLayers)
            {
                layer.Selected = false;
            }

            state.EnsureBaseLayerActive();
        }

        /// <summary>
        /// Make sure some base layer is seleced
        /// </summary>
        public static void EnsureBaseLayerActive(this MapState state)
        {
            if (!state.BaseLayers.Any(x => x.Selected))
            {
                state.BaseLayers.First().Selected = true;
            }
        }
    }


    public class MapState
    {
        public MapState()
        {
            Points = new Point[0];
        }

        public double Lat { get; set; }
        public double Lon { get; set; }
        public int Zoom { get; set; }
        public BaseLayer[] BaseLayers { get; set; }
        public OverLayer[] Overlays { get; set; }
        public Point[] Points { get; set; }
        public FeatureCollection[] GeoJsonLayers { get; set; }
        public Bounds FitBounds { get; internal set; }
    }

}

