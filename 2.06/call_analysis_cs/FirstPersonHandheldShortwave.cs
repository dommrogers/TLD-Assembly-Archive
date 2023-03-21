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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateIntensityNeedle")]
	[Calls(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateBlinkingLight")]
	[CallsUnknownMethods(Count = 3)]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "LateUpdate")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "IsActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void UpdateIntensityNeedle(HandheldShortwaveItem hhsw)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "LateUpdate")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	private void UpdateBlinkingLight(HandheldShortwaveItem hhsw)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FirstPersonHandheldShortwave()
	{
	}
}
