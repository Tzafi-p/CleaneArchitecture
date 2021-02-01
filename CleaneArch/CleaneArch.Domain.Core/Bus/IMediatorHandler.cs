using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CleaneArch.Domain.Core.Commands;

namespace CleaneArch.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}
