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
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	public ProductUserId LobbyOwnerUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return 0u;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public uint MaxMembers
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return 0u;
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
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(LobbyDetailsInfo), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LobbyDetailsInfoInternal), Member = "get_LobbyId")]
	[Calls(Type = typeof(LobbyDetailsInfoInternal), Member = "get_LobbyOwnerUserId")]
	[Calls(Type = typeof(LobbyDetailsInfoInternal), Member = "get_AllowInvites")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal void Set(LobbyDetailsInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyDetailsInfo), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public LobbyDetailsInfo()
	{
	}
}
