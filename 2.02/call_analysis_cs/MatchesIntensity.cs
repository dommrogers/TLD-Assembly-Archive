using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MatchesIntensity : MonoBehaviour
{
	public GameObject m_FXPrefab;

	public float m_FlameOffset;

	private GearItem m_GearItem;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MatchesIntensity()
	{
	}
}
