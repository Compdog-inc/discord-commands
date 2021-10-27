using System;
using System.Collections.Generic;
using DiscordCommands.Shared;

namespace MyCommands
{
    public class ExampleCommand : ICommand
    {
        public void Init(Manager<string, ICommand> manager)
        {
            manager.Subscribe("test", this); // (command_name, command) command_name is case insensitive
        }

        public bool Run(string[] args, string channel, string authorization, out Message message)
        {
            message = new Message("Hello!", "My Example Command"); // (message_content, message_username) when username is null default one is used
            return true; // true - completed, false - continue background work and close request
        }
    }
}
