using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MatchesIntensity : MonoBehaviour
{
	public GameObject m_FXPrefab;

	public float m_FlameOffset;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MatchesIntensity()
	{
	}
}
