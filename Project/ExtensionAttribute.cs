using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#pragma warning disable 1685
namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method |
    AttributeTargets.Class | AttributeTargets.Assembly)]
    public sealed class ExtensionAttribute : Attribute
    {
    }
}
