using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

public class AuroraManager : MonoBehaviour
{
	public string m_AuroaAudio;

	public float m_SecondsBetweenFlyoverScale;

	public float m_WildlifeDetectionRangeScale;

	public float m_WildlifeFleeDistanceScale;

	public float m_DamageToPredatorsScale;

	public float m_PredatorInflictDamageScale;

	public float m_PredatorFleeChanceScale;

	public float m_PredatorAttackDistanceScale;

	public static bool m_ForceDisable;

	public static bool s_UseJobs;

	public static bool s_UseFarElectrolyzerOptim;

	public bool m_UseCinematicColours;

	public MinMax m_RedTint;

	public MinMax m_GreenTint;

	public MinMax m_BlueTint;

	public MinMax m_AlphaControl;

	public Vector4 m_RgbaCycleTime;

	public float m_ElectrolyzerFadeDurationRealtimeSeconds;

	private float m_ElectrolyzerFadeDurationHours;

	private Vector4 m_ColorTimers;

	public Gradient m_ElectricalColors;

	public MinMax m_ElectricalSaturation;

	public MinMax m_ElectricalValue;

	public float m_FarElectrolyzer_HalfUpdateRate_Radius;

	private float m_SpeedPercentage;

	private float m_FullyActiveValue;

	private static List<GameObject> m_AuroraGameObjectList;

	private static List<AuroraElectrolizer> m_AuroraElectrolizerList;

	private static List<int> m_AuroraElectrolizerFrameUpdatedList;

	private static List<bool> m_AuroraElectrolizerEnabledList;

	private static List<Vector3> m_AuroraElectrolizerPosList;

	private static List<AuroraLightingSimple> m_AuroraLightSimpleList;

	private static List<Vector3> m_AuroraLightSimplePosList;

	private static List<AuroraActivatedToggle> m_AuroraActivatedToggleList;

	private static AuroraManagerSaveDataProxy m_AuroraManagerSaveDataProxy;

	private static AuroraFieldsSceneManager m_AuroraFieldsSceneManager;

	private static NativeArray<float4> m_AuroraElectrolizerPosArray;

	private static NativeArray<float4> m_AuroraElectrolizerFreqArray;

	private static NativeArray<float4> m_AuroraElectrolizerTimerArray;

	private static NativeArray<float> m_AuroraElectrolizerMaxDistSqr;

	private static NativeArray<float> m_AuroraElectrolizerCurDistSqr;

	private static NativeArray<byte> m_AuroraElectrolizerShouldBeEnabled;

	private static float m_PhiTimer;

	private static bool s_NativeArraySetup;

	private int m_NumFramesNotActive;

	private bool m_StartHasBeenCalled;

	private uint m_AuroaAudioInstance;

	private float m_NormalizedActiveSentToWise;

	private float m_NormalizedActive;

	private bool m_ForceAuroraNextOpportunity;

	private bool m_ForceAuroraEarlyWindowAllowed;

	private bool m_ForceAuroraLateWindowAllowed;

	private float m_ForceAuroraDurationOverride;

	private bool m_IsDoingForceAurora;

	private bool m_HasForcedAuroraStarted;

	private bool m_IsFullyActive;

	private float m_ElectrolyzerFadeOutStartTime;

	private float m_ElectrolyzerFadeInStartTime;

	private int m_NumAurorasForSave;

	private bool m_BoostAuroraElectrolyzer;

	private float m_FarUpdateAccumulatedDeltaTime;

	private float m_FarElectrolyzerUpdateSqrDist;

	public int NumAuroras
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AuroraManager), Member = "GetForceDisableForNewGame")]
	public void Start()
	{
	}

	[Calls(Type = typeof(AuroraManager), Member = "DisposeNativeArrays")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateVisibility")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateActivation")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateAuroraAudio")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateColour")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CallsUnknownMethods(Count = 14)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AuroraManager), Member = "GetForceDisableForNewGame")]
	[Calls(Type = typeof(AuroraManager), Member = "GetForceDisableForNewGame")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateVisibility")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 7)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(AuroraField), Member = "Awake")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "RegisterAuroraField")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AuroraField), Member = "SetDynamic")]
	public static void RegisterAuroraField(AuroraField auroraField)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "UnRegisterAuroraField")]
	[CalledBy(Type = typeof(AuroraField), Member = "OnDestroy")]
	[CalledBy(Type = typeof(AuroraField), Member = "SetDynamic")]
	[CallsUnknownMethods(Count = 1)]
	public static void UnRegisterAuroraField(AuroraField auroraField)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsRegisteredAuroraField(AuroraField auroraField)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void RegisterAuroraGameObject(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "Awake")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	public static void RegisterAuroraElectrolizer(AuroraElectrolizer auroraElectrolizer)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public static void RegisterAuroraLightSimple(AuroraLightingSimple auroraLightSimple)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AuroraFieldsSceneManager GetAuroraFieldsSceneManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static List<AuroraElectrolizer> GetAuroraElectrolizerList()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterAuroraActivatedToggle(AuroraActivatedToggle auroraActivatedToggle)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static List<AuroraActivatedToggle> GetAuroraActivatedToggleList()
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(AuroraManager), Member = "OnDisable")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateVisibility")]
	[CallsUnknownMethods(Count = 12)]
	public static void DisposeNativeArrays()
	{
	}

	[CallerCount(Count = 52)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public bool AuroraIsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	public float GetSecondsBetweenFlyoverScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	public float GetWildlifeDetectionRangeScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	public float GetWildlifeFleeDistanceScale()
	{
		return default(float);
	}

	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallerCount(Count = 0)]
	public float GetDamageToPredatorsScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	public float GetPredatorInflictDamageScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	public float GetPredatorFleeChanceScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	public float GetPredatorAttackDistanceScale()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetNormalizedAlpha()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetNormalizedAlphaSquare()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void ForceAuroraNextOpportunity(bool earlyWindowAllowed, bool lateWindowAllowed, float durationOverride)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsFullyActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void BoostAurora(bool isBoostEnabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsAuroraBoostEnabled()
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[CallsUnknownMethods(Count = 71)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(AuroraManager), Member = "DisposeNativeArrays")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(JobHandle), Member = "Complete")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "SetLocationDistances")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "ManualUpdate")]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraElectrolyzerFadeRatio")]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "SetLocationDistances")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateElectrolyzerWithFarOptimization")]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraElectrolyzerFadeRatio")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "SetLocationDistances")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraElectrolyzerFadeRatio")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	private void UpdateAuroraElectrolizers()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void UpdateElectrolyzerWithFarOptimization(float distSqr, bool updateFarElectrolizersThisFrame, int i, float fadeRatio, float alpha, float4 timings, float priTimer, float deltaTime)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateActivation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AuroraField), Member = "OnAuroraDisabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraField), Member = "OnAuroraEnabled")]
	private void UpdateAuroraFields(bool active)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AuroraScreenManager), Member = "Reset")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateAuroraFields")]
	[Calls(Type = typeof(AuroraManager), Member = "OnFullyActiveStart")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "OnAuroraEnabled")]
	private void UpdateActivation()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateActivation")]
	[CallsUnknownMethods(Count = 27)]
	private void OnFullyActiveStart()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	public float GetAuroraElectrolyzerFadeRatio()
	{
		return default(float);
	}

	[Calls(Type = typeof(AuroraLightingSimple), Member = "StopAll")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(AuroraManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "StopAll")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetMaxAuroraIntensity")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(AuroraManager), Member = "DisposeNativeArrays")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallerCount(Count = 2)]
	private void UpdateVisibility(float deltaGameMinutes)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateUniStormAuroraLighting()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceNextWeatherStage")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(WeatherTransition), Member = "OverrideDurationOfStageInCurrentWeatherSet")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNightOrNightBlend")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsLateNightWindowForAuroraActivation")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsEarlyNightWindowForAuroraActivation")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void UpdateForceAurora()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "GetAuroraColourCorrected")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "GetAuroraColours")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(AuroraBand), Member = "UpdateColour")]
	[CalledBy(Type = typeof(AuroraBand), Member = "Update")]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "Update")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "GetAuroraColours")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateIntensities")]
	public Color GetAuroraColour()
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraColour")]
	public Color GetAuroraColourCorrected()
	{
		return default(Color);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "Initialize")]
	[Calls(Type = typeof(Color), Member = "HSVToRGB")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Color), Member = "RGBToHSVHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public Color GetRandomElectricalColor(bool randomSaturation = true, bool randomBrightness = true)
	{
		return default(Color);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetCinematicColours(bool useCineColours)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsUsingCinematicColours()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void UpdateColour()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateAuroraAudio()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	private void AuroraAudioStop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void AuroraAudioPlay()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void AuroraAudioSetIntensityRTPC()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AuroraManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(AuroraManager), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private bool GetForceDisableForNewGame()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "OnEnable")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 5)]
	public static void OnAuroraElectrolizerEnableChanged(AuroraElectrolizer a, bool isEnabled)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 42)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AuroraManager()
	{
	}
}
