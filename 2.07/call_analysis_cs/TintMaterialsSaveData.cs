using Cpp2ILInjected.CallAnalysis;

public class TintMaterialsSaveData
{
	public int m_TintIndex;

	public string m_Guid;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public TintMaterialsSaveData()
	{
	}
}
