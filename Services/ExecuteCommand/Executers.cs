using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;

namespace QulixSystemsTestTask.Services.ExecuteCommand
{
    public class Executers : IExecuters
    {
        private readonly DbConnection _dbConnection;
        public Executers(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        async Task IExecuters.ExecuteCommand(Func<IDbConnection, Task> task)
        {
            using(_dbConnection)
            {
                try
                {
                    await _dbConnection.OpenAsync();
                    await task(_dbConnection);
                }
                catch (TimeoutException exception)
                {
                    throw new Exception(
                        $"{GetType().FullName} expirienced a Timeout Exception",
                        exception
                    );
                }
                catch (SqlException exception)
                {
                    throw new Exception(
                        $"{GetType().FullName} expirienced a Sql Exception",
                        exception
                    );
                }
                finally
                {
                    await _dbConnection.CloseAsync();
                }
            }
        }

        async ValueTask<T> IExecuters.ExecuteCommandWithResult<T>(Func<IDbConnection, Task<T>> task)
        {
            using(_dbConnection)
            {
                try
                {
                    await _dbConnection.OpenAsync();
                    return await task(_dbConnection);
                }
                catch (TimeoutException exception)
                {
                    throw new Exception(
                        $"{GetType().FullName} expirienced a Timeout Exception",
                        exception
                    );
                }
                catch (SqlException exception)
                {
                    throw new Exception(
                        $"{GetType().FullName} expirienced a Sql Exception",
                        exception
                    );
                }
                finally
                {
                    await _dbConnection.CloseAsync();
                }
            }
        }
    }
}