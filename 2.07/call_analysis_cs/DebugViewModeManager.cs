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
	[CallerCount(Count = 1)]
	public DebugViewMode GetMode()
	{
		return default(DebugViewMode);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_debug_view_mode")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "OnDisable")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "OnEnable")]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleLightingOnly")]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleLightingOnly")]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleDiffuseOnly")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleDiffuseOnly")]
	public void SetMode(DebugViewMode mode)
	{
	}

	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleDiffuseOnly")]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleLightingOnly")]
	private void ToggleMode(DebugViewMode mode, bool isEnabled)
	{
	}

	[Calls(Type = typeof(DebugViewModeManager), Member = "SetMode")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugViewModeManager), Member = "SetMode")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Camera), Member = "ResetReplacementShader")]
	[Calls(Type = typeof(Camera), Member = "SetReplacementShader")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "SetMode")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "SetMode")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	[CallsUnknownMethods(Count = 1)]
	private void ToggleDiffuseOnly(bool isOn)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "SetMode")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "SetMode")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Camera), Member = "SetReplacementShader")]
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
		return default(float);
	}

	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "SetMode")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "SetMode")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableWeatherSystems")]
	[Calls(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "DisableWindEffect")]
	[Calls(Type = typeof(Camera), Member = "SetReplacementShader")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableWeatherSystems")]
	[Calls(Type = typeof(Weather), Member = "EnableWindEffect")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	private void ToggleTexelDensity(bool isOn)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DebugViewModeManager()
	{
	}
}
