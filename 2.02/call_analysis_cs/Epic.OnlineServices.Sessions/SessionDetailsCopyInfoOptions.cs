using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class SessionDetailsCopyInfoOptions
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SessionDetailsCopyInfoOptions()
	{
	}
}
