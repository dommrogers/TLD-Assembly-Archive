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
		[CalledBy(Type = typeof(LobbyDetailsCopyMemberAttributeByIndexOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
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

	[CalledBy(Type = typeof(LobbyDetails), Member = "CopyMemberAttributeByIndex")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LobbyDetailsCopyMemberAttributeByIndexOptionsInternal), Member = "set_TargetUserId")]
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
