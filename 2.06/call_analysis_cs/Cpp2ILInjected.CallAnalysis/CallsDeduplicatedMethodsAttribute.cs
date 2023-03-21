using System;

namespace Cpp2ILInjected.CallAnalysis;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public sealed class CallsDeduplicatedMethodsAttribute : Attribute
{
	public int Count;
}
