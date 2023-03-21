using Cpp2ILInjected.CallAnalysis;

public class RopeAnchorPointSaveData
{
	public bool m_RopeDeployed;

	public bool m_RopeSnapped;

	public string m_Guid;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public RopeAnchorPointSaveData()
	{
	}
}
