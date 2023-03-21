using Cpp2ILInjected.CallAnalysis;

public class CarryableBodySaveData
{
	public bool m_HasBeenDropped;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public CarryableBodySaveData()
	{
	}
}
