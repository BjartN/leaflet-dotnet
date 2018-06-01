namespace LeafletDotNet
{
    public class ExampleMapState
    {
        public static MapState MapState
        {
            get
            {
                var roughlyNorway = new Bounds
                {
                    West = 3.3,
                    East = 31.7,
                    South = 57.8,
                    North = 71.6
                };


                return new MapState
                {

                    Lat = 60.397076,
                    Lon = 5.324383,
                    Zoom = 12,
                    BaseLayers = new BaseLayer[]
                    {
                 new BaseLayer {
                    Name = "Trail Map Global",
                    Type = "tile",
                    Url ="https://{s}.tile.thunderforest.com/landscape/{z}/{x}/{y}.png?apikey=1c90154f4553496c8ad3eb6a69c981c9"
                },
                new BaseLayer {
                    Name = "Trail Map Norway",
                    Type = "wms",
                    WmsLayers = "topo4",
                    Url = "//opencache.statkart.no/gatekeeper/gk/gk.open",
                    Attribution =  "Kartverket",
                    Selected = true,
                    Bounds = roughlyNorway
                },
                new BaseLayer {
                    Name = "Satellitt ESRI",
                    Type = "tile",
                    Url ="//server.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer/tile/{z}/{y}/{x}",
                    Attribution = "&copy; Esri, i-cubed, USDA, USGS, AEX, GeoEye, Getmapping, Aerogrid, IGN, IGP, UPR-EGP, and the GIS User Community",
                    MaxZoom = 15
                },
               new BaseLayer  {
                  Name = "Coast Norway",
                  Type = "wms",
                  WmsLayers = "sjokartraster",
                  Url = "//opencache.statkart.no/gatekeeper/gk/gk.open",
                  Attribution =  "Kartverket",
                    Bounds = roughlyNorway
                },
               new BaseLayer  {
                  Name = "Seabed Norway",
                  Type = "wms",
                  WmsLayers = "havbunn_grunnkart",
                  Url = "//opencache.statkart.no/gatekeeper/gk/gk.open",
                  Attribution =  "Kartverket",
                    Bounds = roughlyNorway
                }
},
                    Overlays = new OverLayer[]
{
}
                };
            }
        }
    }
}

