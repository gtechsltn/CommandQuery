namespace CommandQuery.Sample.Contracts.Commands
{
    public class BazCommand : ICommand<Baz>
    {
        public string Value { get; set; }
    }

    public class Baz
    {
        public bool Success { get; set; }
    }
}