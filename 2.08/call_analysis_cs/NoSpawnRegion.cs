using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NoSpawnRegion : MonoBehaviour
{
	public float m_Radius;

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NoSpawnRegion()
	{
	}
}
