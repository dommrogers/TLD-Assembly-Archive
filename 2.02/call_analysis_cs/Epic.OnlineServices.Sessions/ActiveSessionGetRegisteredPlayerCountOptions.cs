using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class ActiveSessionGetRegisteredPlayerCountOptions
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ActiveSessionGetRegisteredPlayerCountOptions()
	{
	}
}
