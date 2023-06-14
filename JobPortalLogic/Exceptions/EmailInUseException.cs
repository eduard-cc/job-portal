using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalLogic.Exceptions;

public class EmailInUseException : Exception
{
    public EmailInUseException() : base("This email is already in use.") { }
}