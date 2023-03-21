using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

public class GetObjectAsyncOp<T> : AsyncOp<GetObjectAsyncOp<T>> where T : IWrappedObject, new()
{
	public delegate void GetObjectAsyncCallback(T obj, GetObjectAsyncOp<T> op);

	public T ResultObject;

	public GetObjectAsyncCallback Callback;

	[DeduplicatedMethod]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GetObjectAsyncOp(GetObjectAsyncCallback callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void Complete(uint result, IntPtr lresults)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GetObjectAsyncOp<T> Validate(bool ok)
	{
		return null;
	}
}
