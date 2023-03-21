using Cpp2ILInjected.CallAnalysis;

public class GearSaveData
{
	public string m_PrefabName;

	public string m_SearializedGear;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public GearSaveData()
	{
	}
}
