using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NoSpawnRegion : MonoBehaviour
{
	public float m_Radius;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NoSpawnRegion()
	{
	}
}
