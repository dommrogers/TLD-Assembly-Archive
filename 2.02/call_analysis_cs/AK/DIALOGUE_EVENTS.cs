using Cpp2ILInjected.CallAnalysis;

namespace AK;

public class DIALOGUE_EVENTS
{
	public static uint TESTDD;

	public static uint TESTDDSWITCHES;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public DIALOGUE_EVENTS()
	{
	}
}
