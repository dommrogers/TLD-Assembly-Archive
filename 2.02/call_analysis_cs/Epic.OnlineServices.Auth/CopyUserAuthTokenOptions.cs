using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

public class CopyUserAuthTokenOptions
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CopyUserAuthTokenOptions()
	{
	}
}
