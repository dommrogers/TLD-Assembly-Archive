using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct LoginStatusChangedCallbackInfoInternal : ICallbackInfoInternal
{
	private IntPtr m_ClientData;

	private IntPtr m_LocalUserId;

	private LoginStatus m_PreviousStatus;

	private LoginStatus m_CurrentStatus;

	public object ClientData
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(LoginStatusChangedCallbackInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CalledBy(Type = typeof(LoginStatusChangedCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public LoginStatus PreviousStatus
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
