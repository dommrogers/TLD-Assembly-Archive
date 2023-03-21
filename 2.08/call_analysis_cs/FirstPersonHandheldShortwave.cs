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
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateIntensityNeedle")]
	[Calls(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateBlinkingLight")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "IsActive")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateIntensityNeedle(HandheldShortwaveItem hhsw)
	{
	}

	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateBlinkingLight(HandheldShortwaveItem hhsw)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FirstPersonHandheldShortwave()
	{
	}
}
