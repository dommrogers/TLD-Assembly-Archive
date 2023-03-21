using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct LobbyModificationRemoveMemberAttributeOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Key;

	public string Key
	{
		[CalledBy(Type = typeof(LobbyModificationRemoveMemberAttributeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbyModificationRemoveMemberAttributeOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyModificationRemoveMemberAttributeOptionsInternal), Member = "set_Key")]
	public void Set(LobbyModificationRemoveMemberAttributeOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LobbyModificationRemoveMemberAttributeOptionsInternal), Member = "set_Key")]
	[CalledBy(Type = typeof(LobbyModification), Member = "RemoveMemberAttribute")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
