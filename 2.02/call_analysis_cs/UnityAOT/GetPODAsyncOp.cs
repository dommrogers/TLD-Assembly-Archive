using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

public class GetPODAsyncOp<T> : AsyncOp<GetPODAsyncOp<T>> where T : struct
{
	public delegate void GetPODAsyncCallback(T obj, GetPODAsyncOp<T> op);

	public T ResultObject;

	public GetPODAsyncCallback Callback;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GetPODAsyncOp(GetPODAsyncCallback callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Complete(uint result, T lresult)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GetPODAsyncOp<T> Validate(bool ok)
	{
		return null;
	}
}
