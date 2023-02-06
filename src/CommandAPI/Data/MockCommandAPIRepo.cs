using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommnads()
        {
            var commands = new List<Command>()
            {
                new Command {  Id = 0, HowTo = "how to generate a migration", Platform = ".net core ef", CommandLine = "dotnet ef migrations add <name of migration>"},
                new Command {  Id = 1, HowTo = "run migrations", Platform = ".net core ef", CommandLine = "dotnet ef database update"},
                new Command {  Id = 2, HowTo = "list active migration", Platform = ".net core ef", CommandLine = "dotnet ef migrations list>"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
                return new Command {  Id = 0, HowTo = "how to generate a migration", Platform = ".net core ef", CommandLine = "dotnet ef migrations add <name of migration>"};
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}