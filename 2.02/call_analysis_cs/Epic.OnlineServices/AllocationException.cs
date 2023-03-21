using System;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

internal class AllocationException : Exception
{
	[CalledBy(Type = typeof(ExternalAllocationException), Member = ".ctor")]
	[CalledBy(Type = typeof(TypeAllocationException), Member = ".ctor")]
	[CalledBy(Type = typeof(ArrayAllocationException), Member = ".ctor")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public AllocationException(string message)
	{
	}
}
