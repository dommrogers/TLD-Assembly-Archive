using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public class LobbyDetailsGetMemberCountOptions
{
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public LobbyDetailsGetMemberCountOptions()
	{
	}
}
