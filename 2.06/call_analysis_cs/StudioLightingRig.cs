using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StudioLightingRig : MonoBehaviour
{
	public bool m_FaceCamera;

	public bool m_OnNPC;

	public bool m_BacklightTakesFresnelColor;

	public bool m_FadeLightsWhenOnSide;

	public float m_AmountToFadeKey;

	public float m_AmountToFadeBack;

	private float m_BaseFadeCalculation;

	private float m_KeyFadeCalculation;

	private float m_BackFadeCalculation;

	private float[] m_KeyInitialIntensity;

	private float[] m_BackInitialIntensity;

	public Light[] m_KeyLights;

	public Light[] m_BackLights;

	private Vector3 m_PlayerTarget;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public StudioLightingRig()
	{
	}
}
