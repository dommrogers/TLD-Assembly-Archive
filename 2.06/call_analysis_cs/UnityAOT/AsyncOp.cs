using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

[StructLayout(0)]
public class AsyncOp<T> : IDisposable where T : AsyncOp<T>
{
	public uint Result;

	public bool IsComplete;

	public bool Success;

	protected GCHandle m_Handle;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AsyncOp()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual void Dispose()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static IntPtr GetMyHandle(T obj)
	{
		return default(IntPtr);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[CallsUnknownMethods(Count = 14)]
	public static T GetMyObject(IntPtr handlePtr)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 30)]
	[CallsUnknownMethods(Count = 5)]
	public IntPtr GetHandle()
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void FreeHandle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected void TriggerOnComplete(uint result)
	{
	}
}
