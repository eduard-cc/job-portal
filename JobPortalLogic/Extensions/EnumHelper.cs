using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalLogic.Extensions;

public static class EnumHelper
{
    /// <summary>
    ///     A generic extension method that retrieves any attribute that is applied to an `Enum`.
    /// </summary>
    public static TAttribute GetAttribute<TAttribute>(this Enum enumValue)
            where TAttribute : Attribute
    {
#pragma warning disable CS8603 // Possible null reference return.
        return enumValue.GetType()
                        .GetMember(enumValue.ToString())
                        .First()
                        .GetCustomAttribute<TAttribute>();
#pragma warning restore CS8603 // Possible null reference return.
    }
}
