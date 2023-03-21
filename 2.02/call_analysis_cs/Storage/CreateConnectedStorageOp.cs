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

	[CalledBy(Type = typeof(ConnectedStorage), Member = "CreateAsync")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CreateConnectedStorageOp(ConnectedStorageInitializedCallback callback, int uid, string defaultContainerName)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "InitializedThunk")]
	[Calls(Type = typeof(ConnectedStorage), Member = "OpenOrCreateContainer")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ConnectedStorage), Member = ".ctor")]
	public void Complete(uint result, IntPtr self)
	{
	}
}
