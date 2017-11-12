using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    public interface IElectronicDevice
    {
        void Start();
        void Stop();
        bool IsStarted { get; }
    }
}
