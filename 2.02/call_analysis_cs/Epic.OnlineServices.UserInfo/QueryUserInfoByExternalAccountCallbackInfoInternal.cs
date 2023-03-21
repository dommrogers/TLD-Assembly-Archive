using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UserInfo;

[StructLayout(0, Pack = 8, Size = 48)]
internal struct QueryUserInfoByExternalAccountCallbackInfoInternal : ICallbackInfoInternal
{
	private Result m_ResultCode;

	private IntPtr m_ClientData;

	private IntPtr m_LocalUserId;

	private IntPtr m_ExternalAccountId;

	private ExternalAccountType m_AccountType;

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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(QueryUserInfoByExternalAccountCallbackInfo), Member = "Set")]
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
		[CalledBy(Type = typeof(QueryUserInfoByExternalAccountCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public string ExternalAccountId
	{
		[CalledBy(Type = typeof(QueryUserInfoByExternalAccountCallbackInfo), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public ExternalAccountType AccountType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(ExternalAccountType);
		}
	}

	public EpicAccountId TargetUserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(QueryUserInfoByExternalAccountCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}
}
