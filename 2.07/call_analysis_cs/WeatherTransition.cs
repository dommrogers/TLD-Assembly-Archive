using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class WeatherTransition : MonoBehaviour
{
	public static float m_WeatherTransitionTimeScalar;

	public static bool m_SuppressBlizzards;

	public WeatherStage m_DefaultStartWeather;

	private WeatherSetData m_CurrentWeatherSet;

	private WeatherStage m_PreviousWeatherSetType;

	private WeatherStage m_UnmanagedWeatherStage;

	private bool m_StartHasBeenCalled;

	private static WeatherTransitionSaveDataProxy m_WeatherTransitionSaveDataProxy;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherSetStage), Member = "Deactivate")]
	public void OnDisable()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherSetData), Member = "UpdateWeatherSet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceNextWeatherStage")]
	[Calls(Type = typeof(WeatherTransition), Member = "ChooseNextWeatherSet")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(WeatherTransition), Member = "GetCustomWeightsForCurrentXpMode")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherTransition), Member = "ChooseNextWeatherSet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceNextWeatherStage")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(WeatherSetData), Member = "Serialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(WeatherSetData), Member = "GetProgressFrac")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[Calls(Type = typeof(WeatherSetData), Member = "Prepare")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[Calls(Type = typeof(WeatherSetData), Member = "Deserialize")]
	[Calls(Type = typeof(Weather), Member = "GetWeatherSetByName")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(StartSettings), Member = "SetRandomWeather")]
	[CalledBy(Type = typeof(StartSettings), Member = "SetWeather")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Update")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_next_weatherset")]
	[CallerCount(Count = 5)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Update")]
	public void ChooseNextWeatherSet(int[] customWeights = null, bool forceClear = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "GetCustomWeatherSet")]
	[Calls(Type = typeof(WeatherSetData), Member = "Prepare")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CallsUnknownMethods(Count = 1)]
	public bool ActivateWeatherSet(string customTypeName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "OnBehaviourPlay")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_aurora_immediate")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[Calls(Type = typeof(WeatherSetData), Member = "Prepare")]
	[Calls(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	public void ActivateWeatherSetImmediate(WeatherStage reqType)
	{
	}

	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	[Calls(Type = typeof(WeatherSetData), Member = "Prepare")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CallsUnknownMethods(Count = 2)]
	public void ActivateWeatherSetAtFrac(WeatherStage reqType, float startAtFrac)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	public void ActivateWeatherSet(WeatherStage reqType)
	{
	}

	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_weather")]
	[Calls(Type = typeof(WeatherSetData), Member = "Activate")]
	[Calls(Type = typeof(WeatherSetStage), Member = "Deactivate")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	public void ActivateWeatherSet(WeatherSetData ws, float startAtFrac, WeatherStage previousType = WeatherStage.Undefined)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	public void ActivateDefaultWeatherSet()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherSetData), Member = "ForceStep")]
	[Calls(Type = typeof(WeatherSetData), Member = "ForceStep")]
	[CallsUnknownMethods(Count = 2)]
	public void ForceTransitionToWeatherStage(int forceIndex)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_next_weather")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherSetData), Member = "ForceStep")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Update")]
	public void ForceNextWeatherStage(int forceIndex = -1)
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(StartSettings), Member = "SetLockedWeather")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(StartSettings), Member = "SetWeather")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_random_weather")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lock_weather")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(WeatherSetStage), Member = "Deactivate")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lock_weather_instant")]
	public void ForceUnmanagedWeatherStage(WeatherStage ws, float transitionTime)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherSetData), Member = "GetDebugString")]
	public string GetDebugString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool IsLocked()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CallsUnknownMethods(Count = 2)]
	public void OverrideDurationOfStageInCurrentWeatherSet(WeatherStage weatherType, float duration)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetDurationOfStageInCurrentWeatherSet(WeatherStage weatherType)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetElapsedTimeOfStageInCurrentWeatherSet(WeatherStage weatherType)
	{
		return default(float);
	}

	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallsUnknownMethods(Count = 3)]
	private int[] GetCustomWeightsForCurrentXpMode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public WeatherTransition()
	{
	}
}
