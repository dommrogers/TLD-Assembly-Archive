using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct LobbyDetailsCopyMemberAttributeByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_TargetUserId;

	private uint m_AttrIndex;

	public ProductUserId TargetUserId
	{
		[CalledBy(Type = typeof(LobbyDetailsCopyMemberAttributeByIndexOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(LobbyDetailsCopyMemberAttributeByIndexOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public uint AttrIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyDetailsCopyMemberAttributeByIndexOptionsInternal), Member = "set_TargetUserId")]
	public void Set(LobbyDetailsCopyMemberAttributeByIndexOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LobbyDetailsCopyMemberAttributeByIndexOptionsInternal), Member = "set_TargetUserId")]
	[CalledBy(Type = typeof(LobbyDetails), Member = "CopyMemberAttributeByIndex")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
