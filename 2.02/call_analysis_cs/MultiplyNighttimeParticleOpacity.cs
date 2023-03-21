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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(ParticleSystem.MainModule), Member = "get_startColor")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetHeldLightIntensity")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDawn")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MultiplyNighttimeParticleOpacity()
	{
	}
}
