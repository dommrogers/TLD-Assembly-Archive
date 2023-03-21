using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Storage;

public class DeleteContainerAsyncOp : AsyncOp<DeleteContainerAsyncOp>
{
	public delegate void DeleteContainerAsyncCallback(ConnectedStorage storage, DeleteContainerAsyncOp op);

	public ConnectedStorageStatus Status;

	public ConnectedStorage Storage;

	public DeleteContainerAsyncCallback Callback;

	public string ContainerName;

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "DeleteThisContainer")]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "DeleteContainer")]
	public DeleteContainerAsyncOp(ConnectedStorage storage, DeleteContainerAsyncCallback callback, string containerName)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Complete(uint status, uint result)
	{
	}
}
