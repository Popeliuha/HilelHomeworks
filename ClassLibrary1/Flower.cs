namespace ClassLibrary1
{
    public abstract class Flower
    {
        public abstract string Name { get; protected set; }
        public abstract string Color { get; set; }
        public abstract int CountOfLeaves { get; set; }

        public virtual string GetDescription()
        {
            return $"Flower name is: {Name}. It blooms {Color}. It has {(CountOfLeaves < 30 ?  "few" : "a lot of")} leaves";
        }

        public string Bloom()
        {
            return $"I bloom {Color}!";
        }

        public abstract int GetCountOfLeaves();
    }
}
