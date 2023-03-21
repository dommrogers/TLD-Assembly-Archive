using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct LeaveLobbyOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_LobbyId;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(LeaveLobbyOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LeaveLobbyOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string LobbyId
	{
		[CalledBy(Type = typeof(LeaveLobbyOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LeaveLobbyOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeaveLobbyOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(LeaveLobbyOptionsInternal), Member = "set_LobbyId")]
	public void Set(LeaveLobbyOptions other)
	{
	}

	[CalledBy(Type = typeof(LobbyInterface), Member = "LeaveLobby")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LeaveLobbyOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(LeaveLobbyOptionsInternal), Member = "set_LobbyId")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Dispose()
	{
	}
}
