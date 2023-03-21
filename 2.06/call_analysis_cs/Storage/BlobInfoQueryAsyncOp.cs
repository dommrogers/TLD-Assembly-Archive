using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Storage;

public class BlobInfoQueryAsyncOp : AsyncOp<BlobInfoQueryAsyncOp>
{
	public delegate void BlobInfoQueryCallback(ContainerContext storage, BlobInfoQueryAsyncOp op);

	public uint TotalResults;

	public BlobInfoQuery Query;

	public ContainerContext Context;

	public BlobInfoQueryCallback Callback;

	[CallerCount(Count = 0)]
	public BlobInfoQueryAsyncOp(ContainerContext storage, BlobInfoQueryCallback callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ContainerContext), Member = "BlobInfoQueryAsyncThunk")]
	public void Complete(uint result, uint totalResults, IntPtr queryHandle)
	{
	}
}
