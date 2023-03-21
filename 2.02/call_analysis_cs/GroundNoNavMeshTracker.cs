using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GroundNoNavMeshTracker : MonoBehaviour
{
	public List<GameObject> m_GroundNoNavMeshObjects;

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public GroundNoNavMeshTracker()
	{
	}
}
