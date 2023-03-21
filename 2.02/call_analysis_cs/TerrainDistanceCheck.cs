using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TerrainDistanceCheck : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TerrainDistanceCheck()
	{
	}
}
