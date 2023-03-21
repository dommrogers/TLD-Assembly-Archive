using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.ModularElectrolizer;

public class AuroraModularElectrolizer : MonoBehaviour
{
	public ActivationParameters m_ActivationParameters;

	public bool m_RequiresAuroraField;

	public bool m_RequiresExternalPower;

	public List<Light> m_LocalLights;

	public List<Renderer> m_EmissiveObjects;

	public HighlightFog m_HighlightFogObject;

	public AK.Wwise.Event m_AudioEvent;

	public IntensityParameters m_IntensityParameters;

	public List<FlickerModuleSet> m_FlickerSet;

	public DistanceParameters m_OutdoorDistance;

	public DistanceParameters m_IndoorDistance;

	[NonSerialized]
	public bool m_PrintDebugToScreen;

	[NonSerialized]
	public bool m_IndependentUpdate;

	[NonSerialized]
	public bool m_UseAuroraStrengthOverride;

	[NonSerialized]
	public float m_AuroraStrengthOverride;

	private const bool IS_CONSOLE = false;

	private const bool ALLOW_EDITOR_OVERRIDES = false;

	private float _CamDist;

	private float m_ActivationThreshold;

	private float m_StableThreshold;

	private List<float> m_LocalLightsIntensities;

	private Color m_LocalColor;

	private uint m_AudioInstanceID;

	private FlickerTimingControl m_FlickerTimingControl;

	private DistanceFadeControl m_DistanceFadeControl;

	private AuroraField m_ActiveAuroraField;

	private float m_AuroraFadeIntensity;

	private float m_OutputIntensity;

	private float m_IntensitySentToWise;

	private float m_FlickerModuleDuration;

	private bool m_IsInitialized;

	private bool m_ExternalPowerActive;

	private bool m_HasStopped;

	private bool m_DoUpdate;

	private HashSet<Renderer> m_Renderers;

	private MaterialPropertyBlock m_EmissivePropertyBlock;

	private Shader m_EmissiveShader;

	private static readonly int s_EmissiveStrengthPropertyID;

	private static readonly int s_EmissiveTintPropertyID;

	public float ActivationThreshold
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	public float StableThreshold
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	public bool HasStopped
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public AuroraField ActiveAuroraField
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public DistanceFadeControl DistanceFadeControl
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
	}

	public bool ExternalPowerActive
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "OnAuroraElectrolizerEnableChanged")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "StopAll")]
	[Calls(Type = typeof(AuroraManager), Member = "OnAuroraElectrolizerEnableChanged")]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(AuroraManager), Member = "RegisterAuroraElectrolizer")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "MaybeSetupHighlightFog")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 67)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Awake")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "MaybeSetupHighlightFog")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateEmissiveObjects")]
	[Calls(Type = typeof(DistanceFadeControl), Member = "SetLocationDistances")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateLight")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "InitializeFlickerSet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(AuroraManager), Member = "GetRandomElectricalColor")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	private void Initialize()
	{
	}

	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "UpdateFlickerTiming")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(FlickerTimingControl), Member = "InitializeFlickerTiming")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private void InitializeFlickerSet()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void JobUpdate(float camDistSqr, float auroraIntensity, float auroraDeltaTime)
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "StopAll")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateAudio")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateEmissiveObjects")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateLight")]
	[Calls(Type = typeof(FlickerTimingControl), Member = "AdvanceFlickerTiming")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateElectrolyzerWithFarOptimization")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateIntensity")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "StopAll")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "HasActivePower")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "InitializeFlickerSet")]
	[CallsUnknownMethods(Count = 2)]
	public void ManualUpdate(float camDistSqr, float auroraIntensity, float auroraDeltaTime)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "MaybeActivateHighlightFogObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private bool HasActivePower()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private bool HasExternalPower()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	private bool HasFieldPower()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "OnDisable")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateElectrolizerState")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateEmissiveObjects")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateLight")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void StopAll()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopAudio()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FlickerModuleSet), Member = "ProcessIntensity")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateIntensity(float distanceFade, float auroraIntensity)
	{
	}

	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "StopAll")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	private void UpdateLight(bool allOff = false)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "StopAll")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	private void UpdateEmissiveObjects(bool allOff = false)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Awake")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeSetupHighlightFog()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "HasActivePower")]
	public void MaybeActivateHighlightFogObject()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public void MaybeControlHightlightFogFade()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	private void UpdateAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FlickerTimingControl), Member = "AdvanceFlickerTiming")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "InitializeFlickerSet")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateFlickerTiming(float auroraDeltaTime)
	{
	}

	[CallerCount(Count = 0)]
	private bool HasFlickerSets()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AuroraModularElectrolizer()
	{
	}
}
