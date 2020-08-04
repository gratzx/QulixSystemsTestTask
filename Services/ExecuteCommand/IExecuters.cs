using System;
using System.Data;
using System.Threading.Tasks;

namespace QulixSystemsTestTask.Services.ExecuteCommand
{
    public interface IExecuters
    {
        Task ExecuteCommand(Func<IDbConnection, Task> task);

        ValueTask<T> ExecuteCommandWithResult<T>(Func<IDbConnection, Task<T>> task);
    }

}