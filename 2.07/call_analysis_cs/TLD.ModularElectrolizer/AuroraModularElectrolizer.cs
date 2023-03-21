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
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		set
		{
		}
	}

	public DistanceFadeControl DistanceFadeControl
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
	}

	public bool ExternalPowerActive
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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

	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "MaybeSetupHighlightFog")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AuroraManager), Member = "RegisterAuroraElectrolizer")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "MaybeSetupHighlightFog")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Awake")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateEmissiveObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(DistanceFadeControl), Member = "SetLocationDistances")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "InitializeFlickerSet")]
	[Calls(Type = typeof(AuroraManager), Member = "GetRandomElectricalColor")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	private void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "UpdateFlickerTiming")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FlickerTimingControl), Member = "InitializeFlickerTiming")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void InitializeFlickerSet()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void JobUpdate(float camDistSqr, float auroraIntensity, float auroraDeltaTime)
	{
	}

	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "StopAll")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateElectrolyzerWithFarOptimization")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateEmissiveObjects")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "InitializeFlickerSet")]
	[Calls(Type = typeof(FlickerTimingControl), Member = "AdvanceFlickerTiming")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateIntensity")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "StopAll")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "HasActivePower")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateLight")]
	public void ManualUpdate(float camDistSqr, float auroraIntensity, float auroraDeltaTime)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "MaybeActivateHighlightFogObject")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 1)]
	private bool HasFieldPower()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateLight")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateEmissiveObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateElectrolizerState")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "OnDisable")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	public void StopAll()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "StopAll")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateLight(bool allOff = false)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "StopAll")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateEmissiveObjects(bool allOff = false)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	private void MaybeSetupHighlightFog()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "HasActivePower")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CallsUnknownMethods(Count = 4)]
	public void MaybeActivateHighlightFogObject()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void MaybeControlHightlightFogFade()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateAudio()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "InitializeFlickerSet")]
	[Calls(Type = typeof(FlickerTimingControl), Member = "AdvanceFlickerTiming")]
	[CallerCount(Count = 0)]
	private void UpdateFlickerTiming(float auroraDeltaTime)
	{
	}

	[CallerCount(Count = 0)]
	private bool HasFlickerSets()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public AuroraModularElectrolizer()
	{
	}
}
