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
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateIntensityNeedle")]
	[Calls(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateBlinkingLight")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "IsActive")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "set_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateIntensityNeedle(HandheldShortwaveItem hhsw)
	{
	}

	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateBlinkingLight(HandheldShortwaveItem hhsw)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FirstPersonHandheldShortwave()
	{
	}
}
