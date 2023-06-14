using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalLogic.Exceptions;

public class IncorrectPasswordException : Exception
{
    public IncorrectPasswordException() : base("Password is incorrect.") { }
}
