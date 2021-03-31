using GhabzeTo.Application.Core.DTOs.SystemCall;
using GhabzeTo.Application.Interfaces;
using GhabzeTo.Domain.Models.Logs;
using GhabzeTo.Infra.Data.Core.Repositories;
using GhabzeTo.Infra.Data.Core.Uow;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GhabzeTo.Application.Services
{
    public class SystemEventLogService : ISystemEventLogService
    {
        private readonly IRepository<SystemEventLog, Guid> _repository;
        private readonly CurrentSystemCallInfo _currentSystemCallInfo;
        private readonly IUnitOfWork _unitOfWork;

        public SystemEventLogService(IRepository<SystemEventLog, Guid> repository,
                                     IUnitOfWork unitOfWork,
                                     CurrentSystemCallInfo currentSystemCallInfo)
        {
            _repository = repository;
            _currentSystemCallInfo = currentSystemCallInfo;
            _unitOfWork = unitOfWork;
        }

        public void Log(string message, SystemEventLogType logType = SystemEventLogType.Info, object data = null)
        {
            // get call stack
            var stackTrace = new StackTrace(1, true);
            var trimRes = stackTrace.ToString().Split('\n');
            var res = "";
            if (trimRes.Length > 0)
            {
                res = trimRes[0];
            }

            _repository.Insert(new SystemEventLog
            {
                CreateDateTime = DateTime.Now,
                FirstCallerInfo = res,
                Data = Newtonsoft.Json.JsonConvert.SerializeObject(data),
                Info = message,
                SystemCallId = _currentSystemCallInfo.Id,
                SystemEventLogType = logType
            });
        }
    }
}
