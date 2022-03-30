using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class GroupNameIsWrongException:Exception
    {
        public GroupNameIsWrongException(string message):base(message)
        {

        }
    }
}
