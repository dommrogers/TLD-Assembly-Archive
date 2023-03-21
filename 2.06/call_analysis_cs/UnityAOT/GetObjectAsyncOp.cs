using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

public class GetObjectAsyncOp<T> : AsyncOp<GetObjectAsyncOp<T>> where T : IWrappedObject, new()
{
	public delegate void GetObjectAsyncCallback(T obj, GetObjectAsyncOp<T> op);

	public T ResultObject;

	public GetObjectAsyncCallback Callback;

	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public GetObjectAsyncOp(GetObjectAsyncCallback callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	public void Complete(uint result, IntPtr lresults)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GetObjectAsyncOp<T> Validate(bool ok)
	{
		return null;
	}
}
