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

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ContainerContext), Member = "QueryBlobInfoAsync")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BlobInfoQueryAsyncOp(ContainerContext storage, BlobInfoQueryCallback callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(ContainerContext), Member = "BlobInfoQueryAsyncThunk")]
	public void Complete(uint result, uint totalResults, IntPtr queryHandle)
	{
	}
}
