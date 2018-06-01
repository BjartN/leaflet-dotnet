namespace LeafletDotNet
{
    public class Point
    {
        public Point()
        {
            Color = "black";
            FillColor = "red";
            Radius = 4;
            FillOpacity = 0.6;
            Opacity = 1;
            Weight = 1;
        }

        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }

        public string Color { get; set; }
        public string FillColor { get; set; }
        public int Radius { get; set; }

        public double FillOpacity { get; set; }
        public double Opacity { get; set; }
        public int Weight { get; set; }
    }
}

