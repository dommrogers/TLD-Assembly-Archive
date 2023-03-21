using Cpp2ILInjected.CallAnalysis;

public class NoiseMakerSaveDataProxy
{
	public float m_ElapsedBurnMinutes;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public NoiseMakerSaveDataProxy()
	{
	}
}
