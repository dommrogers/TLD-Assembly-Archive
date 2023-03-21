using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct LobbyMemberStatusReceivedCallbackInfoInternal : ICallbackInfoInternal
{
	private IntPtr m_ClientData;

	private IntPtr m_LobbyId;

	private IntPtr m_TargetUserId;

	private LobbyMemberStatus m_CurrentStatus;

	public object ClientData
	{
		[CalledBy(Type = typeof(LobbyMemberStatusReceivedCallbackInfo), Member = "Set")]
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

	public string LobbyId
	{
		[CalledBy(Type = typeof(LobbyMemberStatusReceivedCallbackInfo), Member = "Set")]
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
		[CalledBy(Type = typeof(LobbyMemberStatusReceivedCallbackInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public LobbyMemberStatus CurrentStatus
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(LobbyMemberStatus);
		}
	}
}
