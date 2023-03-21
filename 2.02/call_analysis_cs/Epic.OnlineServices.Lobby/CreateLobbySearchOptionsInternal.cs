using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct CreateLobbySearchOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private uint m_MaxResults;

	public uint MaxResults
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(CreateLobbySearchOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(LobbyInterface), Member = "CreateLobbySearch")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
