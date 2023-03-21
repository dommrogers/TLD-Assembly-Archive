using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public class LobbyModificationSetPermissionLevelOptions
{
	private LobbyPermissionLevel _003CPermissionLevel_003Ek__BackingField;

	public LobbyPermissionLevel PermissionLevel
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public LobbyModificationSetPermissionLevelOptions()
	{
	}
}
