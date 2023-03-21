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
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(LobbyDetailsInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(LobbyDetailsInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbyDetailsInfoInternal), Member = "Set")]
		set
		{
		}
	}

	public ProductUserId LobbyOwnerUserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(LobbyDetailsInfo), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(LobbyDetailsInfoInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(LobbyDetailsInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
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
			return default(uint);
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
			return default(uint);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public bool AllowInvites
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(LobbyDetailsInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(LobbyDetailsInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbyDetailsInfoInternal), Member = "Set")]
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

	[Calls(Type = typeof(LobbyDetailsInfoInternal), Member = "set_LobbyOwnerUserId")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LobbyDetailsInfoInternal), Member = "set_LobbyId")]
	[Calls(Type = typeof(LobbyDetailsInfoInternal), Member = "set_AllowInvites")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
