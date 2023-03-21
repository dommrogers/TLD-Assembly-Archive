using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Storage;

public class SubmitDataMapUpdatesAsyncOp : AsyncOp<SubmitDataMapUpdatesAsyncOp>
{
	public delegate void UpdateAsyncCallback(ContainerContext storage, SubmitDataMapUpdatesAsyncOp op);

	public ConnectedStorageStatus Status;

	public ContainerContext Context;

	public UpdateAsyncCallback Callback;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SubmitDataMapUpdatesAsyncOp(ContainerContext storage, UpdateAsyncCallback callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Complete(uint status, uint result)
	{
	}
}
