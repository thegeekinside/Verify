﻿#if !NETSTANDARD2_0
using System.Linq.Expressions;
using VerifyTests;

namespace VerifyExpecto
{
    public static partial class Verifier
    {
        public static Task VerifyTuple(
            string name,
            Expression<Func<ITuple>> expression,
            VerifySettings? settings = null,
            [CallerFilePath] string sourceFile = "")
        {
            var assembly = Assembly.GetCallingAssembly()!;
            return Verify(settings, assembly, sourceFile, name, _ => _.VerifyTuple(expression));
        }
    }
}
#endif