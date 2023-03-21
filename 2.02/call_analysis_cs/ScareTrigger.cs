using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ScareTrigger : MonoBehaviour
{
	public FlareGunRoundItem m_FlareGunRound;

	public float m_FleeRadiusScalarInFlight;

	public float m_FleeRadiusScalarOnGround;

	private Vector3 m_OldPos;

	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromFlareGunRound")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ScareTrigger()
	{
	}
}
