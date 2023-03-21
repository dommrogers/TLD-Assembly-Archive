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

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public DebugViewMode GetMode()
	{
		return default(DebugViewMode);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	public void SetMode(DebugViewMode mode)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_debug_view_mode")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_debug_view_mode")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "OnDisable")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "OnEnable")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "OnEnable")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "SetMode")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "SetMode")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "OnDisable")]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleLightingOnly")]
	[Calls(Type = typeof(Camera), Member = "SetReplacementShader")]
	[Calls(Type = typeof(Camera), Member = "ResetReplacementShader")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 8)]
	private void ToggleMode(DebugViewMode mode, bool isEnabled)
	{
	}

	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(Camera), Member = "ResetReplacementShader")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Camera), Member = "SetReplacementShader")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	private void ToggleDiffuseOnly(bool isOn)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Camera), Member = "SetReplacementShader")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
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

	[Calls(Type = typeof(Weather), Member = "DisableWindEffect")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableWeatherSystems")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[Calls(Type = typeof(Camera), Member = "SetReplacementShader")]
	[Calls(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableWeatherSystems")]
	[Calls(Type = typeof(Weather), Member = "EnableWindEffect")]
	private void ToggleTexelDensity(bool isOn)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public DebugViewModeManager()
	{
	}
}
