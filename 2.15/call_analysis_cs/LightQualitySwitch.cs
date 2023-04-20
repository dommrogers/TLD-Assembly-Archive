using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering;

public class LightQualitySwitch : MonoBehaviour
{
	public enum LightLocation
	{
		auto,
		everywhere,
		indoor,
		outdoor,
		cinematic
	}

	public Light m_Light;

	public Texture m_Cookie;

	public LightLocation m_LightLocation;

	public bool m_LimitToDefaultValues;

	public LightShadowResolution m_LowResolution;

	public LightShadows m_LowShadowType;

	public bool m_LowDisabled;

	public LightShadowResolution m_MediumResolution;

	public LightShadows m_MediumShadowType;

	public bool m_MediumDisabled;

	public LightShadowResolution m_HighResolution;

	public LightShadows m_HighShadowType;

	public bool m_HighDisabled;

	public LightShadowResolution m_UltraResolution;

	public LightShadows m_UltraShadowType;

	public bool m_UltraDisabled;

	public LightShadowResolution m_ConsoleLowResolution;

	public LightShadows m_ConsoleLowShadowType;

	public bool m_ConsoleLowDisabled;

	public LightShadowResolution m_ConsoleResolution;

	public LightShadows m_ConsoleShadowType;

	public bool m_ConsoleDisabled;

	public LightShadowResolution m_ConsoleProResolution;

	public LightShadows m_ConsoleProShadowType;

	public bool m_ConsoleProDisabled;

	private Light[] m_LightList;

	private QualityShadows m_CachedQuality;

	private bool m_Initialized;

	private LightShadows m_DefaultShadowType;

	private LightShadowResolution m_DefaultShadowResolution;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightQualitySwitch), Member = "RefreshLocalQuality")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(LightQualitySwitch), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(LightQualitySwitch), Member = "SetLocalQuality")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshLocalQuality()
	{
	}

	[CalledBy(Type = typeof(LightQualitySwitch), Member = "RefreshLocalQuality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LightQualitySwitch), Member = "IsValidLocation")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(LightQualitySwitch), Member = "UpdateLight")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetLocalQuality(Light curLight)
	{
	}

	[CalledBy(Type = typeof(LightQualitySwitch), Member = "SetLocalQuality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsUnknownMethods(Count = 9)]
	private bool IsValidLocation()
	{
		return false;
	}

	[CalledBy(Type = typeof(LightQualitySwitch), Member = "SetLocalQuality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Light), Member = "set_cookie")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateLight(Light light, bool isDisabled, LightShadows shadowType, LightShadowResolution shadowResolution)
	{
	}

	[CallerCount(Count = 0)]
	public LightQualitySwitch()
	{
	}
}
