using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MapMarkerManager : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void AddMarker()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void RemoveMarker()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MapMarkerManager()
	{
	}
}
