using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GroundNoNavMeshTracker : MonoBehaviour
{
	public List<GameObject> m_GroundNoNavMeshObjects;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public GroundNoNavMeshTracker()
	{
	}
}
