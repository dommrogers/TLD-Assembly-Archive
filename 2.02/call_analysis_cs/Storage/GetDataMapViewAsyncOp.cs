using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Storage;

public class GetDataMapViewAsyncOp : AsyncOp<GetDataMapViewAsyncOp>
{
	public delegate void GetAsyncCallback(ContainerContext storage, GetDataMapViewAsyncOp op, DataMapView view);

	public DataMapView Data;

	public ContainerContext Context;

	public GetAsyncCallback Callback;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GetDataMapViewAsyncOp(ContainerContext storage, GetAsyncCallback callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CalledBy(Type = typeof(ContainerContext), Member = "GetAsyncThunk")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Complete(uint result, IntPtr map)
	{
	}
}
