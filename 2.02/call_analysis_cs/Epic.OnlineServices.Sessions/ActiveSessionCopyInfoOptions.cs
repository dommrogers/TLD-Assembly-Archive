using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class ActiveSessionCopyInfoOptions
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ActiveSessionCopyInfoOptions()
	{
	}
}
