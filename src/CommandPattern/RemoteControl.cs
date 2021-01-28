namespace CommandPattern
{
    public class RemoteControl
    {
        private ICommand[] OnCommands { get; } = new ICommand[7];
        private ICommand[] OffCommands { get; set; } = new ICommand[7];

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            OnCommands[slot] = onCommand;
            OffCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            OnCommands[slot].Execute();
        }

        public void OffButtonWasPressed(int slot)
        {
            OffCommands[slot].Execute();
        }
    }
}
