using Cpp2ILInjected.CallAnalysis;

namespace Users;

public class PermissionDenyReasonListPlugin
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PermissionDenyReasonListPlugin()
	{
	}
}
