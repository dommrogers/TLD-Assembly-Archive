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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 40)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public StudioLightingRig()
	{
	}
}
