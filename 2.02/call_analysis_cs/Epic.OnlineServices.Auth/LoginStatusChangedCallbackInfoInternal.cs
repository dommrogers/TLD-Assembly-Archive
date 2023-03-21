using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct LoginStatusChangedCallbackInfoInternal : ICallbackInfoInternal
{
	private IntPtr m_ClientData;

	private IntPtr m_LocalUserId;

	private LoginStatus m_PrevStatus;

	private LoginStatus m_CurrentStatus;

	public object ClientData
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(LoginStatusChangedCallbackInfo), Member = "Set")]
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

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(LoginStatusChangedCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public LoginStatus PrevStatus
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(LoginStatus);
		}
	}

	public LoginStatus CurrentStatus
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return default(LoginStatus);
		}
	}
}
