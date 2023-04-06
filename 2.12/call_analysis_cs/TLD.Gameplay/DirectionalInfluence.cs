using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using UnityEngine;

namespace TLD.Gameplay;

public class DirectionalInfluence : MonoBehaviour
{
	public float m_ConeAngle;

	[CalledBy(Type = typeof(AnimatedTimedHoldInteraction), Member = "PerformInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public float GetNormalizedInfluenceFromPosition(Vector3 worldPos)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DirectionalInfluence()
	{
	}
}
