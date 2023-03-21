using System;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

internal class AllocationException : Exception
{
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CalledBy(Type = typeof(ExternalAllocationException), Member = ".ctor")]
	[CalledBy(Type = typeof(TypeAllocationException), Member = ".ctor")]
	[CalledBy(Type = typeof(ArrayAllocationException), Member = ".ctor")]
	public AllocationException(string message)
	{
	}
}
