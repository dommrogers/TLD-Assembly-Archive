using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

internal class ArrayAllocationException : AllocationException
{
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(AllocationException), Member = ".ctor")]
	[CalledBy(Type = typeof(Helper), Member = "TryFetch")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt64")]
	public ArrayAllocationException(IntPtr address, int foundLength, int expectedLength)
		: base(null)
	{
	}
}
