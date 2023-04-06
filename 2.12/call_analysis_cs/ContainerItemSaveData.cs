using Cpp2ILInjected.CallAnalysis;

public class ContainerItemSaveData
{
	public string m_PrefabName;

	public string m_SerializedGear;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ContainerItemSaveData()
	{
	}
}
