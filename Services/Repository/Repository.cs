using Microsoft.Extensions.Configuration;

using QulixSystemsTestTask.Services.ExecuteCommand;
using QulixSystemsTestTask.Services.Queries;

namespace QulixSystemsTestTask.Services.Repository
{
    public partial class Repository : IRepository
    {
        private readonly IConfiguration _configuration;
        private readonly IExecuters _executers;
        private readonly string _connectionString;
        private readonly ICommandText _commandText;
        public Repository(
            IConfiguration configuration,
            IExecuters executers,
            ICommandText commandText
        )
        {
            _configuration = configuration;
            _executers = executers;
            _commandText = commandText;
            _connectionString = configuration.GetConnectionString("Qulix");
        }
    }
}