using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ScareTrigger : MonoBehaviour
{
	public FlareGunRoundItem m_FlareGunRound;

	public float m_FleeRadiusScalarInFlight;

	public float m_FleeRadiusScalarOnGround;

	private Vector3 m_OldPos;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromFlareGunRound")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ScareTrigger()
	{
	}
}
