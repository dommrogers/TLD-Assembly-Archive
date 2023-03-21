using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MapMarkerManager : MonoBehaviour
{
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
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
