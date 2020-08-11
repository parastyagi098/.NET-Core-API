using System.Collections.Generic;
using Apidemo.Models;

namespace Apidemo.Data
{
    public class MockApidemoRepo : IApiRepo
    {
        public IEnumerable<Api> GetAppCommands()
        {
            var commands = new List<Api>
            {
             new Api{Id=0, HowTo="make noodles", Line="Boil Water", Platform="Kettle"},
             new Api{Id=1, HowTo="cut bread", Line="Get a Knife", Platform="chopping board"},
             new Api{Id=2, HowTo="make Tea", Line="get tea bag", Platform="Cup"}
            };

            return commands;
        }

        public Api GetCommandById(int id)
        {
            return new Api{Id=0, HowTo="make noodles", Line="Boil Water", Platform="Kettle"};
        }
    }
}