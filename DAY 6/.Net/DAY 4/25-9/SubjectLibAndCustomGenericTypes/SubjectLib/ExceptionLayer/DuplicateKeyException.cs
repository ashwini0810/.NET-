using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectLib.ExceptionLayer
{
    public class DuplicateKeyException :ApplicationException
    {
        public DuplicateKeyException(string msg) : base(msg)
        {
            
        }
    }
}
