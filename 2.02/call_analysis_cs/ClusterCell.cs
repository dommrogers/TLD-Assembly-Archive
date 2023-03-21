using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class ClusterCell : MapElementSaveData
{
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

	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 30)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	public void UpdateFrom(MapElementSaveData me)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Remove(MapElementSaveData mesd)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[CallsUnknownMethods(Count = 9)]
	public void UpdateMapElement()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "GetOrCreateClusterCell")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MapElementSaveData), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public ClusterCell()
	{
	}
}
