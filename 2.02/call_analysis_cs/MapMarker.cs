using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MapMarker
{
	public MapIcon.MapIconType m_IconType;

	public string m_LocID;

	public string m_SpriteName;

	public bool m_RequiresInteraction;

	public List<Harvestable> m_HarvestablesSharingIcon;

	public bool m_RegisterOnAwake;

	public Harvestable[] m_HarvestablesForMapVisibility;

	public Vector3 m_RaycastTargetOffset;

	public bool m_ShowDirectionIcon;

	public float m_DirectionIconAngleDegrees;

	public bool m_IsRemovedWithDelay;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public MapMarker()
	{
	}
}
