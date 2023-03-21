using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public class LobbyDetailsInfo : ISettable
{
	private string _003CLobbyId_003Ek__BackingField;

	private ProductUserId _003CLobbyOwnerUserId_003Ek__BackingField;

	private LobbyPermissionLevel _003CPermissionLevel_003Ek__BackingField;

	private uint _003CAvailableSlots_003Ek__BackingField;

	private uint _003CMaxMembers_003Ek__BackingField;

	private bool _003CAllowInvites_003Ek__BackingField;

	public string LobbyId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		set
		{
		}
	}

	public ProductUserId LobbyOwnerUserId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	public LobbyPermissionLevel PermissionLevel
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(LobbyPermissionLevel);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public uint AvailableSlots
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(uint);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	public uint MaxMembers
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(uint);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool AllowInvites
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(LobbyDetailsInfo), Member = "Set")]
	[Calls(Type = typeof(LobbyDetailsInfoInternal), Member = "get_AllowInvites")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LobbyDetailsInfoInternal), Member = "get_LobbyId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LobbyDetailsInfoInternal), Member = "get_LobbyOwnerUserId")]
	internal void Set(LobbyDetailsInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LobbyDetailsInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public LobbyDetailsInfo()
	{
	}
}
