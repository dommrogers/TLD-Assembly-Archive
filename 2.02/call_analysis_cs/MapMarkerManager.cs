using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MapMarkerManager : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void AddMarker()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void RemoveMarker()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public MapMarkerManager()
	{
	}
}
