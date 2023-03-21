using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GearItemInteractabilityControlSpawnTransformSaveData
{
	public string m_GearItemGuid;

	public Vector3 m_LocalPosition;

	public Quaternion m_LocalRotation;

	public Vector3 m_LocalScale;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public GearItemInteractabilityControlSpawnTransformSaveData()
	{
	}
}
