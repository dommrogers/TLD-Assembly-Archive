using Cpp2ILInjected.CallAnalysis;

namespace AK;

public class AUDIO_DEVICES
{
	public static uint NO_OUTPUT;

	public static uint SYSTEM;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AUDIO_DEVICES()
	{
	}
}
