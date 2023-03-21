using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.ModularElectrolizer;

public class IntensityParameters : ScriptableObject
{
	public float m_InitialIntensity;

	public float m_LightIntensityMultiplier;

	public float m_EmissiveIntensityMultiplier;

	public float m_IntensityUpdateThresholdPercent;

	public bool m_LightFadeWithAurora;

	public bool m_LightsScaleByRelativeValue;

	public bool m_RandomAuroraColor;

	public bool m_OverrideEmissiveColor;

	public Color m_OverrideColor;

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public IntensityParameters()
	{
	}
}
