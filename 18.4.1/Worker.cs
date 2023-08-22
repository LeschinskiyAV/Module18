using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._4._1
{
    public class Worker
    {
        Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public void Run()
        {
            _command.Run();
        }

        public void Cancel()
        {

        }
    }
}
