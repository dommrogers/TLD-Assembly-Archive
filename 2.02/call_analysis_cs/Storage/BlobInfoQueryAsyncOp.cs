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

	[CalledBy(Type = typeof(ContainerContext), Member = "QueryBlobInfoAsync")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BlobInfoQueryAsyncOp(ContainerContext storage, BlobInfoQueryCallback callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CalledBy(Type = typeof(ContainerContext), Member = "BlobInfoQueryAsyncThunk")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void Complete(uint result, uint totalResults, IntPtr queryHandle)
	{
	}
}
