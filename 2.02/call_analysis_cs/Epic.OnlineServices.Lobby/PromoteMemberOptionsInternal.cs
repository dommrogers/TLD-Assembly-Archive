using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct PromoteMemberOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LobbyId;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	public string LobbyId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(PromoteMemberOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(PromoteMemberOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(PromoteMemberOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(PromoteMemberOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public ProductUserId TargetUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(PromoteMemberOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(PromoteMemberOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PromoteMemberOptionsInternal), Member = "set_LobbyId")]
	[Calls(Type = typeof(PromoteMemberOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(PromoteMemberOptionsInternal), Member = "set_TargetUserId")]
	public void Set(PromoteMemberOptions other)
	{
	}

	[CalledBy(Type = typeof(LobbyInterface), Member = "PromoteMember")]
	[Calls(Type = typeof(PromoteMemberOptionsInternal), Member = "set_TargetUserId")]
	[Calls(Type = typeof(PromoteMemberOptionsInternal), Member = "set_LocalUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PromoteMemberOptionsInternal), Member = "set_LobbyId")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
