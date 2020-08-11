using System.Collections.Generic;
using Apidemo.Models;

namespace Apidemo.Data
{
    public interface IApiRepo
    {
        IEnumerable<Api> GetAppCommands();
        Api GetCommandById(int id);
    }
}