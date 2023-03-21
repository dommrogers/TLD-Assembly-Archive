using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct SessionInviteReceivedCallbackInfoInternal : ICallbackInfoInternal
{
	private IntPtr m_ClientData;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	private IntPtr m_InviteId;

	public object ClientData
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(SessionInviteReceivedCallbackInfo), Member = "Set")]
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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(SessionInviteReceivedCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public ProductUserId TargetUserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(SessionInviteReceivedCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public string InviteId
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(SessionInviteReceivedCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}
}
