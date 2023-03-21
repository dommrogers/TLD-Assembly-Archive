using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Storage;

public class CreateConnectedStorageOp : AsyncOp<CreateConnectedStorageOp>
{
	public delegate void ConnectedStorageInitializedCallback(ConnectedStorage storage, CreateConnectedStorageOp op);

	private int userId;

	public ConnectedStorage Storage;

	public ConnectedStorageInitializedCallback Callback;

	public string DefaultContainerName;

	[CallerCount(Count = 0)]
	public CreateConnectedStorageOp(ConnectedStorageInitializedCallback callback, int uid, string defaultContainerName)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CalledBy(Type = typeof(ConnectedStorage), Member = "InitializedThunk")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConnectedStorage), Member = ".ctor")]
	[Calls(Type = typeof(ConnectedStorage), Member = "OpenOrCreateContainer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void Complete(uint result, IntPtr self)
	{
	}
}
