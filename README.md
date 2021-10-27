# Discord Commands

## Setup
Every reload of discord you need to run the script [discord-commands.js](discord-commands.js) in the discord console.  
You also need to run the host locally (`DiscordCommands.exe`).  
Once the setup is done you can send `/help` in any channel/DM to test it.

## Run commands in channels (including DMs)
To run a command just send `/[command] [arg1] [arg2]...`. If it's a valid command it won't get sent and `Discord Commands` (username can be changed by command) bot will respond.

## Adding commands
To add commands just put command or command pack files (`.dll`) in the `commands/` directory of the host

## Creating a command
- Create a C# project with .NET 4.7.2.
- Add the shared.dll to references.
- Create a class that implements `DiscordCommands.Shared.ICommand` [example](examples/Command.cs)
- Once you've compiled only copy the `.dll` to the commands directory. `shared.dll` shouldn't be copied. Any dependencies excluding `Newtonsoft.Json` can be copied to the root directory.

## Creating a command pack
- Create a C# project with .NET 4.7.2.
- Add the shared.dll to references.
- Create the commands in that pack
- Create a class that implements `DiscordCommands.Shared.ICommandPack` [example](examples/Pack.cs)
- Once you've compiled only copy the `.dll` to the commands directory. `shared.dll` shouldn't be copied. Any dependencies excluding `Newtonsoft.Json` can be copied to the root directory.
