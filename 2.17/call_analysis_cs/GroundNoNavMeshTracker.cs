using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GroundNoNavMeshTracker : MonoBehaviour
{
	public List<GameObject> m_GroundNoNavMeshObjects;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GroundNoNavMeshTracker()
	{
	}
}
