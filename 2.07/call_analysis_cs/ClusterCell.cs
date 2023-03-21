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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void UpdateFrom(MapElementSaveData me)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Remove(MapElementSaveData mesd)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Contains")]
	public void UpdateMapElement()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MapElementSaveData), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public ClusterCell()
	{
	}
}
