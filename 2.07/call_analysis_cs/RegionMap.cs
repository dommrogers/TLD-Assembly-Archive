using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Scenes;
using UnityEngine;

[Serializable]
public class RegionMap
{
	public string m_RegionName;

	public ZoneSpecification m_Zone;

	public GameObject m_RegionMapObject;

	public Vector3 m_CenterOfScene;

	public Vector3 m_RadiusOfScene;

	public float m_Angle;

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "MapPositionToWorldPosition")]
	[CalledBy(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetWorldMapForSceneSet")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Map), Member = "UnlockRegionMap")]
	public bool IsRegionMatch(string regionName)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public RegionMap()
	{
	}
}
