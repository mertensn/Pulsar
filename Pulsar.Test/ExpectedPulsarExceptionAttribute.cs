using System;
using NUnit.Framework;

namespace Pulsar.Test
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ExpectedPulsarExceptionAttribute : ExpectedExceptionAttribute
    {
        public ExpectedPulsarExceptionAttribute(string errorCode)
        {
            MatchType = MessageMatch.StartsWith;
            ExpectedMessage = errorCode + ":";
        }
    }
}
