using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Stats;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct IngestStatCompleteCallbackInfoInternal : ICallbackInfoInternal
{
	private Result m_ResultCode;

	private IntPtr m_ClientData;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	public Result ResultCode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Result);
		}
	}

	public object ClientData
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(IngestStatCompleteCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public IntPtr ClientDataAddress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(IntPtr);
		}
	}

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(IngestStatCompleteCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public ProductUserId TargetUserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(IngestStatCompleteCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}
}
