using Cpp2ILInjected.CallAnalysis;

public class WaterSupplySaveDataProxy
{
	public float m_VolumeProxy;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public WaterSupplySaveDataProxy()
	{
	}
}
