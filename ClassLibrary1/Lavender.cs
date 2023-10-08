namespace ClassLibrary1
{
    public class Lavender : Flower
    {
        public override string Name
        {
            get => name;
            protected set
            {
                if (name == null)
                {
                    name = value;
                }
            }
        }
        private string name = "Lavender";
        public override string Color { get => color; set => color = value; }
        private string color = "purple";
        public override int CountOfLeaves { get => count; set => count = value; }
        private int count = 50;

        public override string GetDescription()
        {
            return $"Flower name is: {Name}. It blooms {Color}. It has {(CountOfLeaves < 30 ? "few" : "a lot of")} leaves. It's good for making perfumes!";
        }

        public new string Bloom()
        {
            return $"I bloom in summer, I am {Color}!";
        }

        public override int GetCountOfLeaves()
        {
            return CountOfLeaves;
        }
    }
}
