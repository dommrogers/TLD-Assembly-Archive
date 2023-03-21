using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct LobbySearchFindOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(LobbySearchFindOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbySearchFindOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbySearchFindOptionsInternal), Member = "set_LocalUserId")]
	public void Set(LobbySearchFindOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LobbySearchFindOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(LobbySearch), Member = "Find")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
