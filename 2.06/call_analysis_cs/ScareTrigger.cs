using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ScareTrigger : MonoBehaviour
{
	public FlareGunRoundItem m_FlareGunRound;

	public float m_FleeRadiusScalarInFlight;

	public float m_FleeRadiusScalarOnGround;

	private Vector3 m_OldPos;

	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromFlareGunRound")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 8)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ScareTrigger()
	{
	}
}
