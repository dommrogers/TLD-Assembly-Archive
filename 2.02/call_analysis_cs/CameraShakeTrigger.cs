using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraShakeTrigger : MonoBehaviour
{
	private bool m_TriggeredByPlayer;

	private bool m_Repeatable;

	private Vector2 m_ShakeMagnitude;

	private float m_ShakeDurationSeconds;

	private float m_WeaponShakeFactor;

	private float m_CameraRollFactor;

	private bool m_WasTriggered;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_one")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public CameraShakeTrigger()
	{
	}
}
