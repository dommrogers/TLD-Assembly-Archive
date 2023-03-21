using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MissionMapMarkerInfo : MonoBehaviour
{
	public string m_MarkerID;

	public string m_RegionName;

	public string m_LocationName;

	public Vector3 m_WorldPos;

	public Vector2 m_AreaZoneSize;

	public string m_MissionID;

	public string m_ObjectiveID;

	public string m_SpriteName;

	public MapIcon.MapIconType m_IconType;

	public bool m_MergeWithNearbyLocationIcons;

	public LocalizedString m_OptionalCustomName;

	public bool m_IsSurveyed;

	[CallerCount(Count = 0)]
	public MissionMapMarkerInfo()
	{
	}
}
