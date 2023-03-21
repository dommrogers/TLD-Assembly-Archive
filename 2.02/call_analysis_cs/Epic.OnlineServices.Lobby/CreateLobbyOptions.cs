using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public class CreateLobbyOptions
{
	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private uint _003CMaxLobbyMembers_003Ek__BackingField;

	private LobbyPermissionLevel _003CPermissionLevel_003Ek__BackingField;

	private bool _003CPresenceEnabled_003Ek__BackingField;

	public ProductUserId LocalUserId
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

	public uint MaxLobbyMembers
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		[CompilerGenerated]
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

	public LobbyPermissionLevel PermissionLevel
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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

	public bool PresenceEnabled
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CreateLobbyOptions()
	{
	}
}
