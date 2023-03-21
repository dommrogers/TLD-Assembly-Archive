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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 30)]
	public void UpdateFrom(MapElementSaveData me)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Remove(MapElementSaveData mesd)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void UpdateMapElement()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "GetOrCreateClusterCell")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(MapElementSaveData), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public ClusterCell()
	{
	}
}
