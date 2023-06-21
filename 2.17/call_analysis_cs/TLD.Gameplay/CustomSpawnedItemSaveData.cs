using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Gameplay;

public class CustomSpawnedItemSaveData
{
	public string m_Guid;

	public AssetReference m_Address;

	public Vector3 m_Position;

	public Quaternion m_Rotation;

	public List<CustomSpawnedItemChildSaveData> m_Children;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public CustomSpawnedItemSaveData()
	{
	}
}
