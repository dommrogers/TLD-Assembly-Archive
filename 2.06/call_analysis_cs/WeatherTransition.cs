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
	[Calls(Type = typeof(WeatherSetStage), Member = "Deactivate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnDisable()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(WeatherTransition), Member = "ChooseNextWeatherSet")]
	[Calls(Type = typeof(WeatherTransition), Member = "GetCustomWeightsForCurrentXpMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherSetData), Member = "UpdateWeatherSet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceNextWeatherStage")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherTransition), Member = "ChooseNextWeatherSet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceNextWeatherStage")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(WeatherSetData), Member = "GetProgressFrac")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(WeatherSetData), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(WeatherSetData), Member = "Prepare")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(WeatherSetData), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
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
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_next_weatherset")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Update")]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Update")]
	public void ChooseNextWeatherSet(int[] customWeights = null, bool forceClear = false)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[Calls(Type = typeof(WeatherSetData), Member = "Prepare")]
	[Calls(Type = typeof(Weather), Member = "GetCustomWeatherSet")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public bool ActivateWeatherSet(string customTypeName)
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	[Calls(Type = typeof(WeatherSetData), Member = "Prepare")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_aurora_immediate")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	public void ActivateWeatherSetImmediate(WeatherStage reqType)
	{
	}

	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(WeatherSetData), Member = "Prepare")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	[CallerCount(Count = 20)]
	public void ActivateWeatherSetAtFrac(WeatherStage reqType, float startAtFrac)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	public void ActivateWeatherSet(WeatherStage reqType)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_weather")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[Calls(Type = typeof(WeatherSetData), Member = "Activate")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(WeatherSetData), Member = "Deactivate")]
	public void ActivateWeatherSet(WeatherSetData ws, float startAtFrac, WeatherStage previousType = WeatherStage.Undefined)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	public void ActivateDefaultWeatherSet()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(WeatherSetData), Member = "ForceStep")]
	[Calls(Type = typeof(WeatherSetData), Member = "ForceStep")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void ForceTransitionToWeatherStage(int forceIndex)
	{
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherSetData), Member = "ForceStep")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Update")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Update")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_next_weather")]
	[CallsUnknownMethods(Count = 1)]
	public void ForceNextWeatherStage(int forceIndex = -1)
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(StartSettings), Member = "SetLockedWeather")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "OnBehaviourPlay")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_random_weather")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lock_weather_instant")]
	[CalledBy(Type = typeof(StartSettings), Member = "SetWeather")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lock_weather")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(WeatherSetStage), Member = "Deactivate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 10)]
	public void ForceUnmanagedWeatherStage(WeatherStage ws, float transitionTime)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(WeatherSetData), Member = "GetDebugString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	public string GetDebugString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public bool IsLocked()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	public void OverrideDurationOfStageInCurrentWeatherSet(WeatherStage weatherType, float duration)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetDurationOfStageInCurrentWeatherSet(WeatherStage weatherType)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	public float GetElapsedTimeOfStageInCurrentWeatherSet(WeatherStage weatherType)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private int[] GetCustomWeightsForCurrentXpMode()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public WeatherTransition()
	{
	}
}
