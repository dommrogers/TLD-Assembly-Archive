using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct LobbyDetailsCopyMemberAttributeByKeyOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_TargetUserId;

	private IntPtr m_AttrKey;

	public ProductUserId TargetUserId
	{
		[CalledBy(Type = typeof(LobbyDetailsCopyMemberAttributeByKeyOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(LobbyDetailsCopyMemberAttributeByKeyOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string AttrKey
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(LobbyDetailsCopyMemberAttributeByKeyOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbyDetailsCopyMemberAttributeByKeyOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyDetailsCopyMemberAttributeByKeyOptionsInternal), Member = "set_TargetUserId")]
	[Calls(Type = typeof(LobbyDetailsCopyMemberAttributeByKeyOptionsInternal), Member = "set_AttrKey")]
	public void Set(LobbyDetailsCopyMemberAttributeByKeyOptions other)
	{
	}

	[CalledBy(Type = typeof(LobbyDetails), Member = "CopyMemberAttributeByKey")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LobbyDetailsCopyMemberAttributeByKeyOptionsInternal), Member = "set_TargetUserId")]
	[Calls(Type = typeof(LobbyDetailsCopyMemberAttributeByKeyOptionsInternal), Member = "set_AttrKey")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
