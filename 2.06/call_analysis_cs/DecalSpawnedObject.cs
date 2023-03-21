using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class DecalSpawnedObject
{
	public DecalProjectorType m_DecalProjectorType;

	public ProjectileType m_ProjectileType;

	public GameObject m_SpawnedPrefab;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public DecalSpawnedObject()
	{
	}
}
