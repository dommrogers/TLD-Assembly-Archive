using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct LobbyDetailsGetMemberAttributeCountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_TargetUserId;

	public ProductUserId TargetUserId
	{
		[CalledBy(Type = typeof(LobbyDetailsGetMemberAttributeCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbyDetailsGetMemberAttributeCountOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyDetailsGetMemberAttributeCountOptionsInternal), Member = "set_TargetUserId")]
	public void Set(LobbyDetailsGetMemberAttributeCountOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LobbyDetailsGetMemberAttributeCountOptionsInternal), Member = "set_TargetUserId")]
	[CalledBy(Type = typeof(LobbyDetails), Member = "GetMemberAttributeCount")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
