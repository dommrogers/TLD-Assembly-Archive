using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct UpdateLobbyOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LobbyModificationHandle;

	public LobbyModification LobbyModificationHandle
	{
		[CalledBy(Type = typeof(UpdateLobbyOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(UpdateLobbyOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UpdateLobbyOptionsInternal), Member = "set_LobbyModificationHandle")]
	public void Set(UpdateLobbyOptions other)
	{
	}

	[CalledBy(Type = typeof(LobbyInterface), Member = "UpdateLobby")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UpdateLobbyOptionsInternal), Member = "set_LobbyModificationHandle")]
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
