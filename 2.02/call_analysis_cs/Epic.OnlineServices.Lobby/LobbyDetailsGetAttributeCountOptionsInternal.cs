using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 4)]
internal struct LobbyDetailsGetAttributeCountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(LobbyDetailsGetAttributeCountOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(LobbyDetails), Member = "GetAttributeCount")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
