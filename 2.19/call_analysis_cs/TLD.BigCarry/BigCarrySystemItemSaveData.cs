using Cpp2ILInjected.CallAnalysis;
using UnityEngine.AddressableAssets;

namespace TLD.BigCarry;

public class BigCarrySystemItemSaveData
{
	public string m_Guid;

	public AssetReference m_AssetReference;

	public BigCarryItemSaveData m_ItemSaveData;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public BigCarrySystemItemSaveData()
	{
	}
}
