using DiscordCommands.Shared;

namespace MyCommands
{
    // Loads ExampleCommand, ExampleCommand2 and ExampleCommand3
    // You can also use command packs to load commands with constructors
    public class ExamplePack : ICommandPack
    {
        public void Load(Manager<ICommandPack, ICommand> manager)
        {
            // Subscribe(sender, command_instance)
            manager.Subscribe(this, new ExampleCommand());
            manager.Subscribe(this, new ExampleCommand2());
            manager.Subscribe(this, new ExampleCommand3());
        }
    }
}
