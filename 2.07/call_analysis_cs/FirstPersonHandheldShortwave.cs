using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FirstPersonHandheldShortwave : MonoBehaviour
{
	public Transform m_NeedleTransform;

	public float m_MinAngle;

	public float m_MaxAngle;

	public Light m_Light;

	public float m_FarRangeBlinkRate;

	public float m_MidRangeBlinkRate;

	public float m_NearRangeBlinkRate;

	private float m_LedBlinkTimer;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateBlinkingLight")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateIntensityNeedle")]
	[CallsUnknownMethods(Count = 3)]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "LateUpdate")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "IsActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void UpdateIntensityNeedle(HandheldShortwaveItem hhsw)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "LateUpdate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	private void UpdateBlinkingLight(HandheldShortwaveItem hhsw)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FirstPersonHandheldShortwave()
	{
	}
}
