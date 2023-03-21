using Cpp2ILInjected.CallAnalysis;

namespace Users;

public class PermissionCheckResultListPlugin
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PermissionCheckResultListPlugin()
	{
	}
}
