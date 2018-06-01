namespace LeafletDotNet
{
    public abstract class Layer
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public string Attribution { get; set; }
        public int? MaxZoom { get; set; }
        public bool Selected { get; set; }
        public Bounds Bounds { get; set; }
    }
}

