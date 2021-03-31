using GhabzeTo.Domain.Models.Logs;
using System.Threading.Tasks;

namespace GhabzeTo.Application.Interfaces
{
    public interface ISystemEventLogService
    {
        void Log(string message, SystemEventLogType logType = SystemEventLogType.Info, object data = null);
    }
}
