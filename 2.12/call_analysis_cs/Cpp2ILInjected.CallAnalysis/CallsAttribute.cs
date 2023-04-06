using System;

namespace Cpp2ILInjected.CallAnalysis;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public sealed class CallsAttribute : Attribute
{
	public Type Type;

	public string TypeFullName;

	public string Member;
}
