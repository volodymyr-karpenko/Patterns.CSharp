using System.Collections.Generic;

namespace Patterns.CSharp.Patterns.Command
{
    public class Invoker
    {
        private List<AbstractCommand> ExecutedCommands { get; set; }

        public Invoker()
        {
            ExecutedCommands = new List<AbstractCommand>();
        }        

        public void ExecuteCommand(AbstractCommand command)
        {
            command.Execute();
            ExecutedCommands.Add(command);
        }

        public void UndoLastCommand()
        {
            if (ExecutedCommands.Count < 1)
            {
                return;
            }

            ExecutedCommands[ExecutedCommands.Count - 1].UndoExecution();
            ExecutedCommands.RemoveAt(ExecutedCommands.Count - 1);            
        }
    }
}