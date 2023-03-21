using Cpp2ILInjected.CallAnalysis;

public class NoiseMakerSaveDataProxy
{
	public float m_ElapsedBurnMinutes;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public NoiseMakerSaveDataProxy()
	{
	}
}
