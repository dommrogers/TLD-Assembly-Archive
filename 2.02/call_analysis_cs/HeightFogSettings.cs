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

	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CalledBy(Type = typeof(HeightFogManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsFogVisible()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(HeightFogManager), Member = "Update")]
	public void Clear()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CalledBy(Type = typeof(HeightFogManager), Member = "Update")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	public void Blend(HeightFogSettings other, float blendAmount)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "GetHeldLightColor")]
	[Calls(Type = typeof(PlayerManager), Member = "GetHeldLightIntensity")]
	[CalledBy(Type = typeof(HeightFogManager), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	public void ApplyLightSources()
	{
	}
}
