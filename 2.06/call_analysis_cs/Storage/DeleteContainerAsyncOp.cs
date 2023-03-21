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

	[CalledBy(Type = typeof(ConnectedStorage), Member = "DeleteThisContainer")]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "DeleteContainer")]
	[CallerCount(Count = 2)]
	public DeleteContainerAsyncOp(ConnectedStorage storage, DeleteContainerAsyncCallback callback, string containerName)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Complete(uint status, uint result)
	{
	}
}
