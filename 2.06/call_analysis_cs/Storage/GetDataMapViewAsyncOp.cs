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
	public GetDataMapViewAsyncOp(ContainerContext storage, GetAsyncCallback callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CalledBy(Type = typeof(ContainerContext), Member = "GetAsyncThunk")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void Complete(uint result, IntPtr map)
	{
	}
}
