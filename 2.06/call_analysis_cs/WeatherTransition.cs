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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherSetStage), Member = "Deactivate")]
	[CallsUnknownMethods(Count = 2)]
	public void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherTransition), Member = "ChooseNextWeatherSet")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceNextWeatherStage")]
	[Calls(Type = typeof(WeatherSetData), Member = "UpdateWeatherSet")]
	[Calls(Type = typeof(WeatherTransition), Member = "GetCustomWeightsForCurrentXpMode")]
	[CallsUnknownMethods(Count = 4)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(WeatherSetData), Member = "GetProgressFrac")]
	[Calls(Type = typeof(WeatherSetData), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Weather), Member = "GetWeatherSetByName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(WeatherSetData), Member = "Deserialize")]
	[Calls(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	[Calls(Type = typeof(WeatherSetData), Member = "Prepare")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Update")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_next_weatherset")]
	[CalledBy(Type = typeof(StartSettings), Member = "SetWeather")]
	[CalledBy(Type = typeof(StartSettings), Member = "SetRandomWeather")]
	[CallerCount(Count = 5)]
	public void ChooseNextWeatherSet(int[] customWeights = null, bool forceClear = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "GetCustomWeatherSet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(WeatherSetData), Member = "Prepare")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CallsUnknownMethods(Count = 1)]
	public bool ActivateWeatherSet(string customTypeName)
	{
		return false;
	}

	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_aurora_immediate")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "OnBehaviourPlay")]
	[CalledBy(TypeFullName = "LightingCapture.<CaptureFrame>d__15", Member = "MoveNext")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	[Calls(Type = typeof(WeatherSetData), Member = "Prepare")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CallsUnknownMethods(Count = 1)]
	public void ActivateWeatherSetImmediate(WeatherStage reqType)
	{
	}

	[CalledBy(Type = typeof(WeatherTransition), Member = "Start")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateDefaultWeatherSet")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_electrostatic_fog")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_aurora")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lighting_preview")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_weather")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdownCompleted")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "StartFogWeatherTransition")]
	[CalledBy(Type = typeof(PlayerSpawn), Member = "SetStartTimeAndWeather")]
	[CalledBy(Type = typeof(PlayerSpawn), Member = "SetWeather")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "OnBehaviourPlay")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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

	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_weather")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(WeatherSetData), Member = "Deactivate")]
	[Calls(Type = typeof(WeatherSetData), Member = "Activate")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 2)]
	public void ForceTransitionToWeatherStage(int forceIndex)
	{
	}

	[CalledBy(Type = typeof(WeatherTransition), Member = "Update")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_next_weather")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherSetData), Member = "ForceStep")]
	[CallsUnknownMethods(Count = 1)]
	public void ForceNextWeatherStage(int forceIndex = -1)
	{
	}

	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lock_weather")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lock_weather_instant")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_random_weather")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(StartSettings), Member = "SetWeather")]
	[CalledBy(Type = typeof(StartSettings), Member = "SetLockedWeather")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "OnBehaviourPlay")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(WeatherSetStage), Member = "Deactivate")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[CallsUnknownMethods(Count = 2)]
	public void ForceUnmanagedWeatherStage(WeatherStage ws, float transitionTime)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(WeatherSetData), Member = "GetDebugString")]
	[CallsUnknownMethods(Count = 1)]
	public string GetDebugString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public bool IsLocked()
	{
		return false;
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	public void OverrideDurationOfStageInCurrentWeatherSet(WeatherStage weatherType, float duration)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	public float GetDurationOfStageInCurrentWeatherSet(WeatherStage weatherType)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	public float GetElapsedTimeOfStageInCurrentWeatherSet(WeatherStage weatherType)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(WeatherTransition), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
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
