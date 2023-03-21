using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct LobbyUpdateReceivedCallbackInfoInternal : ICallbackInfoInternal
{
	private IntPtr m_ClientData;

	private IntPtr m_LobbyId;

	public object ClientData
	{
		[CalledBy(Type = typeof(LobbyUpdateReceivedCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(LobbyUpdateReceivedCallbackInfo), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
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

	public string LobbyId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(LobbyUpdateReceivedCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(LobbyUpdateReceivedCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}
}
