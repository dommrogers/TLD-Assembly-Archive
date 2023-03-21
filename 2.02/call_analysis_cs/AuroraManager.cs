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
			return 0;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "GetForceDisableForNewGame")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "DisposeNativeArrays")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateVisibility")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateActivation")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateAuroraAudio")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateColour")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraManager), Member = "GetForceDisableForNewGame")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateVisibility")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(AuroraField), Member = "Awake")]
	[CalledBy(Type = typeof(AuroraField), Member = "SetDynamic")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "RegisterAuroraField")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterAuroraField(AuroraField auroraField)
	{
	}

	[CalledBy(Type = typeof(AuroraField), Member = "OnDestroy")]
	[CalledBy(Type = typeof(AuroraField), Member = "SetDynamic")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "UnRegisterAuroraField")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void UnRegisterAuroraField(AuroraField auroraField)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsRegisteredAuroraField(AuroraField auroraField)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterAuroraGameObject(GameObject go)
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 18)]
	public static void RegisterAuroraElectrolizer(AuroraElectrolizer auroraElectrolizer)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 4)]
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
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CallerCount(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "OnDisable")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateVisibility")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	public static void DisposeNativeArrays()
	{
	}

	[CallerCount(Count = 52)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool AuroraIsActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	public float GetSecondsBetweenFlyoverScale()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	public float GetWildlifeDetectionRangeScale()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	public float GetWildlifeFleeDistanceScale()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	public float GetDamageToPredatorsScale()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	public float GetPredatorInflictDamageScale()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	public float GetPredatorFleeChanceScale()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	public float GetPredatorAttackDistanceScale()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetNormalizedAlpha()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetNormalizedAlphaSquare()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void ForceAuroraNextOpportunity(bool earlyWindowAllowed, bool lateWindowAllowed, float durationOverride)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsFullyActive()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void BoostAurora(bool isBoostEnabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsAuroraBoostEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(AuroraManager), Member = "DisposeNativeArrays")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(JobHandle), Member = "Complete")]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraElectrolyzerFadeRatio")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "SetLocationDistances")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateElectrolyzerWithFarOptimization")]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "SetLocationDistances")]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "ManualUpdate")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 71)]
	private void UpdateAuroraElectrolizers()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 22)]
	private void UpdateElectrolyzerWithFarOptimization(float distSqr, bool updateFarElectrolizersThisFrame, int i, float fadeRatio, float alpha, float4 timings, float priTimer, float deltaTime)
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateActivation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraField), Member = "OnAuroraDisabled")]
	[Calls(Type = typeof(AuroraField), Member = "OnAuroraEnabled")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateAuroraFields(bool active)
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AuroraManager), Member = "OnFullyActiveStart")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateAuroraFields")]
	[Calls(Type = typeof(SpawnRegion), Member = "OnAuroraEnabled")]
	[Calls(Type = typeof(AuroraScreenManager), Member = "Reset")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateActivation()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateActivation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 27)]
	private void OnFullyActiveStart()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public float GetAuroraElectrolyzerFadeRatio()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[CalledBy(Type = typeof(AuroraManager), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuroraManager), Member = "DisposeNativeArrays")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetMaxAuroraIntensity")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "StopAll")]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "StopAll")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateVisibility(float deltaGameMinutes)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateUniStormAuroraLighting()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsEarlyNightWindowForAuroraActivation")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsLateNightWindowForAuroraActivation")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNightOrNightBlend")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(WeatherTransition), Member = "OverrideDurationOfStageInCurrentWeatherSet")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceNextWeatherStage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateForceAurora()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateIntensities")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "GetAuroraColours")]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "Update")]
	[CalledBy(Type = typeof(AuroraBand), Member = "Update")]
	[CalledBy(Type = typeof(AuroraBand), Member = "UpdateColour")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "GetAuroraColours")]
	[CalledBy(Type = typeof(AuroraManager), Member = "GetAuroraColourCorrected")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
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

	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color), Member = "RGBToHSVHelper")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Color), Member = "HSVToRGB")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
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
		return false;
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateColour()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateAuroraAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void AuroraAudioStop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void AuroraAudioPlay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void AuroraAudioSetIntensityRTPC()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "Start")]
	[CalledBy(Type = typeof(AuroraManager), Member = "Deserialize")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool GetForceDisableForNewGame()
	{
		return false;
	}

	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "OnEnable")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "OnDisable")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static void OnAuroraElectrolizerEnableChanged(AuroraElectrolizer a, bool isEnabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 42)]
	public AuroraManager()
	{
	}
}
