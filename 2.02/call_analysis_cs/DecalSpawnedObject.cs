using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class DecalSpawnedObject
{
	public DecalProjectorType m_DecalProjectorType;

	public ProjectileType m_ProjectileType;

	public GameObject m_SpawnedPrefab;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public DecalSpawnedObject()
	{
	}
}
