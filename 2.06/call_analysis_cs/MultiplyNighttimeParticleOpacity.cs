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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(ParticleSystem.MainModule), Member = "get_startColor")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetHeldLightIntensity")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MultiplyNighttimeParticleOpacity()
	{
	}
}
