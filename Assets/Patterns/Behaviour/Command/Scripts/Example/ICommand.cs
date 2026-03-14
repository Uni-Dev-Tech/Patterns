namespace Patterns.Command.Example
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}