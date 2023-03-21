using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 40)]
internal struct LobbyDetailsInfoInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LobbyId;

	private IntPtr m_LobbyOwnerUserId;

	private LobbyPermissionLevel m_PermissionLevel;

	private uint m_AvailableSlots;

	private uint m_MaxMembers;

	private int m_AllowInvites;

	public string LobbyId
	{
		[CalledBy(Type = typeof(LobbyDetailsInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(LobbyDetailsInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbyDetailsInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ProductUserId LobbyOwnerUserId
	{
		[CalledBy(Type = typeof(LobbyDetailsInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(LobbyDetailsInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbyDetailsInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public LobbyPermissionLevel PermissionLevel
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(LobbyPermissionLevel);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public uint AvailableSlots
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0u;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public uint MaxMembers
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return 0u;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool AllowInvites
	{
		[CalledBy(Type = typeof(LobbyDetailsInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return false;
		}
		[CalledBy(Type = typeof(LobbyDetailsInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbyDetailsInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyDetailsInfoInternal), Member = "set_LobbyId")]
	[Calls(Type = typeof(LobbyDetailsInfoInternal), Member = "set_LobbyOwnerUserId")]
	[Calls(Type = typeof(LobbyDetailsInfoInternal), Member = "set_AllowInvites")]
	public void Set(LobbyDetailsInfo other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyDetailsInfoInternal), Member = "set_LobbyId")]
	[Calls(Type = typeof(LobbyDetailsInfoInternal), Member = "set_LobbyOwnerUserId")]
	[Calls(Type = typeof(LobbyDetailsInfoInternal), Member = "set_AllowInvites")]
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
