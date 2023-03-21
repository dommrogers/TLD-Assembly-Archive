using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DebugViewModeManager : MonoBehaviour
{
	private DebugViewMode m_CurrentMode;

	private static DebugViewMode s_LastMode;

	private Shader m_DiffuseOnlyShader;

	private Shader m_LightingOnlyShader;

	private CameraEffects.SSAOMode m_LastSSAOMode;

	private Shader m_TexelDensityShader;

	public const float DEFAULT_TEXEL_DENSITY_TARGET = 256f;

	private static float s_TexelDensityTarget;

	private static readonly int s_TargetShaderID;

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	public DebugViewMode GetMode()
	{
		return default(DebugViewMode);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	public void SetMode(DebugViewMode mode)
	{
	}

	[CalledBy(Type = typeof(DebugViewModeManager), Member = "SetMode")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "OnEnable")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "OnDisable")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_debug_view_mode")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Camera), Member = "ResetReplacementShader")]
	[Calls(Type = typeof(Camera), Member = "SetReplacementShader")]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleLightingOnly")]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[CallsUnknownMethods(Count = 1)]
	private void ToggleMode(DebugViewMode mode, bool isEnabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Camera), Member = "ResetReplacementShader")]
	[Calls(Type = typeof(Camera), Member = "SetReplacementShader")]
	[CallsUnknownMethods(Count = 1)]
	private void ToggleDiffuseOnly(bool isOn)
	{
	}

	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(Camera), Member = "SetReplacementShader")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void ToggleLightingOnly(bool isOn)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetTexelDensityTarget(float target)
	{
	}

	[CallerCount(Count = 0)]
	public static float GetTexelDensityTarget()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Weather), Member = "EnableWindEffect")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableWeatherSystems")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Camera), Member = "SetReplacementShader")]
	[Calls(Type = typeof(Weather), Member = "DisableWindEffect")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[Calls(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void ToggleTexelDensity(bool isOn)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public DebugViewModeManager()
	{
	}
}
