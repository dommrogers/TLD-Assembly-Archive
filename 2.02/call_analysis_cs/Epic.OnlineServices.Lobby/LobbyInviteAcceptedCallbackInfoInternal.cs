using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct LobbyInviteAcceptedCallbackInfoInternal : ICallbackInfoInternal
{
	private IntPtr m_ClientData;

	private IntPtr m_InviteId;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	public object ClientData
	{
		[CalledBy(Type = typeof(LobbyInviteAcceptedCallbackInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
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
			return (IntPtr)0;
		}
	}

	public string InviteId
	{
		[CalledBy(Type = typeof(LobbyInviteAcceptedCallbackInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(LobbyInviteAcceptedCallbackInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public ProductUserId TargetUserId
	{
		[CalledBy(Type = typeof(LobbyInviteAcceptedCallbackInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}
}
