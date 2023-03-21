using Cpp2ILInjected.CallAnalysis;

public class FlyoverDataProxy
{
	public float m_SecondsSinceLastFlyover;

	public float m_SecondsBetweenFlyovers;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public FlyoverDataProxy()
	{
	}
}
