using Cpp2ILInjected.CallAnalysis;

public class LiquidItemSaveDataProxy
{
	public float m_LiquidLitersProxy;

	public LiquidQuality m_LiquidQuality;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public LiquidItemSaveDataProxy()
	{
	}
}
