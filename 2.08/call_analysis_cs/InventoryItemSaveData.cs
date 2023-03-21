using Cpp2ILInjected.CallAnalysis;

public class InventoryItemSaveData
{
	public string m_PrefabName;

	public string m_SerializedGear;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public InventoryItemSaveData()
	{
	}
}
