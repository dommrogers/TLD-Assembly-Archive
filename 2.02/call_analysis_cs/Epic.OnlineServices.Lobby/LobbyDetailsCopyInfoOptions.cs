using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public class LobbyDetailsCopyInfoOptions
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LobbyDetailsCopyInfoOptions()
	{
	}
}
