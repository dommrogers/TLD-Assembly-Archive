using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NoSpawnRegion : MonoBehaviour
{
	public float m_Radius;

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public NoSpawnRegion()
	{
	}
}
