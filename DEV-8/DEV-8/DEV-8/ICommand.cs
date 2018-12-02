namespace DEV8
{
    /// <summary>
    /// The abstract command defines a common interface for specific
    /// classes of commands and contains the basic behavior of the cancel operation.
    /// </summary>
    abstract class ICommand
    {
        public abstract void Execute();
    }
}