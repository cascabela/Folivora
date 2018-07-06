namespace Folivora
{
    public class Case
    {
        public string Input { get; }
        public string Output { get; }

        public Case(string input, string output)
        {
            Input = input;
            Output = output;
        }
    }
}
