using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public struct MapDetailUnlockParameters
{
	public Vector3 m_Position;

	public float m_Radius;

	public bool m_RequiresLineOfSight;

	public bool m_IgnoreHeight;

	public bool m_IgnoreLogged;

	public float m_RangeBoostMinHeight;

	public float m_RangeBoostMaxHeight;

	public float m_RangeBoostAmount;

	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "UnlockDecalMapMarkersNearPosition")]
	public float GetRangeBoostFromHeightDelta(float heightDelta)
	{
		return default(float);
	}
}
