using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MultiplyNighttimeParticleOpacity : MonoBehaviour
{
	public float m_OpacityMultiplier;

	public bool m_OverrideIfHoldingLight;

	private ParticleSystem m_PS;

	private ParticleSystem.MainModule m_PSMain;

	private UniStormWeatherSystem m_UniStorm;

	private Color m_OriginalColor;

	private float m_CurrentAlpha;

	private float m_DestinationAlpha;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(PlayerManager), Member = "GetHeldLightIntensity")]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MultiplyNighttimeParticleOpacity()
	{
	}
}
