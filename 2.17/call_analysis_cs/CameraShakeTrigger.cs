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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	public CameraShakeTrigger()
	{
	}
}
