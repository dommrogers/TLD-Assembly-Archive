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

	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateFrom(MapElementSaveData me)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public void Remove(MapElementSaveData mesd)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[CallsUnknownMethods(Count = 6)]
	public void UpdateMapElement()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapElementSaveData), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ClusterCell()
	{
	}
}
