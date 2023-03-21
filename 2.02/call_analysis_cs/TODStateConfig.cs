using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class TODStateConfig
{
	public Color m_AmbientLight;

	public Color m_SunLight;

	public Color m_SunLightInterior;

	public Color m_FogColor;

	public Color m_SkyFogColor;

	public Color m_SkyGlowColor;

	public Color m_HorizonCloudsColor1;

	public Color m_HorizonCloudsColor2;

	public Color m_HorizonCloudsColor3;

	public Color m_HorizonGradColor;

	public Color m_GodrayColor;

	public Color m_TerrainFresnelColor;

	public float m_SunLightIntensity;

	public float m_SunLightIntensityInterior;

	public float m_MoonLightIntensity;

	public float m_MoonLightIntensityInterior;

	public float m_FogDensity;

	public float m_FogDirectionalTint;

	public float m_MoonAlpha;

	public float m_StarsAlpha;

	public float m_SkyboxAtmosphere;

	public float m_SkyboxExposure;

	public float m_SkyboxSunDiffusion;

	public Vector4 m_CloudAlphas;

	public float m_SkyFogBias;

	public float m_SnowPatchBlendMax;

	public Texture2D m_LUT;

	public ColorGradingSettings m_ColorGradingSettings;

	public Color m_SnowColor;

	public Color m_BlowingSnowColor;

	public float m_BloomIntensity;

	public float m_BloomThreshold;

	public float m_BloomSampleDistance;

	public float m_BloomSoftKnee;

	public float m_ContrastEnhanceIntensity;

	public float m_ContrastEnhanceBlurSpread;

	public float m_ImageSaturation;

	public float m_VignettingIntensity;

	public float m_VignettingChromaticAberration;

	[CalledBy(Type = typeof(ActiveEnvironment), Member = "Refresh")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(ActiveEnvironment), Member = "Set")]
	[CalledBy(Type = typeof(ActiveEnvironment), Member = "Refresh")]
	[CalledBy(Type = typeof(ActiveEnvironment), Member = "Refresh")]
	[CalledBy(Type = typeof(ActiveEnvironment), Member = "Refresh")]
	[CalledBy(Type = typeof(ActiveEnvironment), Member = "Refresh")]
	[CalledBy(Type = typeof(ActiveEnvironment), Member = "Refresh")]
	[CalledBy(Type = typeof(ActiveEnvironment), Member = "Refresh")]
	[CalledBy(Type = typeof(ActiveEnvironment), Member = "Refresh")]
	[CalledBy(Type = typeof(ActiveEnvironment), Member = "Refresh")]
	[CalledBy(Type = typeof(ActiveEnvironment), Member = "Refresh")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(ActiveEnvironment), Member = "Refresh")]
	[CalledBy(Type = typeof(ActiveEnvironment), Member = "Refresh")]
	[CalledBy(Type = typeof(ActiveEnvironment), Member = "Refresh")]
	[CalledBy(Type = typeof(ActiveEnvironment), Member = "Refresh")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ActiveEnvironment), Member = "Refresh")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector4), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	public void SetBlended(TODStateConfig a, TODStateConfig b, float blend, float blendBiased, int nightStates)
	{
	}

	[CallerCount(Count = 0)]
	public void SetIndoors()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public TODStateConfig()
	{
	}
}
