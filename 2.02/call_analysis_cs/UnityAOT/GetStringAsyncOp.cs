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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetMyObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	protected static void GetStringAsyncThunkImpl(uint result, IntPtr lresult, IntPtr userData)
	{
	}
}
