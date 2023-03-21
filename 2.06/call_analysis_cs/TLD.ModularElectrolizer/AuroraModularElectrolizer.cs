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
			return 0f;
		}
	}

	public float StableThreshold
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	public bool HasStopped
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public AuroraField ActiveAuroraField
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 10)]
		set
		{
		}
	}

	public DistanceFadeControl DistanceFadeControl
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "MaybeSetupHighlightFog")]
	[Calls(Type = typeof(AuroraManager), Member = "RegisterAuroraElectrolizer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AuroraManager), Member = "GetRandomElectricalColor")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "InitializeFlickerSet")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(DistanceFadeControl), Member = "SetLocationDistances")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateLight")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateEmissiveObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "MaybeSetupHighlightFog")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 66)]
	private void Initialize()
	{
	}

	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "UpdateFlickerTiming")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FlickerTimingControl), Member = "InitializeFlickerTiming")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void InitializeFlickerSet()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void JobUpdate(float camDistSqr, float auroraIntensity, float auroraDeltaTime)
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateElectrolyzerWithFarOptimization")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "HasActivePower")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "StopAll")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateIntensity")]
	[Calls(Type = typeof(FlickerTimingControl), Member = "AdvanceFlickerTiming")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "InitializeFlickerSet")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateLight")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateEmissiveObjects")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateAudio")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void ManualUpdate(float camDistSqr, float auroraIntensity, float auroraDeltaTime)
	{
	}

	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "MaybeActivateHighlightFogObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	private bool HasActivePower()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	private bool HasExternalPower()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	private bool HasFieldPower()
	{
		return false;
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateElectrolizerState")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "OnDisable")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateLight")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "UpdateEmissiveObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void StopAll()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopAudio()
	{
	}

	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FlickerModuleSet), Member = "ProcessIntensity")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateIntensity(float distanceFade, float auroraIntensity)
	{
	}

	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "StopAll")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateLight(bool allOff = false)
	{
	}

	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "StopAll")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HashSet<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 14)]
	private void UpdateEmissiveObjects(bool allOff = false)
	{
	}

	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Awake")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeSetupHighlightFog()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "HasActivePower")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void MaybeActivateHighlightFogObject()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public void MaybeControlHightlightFogFade()
	{
	}

	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FlickerTimingControl), Member = "AdvanceFlickerTiming")]
	[Calls(Type = typeof(AuroraModularElectrolizer), Member = "InitializeFlickerSet")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateFlickerTiming(float auroraDeltaTime)
	{
	}

	[CallerCount(Count = 0)]
	private bool HasFlickerSets()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public AuroraModularElectrolizer()
	{
	}
}
