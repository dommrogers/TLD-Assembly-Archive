using Cpp2ILInjected.CallAnalysis;

public class GearSaveData
{
	public string m_PrefabName;

	public string m_SearializedGear;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public GearSaveData()
	{
	}
}
