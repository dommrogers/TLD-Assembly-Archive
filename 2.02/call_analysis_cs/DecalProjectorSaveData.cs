using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DecalProjectorSaveData
{
	public string m_Guid;

	public string m_DecalName;

	public Vector3 m_Pos;

	public Vector3 m_Normal;

	public Vector3 m_Scale;

	public float m_Yaw;

	public int m_UVRectangleIndex;

	public DecalProjectorType m_DecalProjectorType;

	public float m_HoursAtCreateTime;

	public float m_LifeTimeHours;

	public bool m_Indoors;

	public Color m_ColorTint;

	public bool m_RevealedOnMap;

	public bool m_FadeOverEntireLifetime;

	public ProjectileType m_ProjectileType;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public DecalProjectorSaveData()
	{
	}
}
