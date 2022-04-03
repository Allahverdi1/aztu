using System;
using System.Runtime.Serialization;

namespace ConsoleApp6
{
    [Serializable]
    internal class AlreadyExsitsException : Exception
    {
       
        
        

        public AlreadyExsitsException(string message) : base(message)
        {
        }

        

      
    }
}