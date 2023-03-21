using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FirstPersonFlashlight : MonoBehaviour
{
	private GameObject m_LowFxGameObject;

	private GameObject m_HighFxGameObject;

	private Light m_LightIndoorsLow;

	private Light m_LightIndoorsHigh;

	private Light m_LightOutdoorsLow;

	private Light m_LightOutdoorsHigh;

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(FlashlightItem), Member = "IsLit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FirstPersonFlashlight()
	{
	}
}
