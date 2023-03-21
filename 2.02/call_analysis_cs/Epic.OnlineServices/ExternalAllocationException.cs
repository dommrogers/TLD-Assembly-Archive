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
	[CalledBy(Type = typeof(Helper), Member = "TryAllocateCacheOnly")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt64")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(AllocationException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public ExternalAllocationException(IntPtr address, Type type)
		: base(null)
	{
	}
}
