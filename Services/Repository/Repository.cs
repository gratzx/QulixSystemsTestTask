using QulixSystemsTestTask.Services.ExecuteCommand;
using QulixSystemsTestTask.Services.Queries;

namespace QulixSystemsTestTask.Services.Repository
{
    public partial class Repository : IRepository
    {
        private readonly IExecuters _executers;
        private readonly ICommandText _commandText;
        public Repository(
            IExecuters executers,
            ICommandText commandText
        )
        {
            _executers = executers;
            _commandText = commandText;
        }
    }
}