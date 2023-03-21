using Cpp2ILInjected.CallAnalysis;

public class InventoryItemSaveData
{
	public string m_PrefabName;

	public string m_SerializedGear;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public InventoryItemSaveData()
	{
	}
}
