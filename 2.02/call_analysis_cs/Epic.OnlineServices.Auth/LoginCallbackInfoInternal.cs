using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

[StructLayout(0, Pack = 8, Size = 48)]
internal struct LoginCallbackInfoInternal : ICallbackInfoInternal
{
	private Result m_ResultCode;

	private IntPtr m_ClientData;

	private IntPtr m_LocalUserId;

	private IntPtr m_PinGrantInfo;

	private IntPtr m_ContinuanceToken;

	private IntPtr m_AccountFeatureRestrictedInfo;

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
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(LoginCallbackInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
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

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(LoginCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public PinGrantInfo PinGrantInfo
	{
		[CalledBy(Type = typeof(LoginCallbackInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public ContinuanceToken ContinuanceToken
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(LoginCallbackInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
	}

	public AccountFeatureRestrictedInfo AccountFeatureRestrictedInfo
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(LoginCallbackInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
	}
}
