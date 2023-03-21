using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

internal class TypeAllocationException : AllocationException
{
	[CalledBy(Type = typeof(Helper), Member = "TryFetch")]
	[CalledBy(Type = typeof(Helper), Member = "TryFetch")]
	[CalledBy(Type = typeof(Helper), Member = "TryFetch")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt64")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(AllocationException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public TypeAllocationException(IntPtr address, Type foundType, Type expectedType)
		: base(null)
	{
	}
}
