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
	[CallsUnknownMethods(Count = 1)]
	public AsyncOp()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Dispose()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static IntPtr GetMyHandle(T obj)
	{
		return default(IntPtr);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[CallsUnknownMethods(Count = 7)]
	public static T GetMyObject(IntPtr handlePtr)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 30)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public IntPtr GetHandle()
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public void FreeHandle()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected void TriggerOnComplete(uint result)
	{
	}
}
