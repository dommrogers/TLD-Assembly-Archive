using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct JoinLobbyAcceptedCallbackInfoInternal : ICallbackInfoInternal
{
	private IntPtr m_ClientData;

	private IntPtr m_LocalUserId;

	private ulong m_UiEventId;

	public object ClientData
	{
		[CalledBy(Type = typeof(JoinLobbyAcceptedCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(JoinLobbyAcceptedCallbackInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
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

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(JoinLobbyAcceptedCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(JoinLobbyAcceptedCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public ulong UiEventId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return default(ulong);
		}
	}
}
