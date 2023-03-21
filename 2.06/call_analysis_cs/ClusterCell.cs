using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class ClusterCell : MapElementSaveData
{
	[NonSerialized]
	public Panel_Map m_Map;

	[NonSerialized]
	public int m_MapPosX;

	[NonSerialized]
	public int m_MapPosY;

	[NonSerialized]
	public float m_Size;

	[NonSerialized]
	public bool m_IsValid;

	[NonSerialized]
	public List<MapElementSaveData> m_Elements;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[CallsUnknownMethods(Count = 21)]
	public void UpdateFrom(MapElementSaveData me)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Remove(MapElementSaveData mesd)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[CallsUnknownMethods(Count = 6)]
	public void UpdateMapElement()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(MapElementSaveData), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public ClusterCell()
	{
	}
}
