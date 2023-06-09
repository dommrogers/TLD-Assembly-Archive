using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct LobbyModificationSetMaxMembersOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private uint m_MaxMembers;

	public uint MaxMembers
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(LobbyModificationSetMaxMembersOptions other)
	{
	}

	[CalledBy(Type = typeof(LobbyModification), Member = "SetMaxMembers")]
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
