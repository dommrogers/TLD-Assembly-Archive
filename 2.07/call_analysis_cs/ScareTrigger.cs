using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ScareTrigger : MonoBehaviour
{
	public FlareGunRoundItem m_FlareGunRound;

	public float m_FleeRadiusScalarInFlight;

	public float m_FleeRadiusScalarOnGround;

	private Vector3 m_OldPos;

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromFlareGunRound")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ScareTrigger()
	{
	}
}
