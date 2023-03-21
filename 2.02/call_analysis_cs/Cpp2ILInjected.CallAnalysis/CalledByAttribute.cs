using System;

namespace Cpp2ILInjected.CallAnalysis;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public sealed class CalledByAttribute : Attribute
{
	public Type Type;

	public string Member;
}
