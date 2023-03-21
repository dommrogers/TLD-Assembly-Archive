using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MapElementSaveData
{
	public string m_SpriteName;

	public string m_LocationNameLocID;

	public string m_CustomName;

	public bool m_BigSprite;

	public bool m_IsDetail;

	public bool m_IsArea;

	public bool m_NameIsKnown;

	public Vector2 m_PositionOnMap;

	public Vector2 m_AreaSizeOnMap;

	public float m_DirectionalAngle;

	public bool m_MergeWithNearbyLocationIcons;

	public List<string> m_ActiveMissionLocIDs;

	public List<string> m_ActiveMissionTimerIDs;

	public List<string> m_ActiveMissionIDs;

	public List<string> m_ActiveObjectiveIDs;

	public string m_Guid;

	[NonSerialized]
	public ClusterCell m_ClusterCell;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(ClusterCell), Member = ".ctor")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToWorldPos")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetOrCreateClusterCell")]
	public MapElementSaveData()
	{
	}
}
