using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.AddressableAssets;

namespace TLD.Gameplay;

[Serializable]
public class RandomTableDataEntry<T> where T : AssetReferenceGameObject
{
	public T m_Item;

	public int m_Weight;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public RandomTableDataEntry()
	{
	}
}
