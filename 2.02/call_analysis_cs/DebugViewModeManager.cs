using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DebugViewModeManager : MonoBehaviour
{
	private Shader m_DiffuseOnlyShader;

	private Shader m_LightingOnlyShader;

	private CameraEffects.SSAOMode m_LastSSAOMode;

	private Shader m_TexelDensityShader;

	public const float DEFAULT_TEXEL_DENSITY_TARGET = 256f;

	private static float s_TexelDensityTarget;

	private static readonly int s_TargetShaderID;

	private DebugViewMode m_CurrentMode;

	private static DebugViewMode s_LastMode;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Camera), Member = "ResetReplacementShader")]
	[Calls(Type = typeof(Camera), Member = "SetReplacementShader")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ToggleDiffuseOnly(bool isOn)
	{
	}

	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(Camera), Member = "SetReplacementShader")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void ToggleLightingOnly(bool isOn)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetTexelDensityTarget(float target)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float GetTexelDensityTarget()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Weather), Member = "EnableWindEffect")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "EnableWeatherSystems")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Camera), Member = "SetReplacementShader")]
	[Calls(Type = typeof(Weather), Member = "DisableWindEffect")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[Calls(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	private void ToggleTexelDensity(bool isOn)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Camera), Member = "ResetReplacementShader")]
	[Calls(Type = typeof(Camera), Member = "SetReplacementShader")]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleLightingOnly")]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ToggleMode(DebugViewMode mode, bool isEnabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugViewModeManager), Member = "ToggleMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DebugViewModeManager()
	{
	}
}
