using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Storage;

public class ReadDataMapAsyncOp : AsyncOp<ReadDataMapAsyncOp>
{
	public delegate void ReadAsyncCallback(ContainerContext storage, ReadDataMapAsyncOp op);

	public ContainerContext Context;

	public ReadAsyncCallback Callback;

	public DataMap Map;

	[CallerCount(Count = 0)]
	public ReadDataMapAsyncOp(ContainerContext storage, ReadAsyncCallback callback, DataMap data)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Complete(uint result)
	{
	}
}
