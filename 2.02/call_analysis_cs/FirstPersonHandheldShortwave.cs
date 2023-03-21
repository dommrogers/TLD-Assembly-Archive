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

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateIntensityNeedle")]
	[Calls(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateBlinkingLight")]
	[CallsUnknownMethods(Count = 4)]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Quaternion), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "LateUpdate")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "IsActive")]
	private void UpdateIntensityNeedle(HandheldShortwaveItem hhsw)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "LateUpdate")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
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
