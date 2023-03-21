using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

internal class TypeAllocationException : AllocationException
{
	[CalledBy(Type = typeof(Helper), Member = "TryFetch")]
	[CalledBy(Type = typeof(Helper), Member = "TryFetch")]
	[CalledBy(Type = typeof(Helper), Member = "TryFetch")]
	[Calls(Type = typeof(AllocationException), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt64")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	public TypeAllocationException(IntPtr address, Type foundType, Type expectedType)
		: base(null)
	{
	}
}
