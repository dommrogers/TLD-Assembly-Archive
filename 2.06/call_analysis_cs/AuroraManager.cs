using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.ModularElectrolizer;
using TLD.Serialization;
using TLD.UI.Generics;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;

public class AuroraManager : MonoBehaviour
{
	private PanelReference<Panel_Loading> m_Loading;

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

	private Vector4 m_ColorTimers;

	public Gradient m_ElectricalColors;

	public MinMax m_ElectricalSaturation;

	public MinMax m_ElectricalValue;

	public float m_FarElectrolyzer_HalfUpdateRate_Radius;

	private float m_SpeedPercentage;

	private float m_FullyActiveValue;

	private static List<GameObject> m_AuroraGameObjectList;

	private static List<AuroraModularElectrolizer> m_AuroraElectrolizerList;

	private static List<int> m_AuroraElectrolizerFrameUpdatedList;

	private static List<bool> m_AuroraElectrolizerEnabledList;

	private static List<Vector3> m_AuroraElectrolizerPosList;

	private static List<AuroraLightingSimple> m_AuroraLightSimpleList;

	private static List<Vector3> m_AuroraLightSimplePosList;

	private static List<AuroraActivatedToggle> m_AuroraActivatedToggleList;

	private static AuroraManagerSaveDataProxy m_AuroraManagerSaveDataProxy;

	private static AuroraFieldsSceneManager m_AuroraFieldsSceneManager;

	private static NativeArray<float4> m_AuroraElectrolizerPosArray;

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

	private int m_NumAurorasForSave;

	private bool m_BoostAuroraElectrolyzer;

	private float m_FarUpdateAccumulatedDeltaTime;

	private float m_FarElectrolyzerUpdateSqrDist;

	private bool m_IsElectrolizerActive;

	public int NumAuroras
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "GetForceDisableForNewGame")]
	public void Start()
	{
	}

	[Calls(Type = typeof(AuroraManager), Member = "DisposeNativeArrays")]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateAuroraValue")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateElectrolizerState")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateActivation")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateAuroraAudio")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateColour")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AuroraManager), Member = "GetForceDisableForNewGame")]
	[Calls(Type = typeof(AuroraManager), Member = "GetForceDisableForNewGame")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateAuroraValue")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateElectrolizerState")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AuroraField), Member = "Awake")]
	[CalledBy(Type = typeof(AuroraField), Member = "SetDynamic")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "RegisterAuroraField")]
	public static void RegisterAuroraField(AuroraField auroraField)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeGetGuidFromGameObject")]
	[CalledBy(Type = typeof(AuroraField), Member = "OnDestroy")]
	[CalledBy(Type = typeof(AuroraField), Member = "SetDynamic")]
	[CallsUnknownMethods(Count = 3)]
	public static void UnRegisterAuroraField(AuroraField auroraField)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsRegisteredAuroraField(AuroraField auroraField)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void RegisterAuroraGameObject(GameObject go)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Awake")]
	[CallsUnknownMethods(Count = 6)]
	public static void RegisterAuroraElectrolizer(AuroraModularElectrolizer auroraElectrolizer)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public static void RegisterAuroraLightSimple(AuroraLightingSimple auroraLightSimple)
	{
	}

	[CallerCount(Count = 0)]
	public static AuroraFieldsSceneManager GetAuroraFieldsSceneManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static List<AuroraModularElectrolizer> GetAuroraElectrolizerList()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void RegisterAuroraActivatedToggle(AuroraActivatedToggle auroraActivatedToggle)
	{
	}

	[CallerCount(Count = 0)]
	public static List<AuroraActivatedToggle> GetAuroraActivatedToggleList()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 48)]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateElectrolizerState")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(AuroraManager), Member = "OnDisable")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	public static void DisposeNativeArrays()
	{
	}

	[CallerCount(Count = 26)]
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

	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void BoostAurora(bool isBoostEnabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsAuroraBoostEnabled()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "MaybeActivateHighlightFogObject")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateElectrolyzerWithFarOptimization")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[Calls(Type = typeof(DistanceFadeControl), Member = "SetLocationDistances")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "MaybeActivateHighlightFogObject")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "ManualUpdate")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(DistanceFadeControl), Member = "SetLocationDistances")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(AuroraManager), Member = "DisposeNativeArrays")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DistanceFadeControl), Member = "SetLocationDistances")]
	private void UpdateAuroraElectrolizers()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	private void UpdateElectrolyzerWithFarOptimization(float distSqr, bool updateFarElectrolizersThisFrame, int i, float alpha, float deltaTime)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AuroraScreenManager), Member = "Reset")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(SpawnRegion), Member = "OnAuroraEnabled")]
	[Calls(Type = typeof(AuroraField), Member = "OnAuroraDisabled")]
	[Calls(Type = typeof(AuroraField), Member = "OnAuroraEnabled")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateActivation()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetClearAuroraIntensity")]
	private void UpdateAuroraValue()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(AuroraManager), Member = "Deserialize")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "UpdateEmissiveObjects")]
	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "StopAll")]
	[Calls(Type = typeof(AuroraManager), Member = "DisposeNativeArrays")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "UpdateLight")]
	private void UpdateElectrolizerState()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateUniStormAuroraLighting()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceNextWeatherStage")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(WeatherTransition), Member = "OverrideDurationOfStageInCurrentWeatherSet")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsLateNightWindowForAuroraActivation")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsEarlyNightWindowForAuroraActivation")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNightOrNightBlend")]
	private void UpdateForceAurora()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AuroraManager), Member = "GetAuroraColourCorrected")]
	[CalledBy(Type = typeof(AuroraBand), Member = "UpdateColour")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "GetAuroraColours")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "GetAuroraColours")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateIntensities")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "Update")]
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
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Color), Member = "RGBToHSVHelper")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Color), Member = "HSVToRGB")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	public Color GetRandomElectricalColor(bool randomSaturation = true, bool randomBrightness = true)
	{
		return default(Color);
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void SetCinematicColours(bool useCineColours)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsUsingCinematicColours()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateColour()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	private void UpdateAuroraAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void AuroraAudioStop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void AuroraAudioPlay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void AuroraAudioSetIntensityRTPC()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(AuroraManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(AuroraManager), Member = "Start")]
	private bool GetForceDisableForNewGame()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "OnEnable")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 2)]
	public static void OnAuroraElectrolizerEnableChanged(AuroraModularElectrolizer a, bool isEnabled)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 31)]
	public AuroraManager()
	{
	}
}
