namespace Logic.URL
{
    public class Parameter
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public Parameter() { }

        public Parameter(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}