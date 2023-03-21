using Cpp2ILInjected.CallAnalysis;

public class SprayPaintCanItemSaveDataProxy
{
	public DecalColour m_Colour;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public SprayPaintCanItemSaveDataProxy()
	{
	}
}
