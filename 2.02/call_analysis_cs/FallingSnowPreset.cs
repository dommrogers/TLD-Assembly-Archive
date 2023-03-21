using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FallingSnowPreset
{
	public enum Type
	{
		Light,
		Heavy,
		Blizzard,
		None,
		Undefined
	}

	private Type m_Type;

	private float m_MaxParticles;

	private float m_EmissionRate;

	private float m_StartLifetime;

	private float m_GravityModifier;

	private float m_RendererSpeedScale;

	public float m_TurbulenceScalar;

	public float m_FlurryScalar;

	public const float BLIZZARD_MAX_PARTICLES = 4000f;

	public const float HEAVY_SNOW_MAX_PARTICLES = 3000f;

	public const float LIGHT_SNOW_MAX_PARTICLES_MIN = 750f;

	public const float LIGHT_SNOW_MAX_PARTICLES_MAX = 1500f;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public FallingSnowPreset()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Weather), Member = "SetSnowPresetBlend")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Weather), Member = "SetSnowPresetBlend")]
	public FallingSnowPreset(Type type)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(Weather), Member = "UpdateFallingSnowPreset")]
	[CallsUnknownMethods(Count = 2)]
	public void SetBlended(FallingSnowPreset a, FallingSnowPreset b, float blend)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Weather), Member = "UpdateFallingSnowPreset")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	public void Apply(ParticleSystem ps, ParticleSystemRenderer lpr)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private float GetAdjustedMaxFallingParticlesCount(Type type)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private float GetMaxFallingParticlesCount(Type type)
	{
		return default(float);
	}
}
