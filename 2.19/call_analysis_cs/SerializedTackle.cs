using Cpp2ILInjected.CallAnalysis;
using UnityEngine.AddressableAssets;

public class SerializedTackle
{
	public AssetReference m_AssetReference;

	public GearItemSaveDataProxy m_GearItemData;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SerializedTackle()
	{
	}
}
