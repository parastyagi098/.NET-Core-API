using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil and egg", Line="Boil water", Platform="Kettle and Pan"},
                new Command{Id=1, HowTo="Cut bread", Line="Get a knife", Platform="knife and chopping board"},
                new Command{Id=2, HowTo="Make tea", Line="place teabag in cup", Platform="kettle & cup"}
            };
            return commands;
        }

        public Command GetCommandsById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle and pan"};
        }
    }
}