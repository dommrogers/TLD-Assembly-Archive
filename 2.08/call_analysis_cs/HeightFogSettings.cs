using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public struct HeightFogSettings
{
	public float m_AmbientLightImpact;

	public float m_PlayerLightColorImpact;

	public float m_PlayerLightIntensityImpact;

	public Color m_FogColor;

	public float m_FogDensity;

	public float m_FogPower;

	public float m_FogDistanceStart;

	public float m_FogDistanceEnd;

	public float m_FogDistanceFalloff;

	public float m_FogHeightStart;

	public float m_FogHeightEnd;

	public float m_FogHeightFalloff;

	public float m_NoiseStrength;

	public float m_NoiseScale;

	public Vector3 m_NoiseSpeed;

	[CalledBy(Type = typeof(HeightFogManager), Member = "Update")]
	[CallerCount(Count = 1)]
	public bool IsFogVisible()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(HeightFogManager), Member = "Update")]
	public void Clear()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(HeightFogManager), Member = "Update")]
	public void Blend(HeightFogSettings other, float blendAmount)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetHeldLightIntensity")]
	[Calls(Type = typeof(PlayerManager), Member = "GetHeldLightColor")]
	[CalledBy(Type = typeof(HeightFogManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyLightSources()
	{
	}
}
