using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalLogic.Exceptions;

public class IncorrectCredentialsException : Exception
{
    public IncorrectCredentialsException() : base("Account type, email or password is incorrect.") { }
}
