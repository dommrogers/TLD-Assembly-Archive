using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

public class GetStringAsyncOp : AsyncOp<GetStringAsyncOp>
{
	public delegate void GetStringAsyncCallback(string obj, GetStringAsyncOp op);

	public string ResultObject;

	public GetStringAsyncCallback Callback;

	public static GenericStringCallback GetStringAsyncThunk;

	[CallerCount(Count = 0)]
	public GetStringAsyncOp(GetStringAsyncCallback callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Complete(uint result, string lresult)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public GetStringAsyncOp Validate(bool ok)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[MonoPInvokeCallback(typeof(GenericStringCallback))]
	protected static void GetStringAsyncThunkImpl(uint result, IntPtr lresult, IntPtr userData)
	{
	}
}
