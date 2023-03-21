using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct LobbySearchCopySearchResultByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private uint m_LobbyIndex;

	public uint LobbyIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(LobbySearchCopySearchResultByIndexOptions other)
	{
	}

	[CalledBy(Type = typeof(LobbySearch), Member = "CopySearchResultByIndex")]
	[CallerCount(Count = 1)]
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
