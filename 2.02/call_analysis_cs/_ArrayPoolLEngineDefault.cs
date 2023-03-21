using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class _ArrayPoolLEngineDefault : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal _ArrayPoolLEngineDefault(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static IntPtr getCPtr(_ArrayPoolLEngineDefault obj)
	{
		return default(IntPtr);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~_ArrayPoolLEngineDefault()
	{
	}

	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Dispose()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int Get()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public _ArrayPoolLEngineDefault()
	{
	}
}
