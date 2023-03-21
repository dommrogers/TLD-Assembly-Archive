using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Stats;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct OnQueryStatsCompleteCallbackInfoInternal : ICallbackInfoInternal
{
	private Result m_ResultCode;

	private IntPtr m_ClientData;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	public Result ResultCode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Result);
		}
	}

	public object ClientData
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(OnQueryStatsCompleteCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public IntPtr ClientDataAddress
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(IntPtr);
		}
	}

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(OnQueryStatsCompleteCallbackInfo), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
	}

	public ProductUserId TargetUserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(OnQueryStatsCompleteCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}
}
