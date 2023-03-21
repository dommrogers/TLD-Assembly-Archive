using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WorldMapRegion : MonoBehaviour
{
	public string m_RegionName;

	[CalledBy(Type = typeof(Panel_WorldMap), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "DoMouseControls")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_WorldMap), Member = "SelectRegionMap")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnSelect()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WorldMapRegion()
	{
	}
}
