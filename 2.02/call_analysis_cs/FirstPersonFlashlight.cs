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
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(FlashlightItem), Member = "IsLit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 28)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FirstPersonFlashlight()
	{
	}
}
