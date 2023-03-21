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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "QueryContainerInfoAsync")]
	[CallsUnknownMethods(Count = 1)]
	public ContainerInfoQueryAsyncOp(ConnectedStorage storage, ContainerInfoQueryCallback callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "ContainerInfoQueryAsyncThunk")]
	[CallsUnknownMethods(Count = 7)]
	public void Complete(uint result, uint totalResults, IntPtr queryHandle)
	{
	}
}
