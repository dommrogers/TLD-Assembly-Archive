using Cpp2ILInjected.CallAnalysis;

public class WaterSupplySaveDataProxy
{
	public float m_VolumeProxy;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public WaterSupplySaveDataProxy()
	{
	}
}
