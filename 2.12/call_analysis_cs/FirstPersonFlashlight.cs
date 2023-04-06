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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FlashlightItem), Member = "IsLit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FirstPersonFlashlight()
	{
	}
}
