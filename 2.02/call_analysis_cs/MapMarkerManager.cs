using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MapMarkerManager : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void AddMarker()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void RemoveMarker()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MapMarkerManager()
	{
	}
}
