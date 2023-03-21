using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

public class GetStringAsyncOp : AsyncOp<GetStringAsyncOp>
{
	public delegate void GetStringAsyncCallback(string obj, GetStringAsyncOp op);

	public string ResultObject;

	public GetStringAsyncCallback Callback;

	public static GenericStringCallback GetStringAsyncThunk;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public GetStringAsyncOp(GetStringAsyncCallback callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Complete(uint result, string lresult)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public GetStringAsyncOp Validate(bool ok)
	{
		return null;
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	protected static void GetStringAsyncThunkImpl(uint result, IntPtr lresult, IntPtr userData)
	{
	}
}
