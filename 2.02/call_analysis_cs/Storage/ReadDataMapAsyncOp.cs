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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ReadDataMapAsyncOp(ContainerContext storage, ReadAsyncCallback callback, DataMap data)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Complete(uint result)
	{
	}
}
