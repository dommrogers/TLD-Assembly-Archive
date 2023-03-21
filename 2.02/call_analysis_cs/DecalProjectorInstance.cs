using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DecalProjectorInstance
{
	public string m_Guid;

	public string m_DecalName;

	public DecalProjectorType m_DecalProjectorType;

	public float m_HoursAtCreateTime;

	public float m_LifeTimeHours;

	public bool m_Indoors;

	public Vector3 m_Pos;

	public Vector3 m_Normal;

	public Vector3 m_Scale;

	public float m_Yaw;

	public int m_CreateUVRectangleIndex;

	public float m_Alpha;

	public bool m_WasRendered;

	public Color m_ColorTint;

	public bool m_IsPlacing;

	public bool m_IsRevealing;

	public float m_RevealAmount;

	public float m_EraseAmount;

	public bool m_RevealedOnMap;

	public ProjectileType m_ProjectileType;

	public GameObject m_SpawnedObject;

	public List<DecalProjectorMaskData> m_MaskData;

	public bool m_FadeOverEntireLifetime;

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "GetIntersectedSprayPaintDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateOverlappingDecalInPlace")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddProjectorInstanceBoundsInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Bounds), Member = ".ctor")]
	public Bounds GetBounds()
	{
		return default(Bounds);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public DecalProjectorInstance()
	{
	}
}
