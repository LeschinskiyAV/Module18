using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._4._1
{
    public abstract class Command
    {
        public abstract void Run();
        public abstract void Cancel();
    }
}
