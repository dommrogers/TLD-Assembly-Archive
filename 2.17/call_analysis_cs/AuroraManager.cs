using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.ModularElectrolizer;
using TLD.Serialization;
using TLD.UI.Generics;
using Unity.Collections;
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
			return 0;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "GetForceDisableForNewGame")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "DisposeNativeArrays")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateAuroraValue")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateElectrolizerState")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateActivation")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateColour")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateForceAurora")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "GetForceDisableForNewGame")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateAuroraValue")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateElectrolizerState")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(AuroraField), Member = "Awake")]
	[CalledBy(Type = typeof(AuroraField), Member = "SetDynamic")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "RegisterAuroraField")]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterAuroraField(AuroraField auroraField)
	{
	}

	[CalledBy(Type = typeof(AuroraField), Member = "OnDestroy")]
	[CalledBy(Type = typeof(AuroraField), Member = "SetDynamic")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeGetGuidFromGameObject")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void UnRegisterAuroraField(AuroraField auroraField)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsRegisteredAuroraField(AuroraField auroraField)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterAuroraGameObject(GameObject go)
	{
	}

	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Awake")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	public static void RegisterAuroraElectrolizer(AuroraModularElectrolizer auroraElectrolizer)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterAuroraActivatedToggle(AuroraActivatedToggle auroraActivatedToggle)
	{
	}

	[CallerCount(Count = 0)]
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
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateElectrolizerState")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static void DisposeNativeArrays()
	{
	}

	[CallerCount(Count = 28)]
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
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(AuroraManager), Member = "DisposeNativeArrays")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(DistanceFadeControl), Member = "SetLocationDistances")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "MaybeActivateHighlightFogObject")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateElectrolyzerWithFarOptimization")]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "ManualUpdate")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 36)]
	private void UpdateAuroraElectrolizers()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateElectrolyzerWithFarOptimization(float distSqr, bool updateFarElectrolizersThisFrame, int i, float alpha, float deltaTime)
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AuroraScreenManager), Member = "Reset")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(SpawnRegion), Member = "OnAuroraEnabled")]
	[Calls(Type = typeof(AuroraField), Member = "OnAuroraDisabled")]
	[Calls(Type = typeof(AuroraField), Member = "OnAuroraEnabled")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateActivation()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[CalledBy(Type = typeof(AuroraManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetClearAuroraIntensity")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAuroraValue()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "Update")]
	[CalledBy(Type = typeof(AuroraManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AuroraManager), Member = "DisposeNativeArrays")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "StopAll")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	private void UpdateElectrolizerState()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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
	private void UpdateForceAurora()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateIntensities")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "GetAuroraColours")]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "Update")]
	[CalledBy(Type = typeof(AuroraBand), Member = "UpdateColour")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "GetAuroraColours")]
	[CalledBy(Type = typeof(AuroraManager), Member = "GetAuroraColourCorrected")]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
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

	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color), Member = "RGBToHSVHelper")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Color), Member = "HSVToRGB")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public Color GetRandomElectricalColor(bool randomSaturation = true, bool randomBrightness = true)
	{
		return default(Color);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public void SetCinematicColours(bool useCineColours)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
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

	[CalledBy(Type = typeof(AuroraManager), Member = "Start")]
	[CalledBy(Type = typeof(AuroraManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private bool GetForceDisableForNewGame()
	{
		return false;
	}

	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "OnEnable")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "OnDisable")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void OnAuroraElectrolizerEnableChanged(AuroraModularElectrolizer a, bool isEnabled)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public AuroraManager()
	{
	}
}
