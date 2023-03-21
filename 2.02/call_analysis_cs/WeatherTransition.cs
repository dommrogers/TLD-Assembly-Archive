using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WeatherTransition : MonoBehaviour
{
	public static float m_WeatherTransitionTimeScalar;

	public static bool m_SuppressBlizzards;

	public WeatherStage m_DefaultStartWeather;

	private WeatherSet m_CurrentWeatherSet;

	private WeatherStage m_PreviousWeatherSetType;

	private WeatherStage m_UnmanagedWeatherStage;

	private bool m_StartHasBeenCalled;

	private static WeatherTransitionSaveDataProxy m_WeatherTransitionSaveDataProxy;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(WeatherSet), Member = "Deactivate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherTransition), Member = "GetCustomWeightsForCurrentXpMode")]
	[Calls(Type = typeof(WeatherTransition), Member = "ChooseNextWeatherSet")]
	[Calls(Type = typeof(WeatherTransition), Member = "ChooseNextWeatherSet")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(WeatherSet), Member = "Serialize")]
	[Calls(Type = typeof(WeatherSet), Member = "GetProgressFrac")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(WeatherSet), Member = "Prepare")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Weather), Member = "GetWeatherSetByName")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(WeatherSet), Member = "Deserialize")]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(StartSettings), Member = "SetRandomWeather")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_next_weatherset")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Update")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_threedaysofnight_setday")]
	[CallerCount(Count = 5)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Update")]
	public void ChooseNextWeatherSet(int[] customWeights = null, bool forceClear = false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "GetCustomWeatherSet")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(WeatherSet), Member = "Prepare")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CallsUnknownMethods(Count = 3)]
	public bool ActivateWeatherSet(string customTypeName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_aurora_immediate")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "OnBehaviourPlay")]
	[Calls(Type = typeof(WeatherSet), Member = "Prepare")]
	[Calls(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public void ActivateWeatherSetImmediate(WeatherStage reqType)
	{
	}

	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	[Calls(Type = typeof(WeatherSet), Member = "Prepare")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CallsUnknownMethods(Count = 10)]
	public void ActivateWeatherSetAtFrac(WeatherStage reqType, float startAtFrac)
	{
	}

	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallerCount(Count = 0)]
	public void ActivateWeatherSet(WeatherStage reqType)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_weather")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(WeatherSet), Member = "Deactivate")]
	[Calls(Type = typeof(WeatherSet), Member = "Activate")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallsUnknownMethods(Count = 4)]
	public void ActivateWeatherSet(WeatherSet ws, float startAtFrac, WeatherStage previousType = WeatherStage.Undefined)
	{
	}

	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallerCount(Count = 0)]
	public void ActivateDefaultWeatherSet()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CalledBy(Type = typeof(WeatherSetStage), Member = "Update")]
	[CalledBy(Type = typeof(WeatherSet), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	public void MaybePlayStinger(string stinger)
	{
	}

	[Calls(Type = typeof(WeatherSet), Member = "ForceStep")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(WeatherSet), Member = "ForceStep")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ForceTransitionToWeatherStage(int forceIndex)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherSet), Member = "ForceStep")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_next_weather")]
	[CallsUnknownMethods(Count = 1)]
	public void ForceNextWeatherStage(int forceIndex = -1)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_random_weather")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lock_weather_instant")]
	[CalledBy(Type = typeof(StartSettings), Member = "SetLockedWeather")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeWeather), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lock_weather")]
	[Calls(Type = typeof(WeatherSet), Member = "Deactivate")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	public void ForceUnmanagedWeatherStage(WeatherStage ws, float transitionTime)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(WeatherSet), Member = "GetDebugString")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public string GetDebugString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public bool IsLocked()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	public void OverrideDurationOfStageInCurrentWeatherSet(WeatherStage weatherType, float duration)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetDurationOfStageInCurrentWeatherSet(WeatherStage weatherType)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Update")]
	[CallsUnknownMethods(Count = 41)]
	private int[] GetCustomWeightsForCurrentXpMode()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WeatherTransition()
	{
	}
}
