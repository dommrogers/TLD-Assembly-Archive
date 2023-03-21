using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPCLightingRig : MonoBehaviour
{
	private Transform m_NPCTransform;

	public float m_DayIntensityScalar;

	public float m_NightIntensityScalar;

	private Light m_LeftRimLight;

	private Light m_RightRimLight;

	private Light m_LeftFillLight;

	private Light m_RightFillLight;

	public float m_RotationOffset;

	private Gradient m_LeftRimColor;

	private Gradient m_RightRimColor;

	private Gradient m_LeftFillColor;

	private Gradient m_RightFillColor;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetNightPercentage")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 20)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public NPCLightingRig()
	{
	}
}
