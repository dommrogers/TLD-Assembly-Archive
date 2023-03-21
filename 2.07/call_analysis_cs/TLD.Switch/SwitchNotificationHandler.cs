using Cpp2ILInjected.CallAnalysis;

namespace TLD.Switch;

public static class SwitchNotificationHandler
{
	public static bool IsDocked
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public static bool IsBoosted
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}
}
