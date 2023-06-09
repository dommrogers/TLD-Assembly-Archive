using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Storage;

public class ContainerInfoQueryAsyncOp : AsyncOp<ContainerInfoQueryAsyncOp>
{
	public delegate void ContainerInfoQueryCallback(ConnectedStorage storage, ContainerInfoQueryAsyncOp op);

	public uint TotalResults;

	public ContainerInfoQuery Query;

	public ConnectedStorage Storage;

	public ContainerInfoQueryCallback Callback;

	[CallerCount(Count = 0)]
	public ContainerInfoQueryAsyncOp(ConnectedStorage storage, ContainerInfoQueryCallback callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CalledBy(Type = typeof(ConnectedStorage), Member = "ContainerInfoQueryAsyncThunk")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void Complete(uint result, uint totalResults, IntPtr queryHandle)
	{
	}
}
