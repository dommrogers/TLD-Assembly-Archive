using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

internal class ExternalAllocationException : AllocationException
{
	[CalledBy(Type = typeof(Helper), Member = "TryAllocate")]
	[CalledBy(Type = typeof(Helper), Member = "TryAllocate")]
	[CalledBy(Type = typeof(Helper), Member = "TryAllocate")]
	[CalledBy(Type = typeof(Helper), Member = "TryAllocate")]
	[Calls(Type = typeof(AllocationException), Member = ".ctor")]
	[CalledBy(Type = typeof(Helper), Member = "TryAllocateCacheOnly")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt64")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	public ExternalAllocationException(IntPtr address, Type type)
		: base(null)
	{
	}
}
