namespace Expressions.Task3.E3SQueryProvider.Models.Entities
{
    public class Brackets
    {
        public string Left { get; }
        public string Right { get; }

        public Brackets(string left, string right)
        {
            Left = left;
            Right = right;
        }
    }
}
