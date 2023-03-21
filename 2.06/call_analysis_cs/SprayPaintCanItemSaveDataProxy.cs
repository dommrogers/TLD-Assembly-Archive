using Cpp2ILInjected.CallAnalysis;

public class SprayPaintCanItemSaveDataProxy
{
	public DecalColour m_Colour;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public SprayPaintCanItemSaveDataProxy()
	{
	}
}
