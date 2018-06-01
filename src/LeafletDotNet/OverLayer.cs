namespace LeafletDotNet
{
    public class OverLayer : Layer
    {
        public OverLayer()
        {
            Active = true;
            ZIndex = 0;
        }

        public int ZIndex { get; set; }
        public bool Active { get; set; }
    }
}

