using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct KickMemberOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LobbyId;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	public string LobbyId
	{
		[CalledBy(Type = typeof(KickMemberOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(KickMemberOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(KickMemberOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(KickMemberOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ProductUserId TargetUserId
	{
		[CalledBy(Type = typeof(KickMemberOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(KickMemberOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KickMemberOptionsInternal), Member = "set_LobbyId")]
	[Calls(Type = typeof(KickMemberOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(KickMemberOptionsInternal), Member = "set_TargetUserId")]
	public void Set(KickMemberOptions other)
	{
	}

	[CalledBy(Type = typeof(LobbyInterface), Member = "KickMember")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(KickMemberOptionsInternal), Member = "set_LobbyId")]
	[Calls(Type = typeof(KickMemberOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(KickMemberOptionsInternal), Member = "set_TargetUserId")]
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
