using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MapMarkerManager : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void AddMarker()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void RemoveMarker()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MapMarkerManager()
	{
	}
}
