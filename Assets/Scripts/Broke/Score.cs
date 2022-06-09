namespace Broke
{
    public struct Score
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public override string ToString()
            => $"R: {Red}, G: {Green}, B:{Blue}";
    }
}