using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HeightFogManager : MonoBehaviour
{
	private MeshRenderer m_Renderer;

	private Material m_NoNoiseMaterial;

	private Material m_WithNoiseMaterial;

	private HeightFogVolume m_GlobalVolume;

	private List<HeightFogVolume> m_ActiveVolumes;

	private HeightFogSettings m_CurrentSettings;

	private MaterialPropertyBlock m_PropertyBlock;

	private static readonly int s_FogColorID;

	private static readonly int s_FogDensityID;

	private static readonly int s_FogPowerID;

	private static readonly int s_FogDistanceStartID;

	private static readonly int s_FogDistanceEndID;

	private static readonly int s_FogDistanceFalloffID;

	private static readonly int s_FogHeightStartID;

	private static readonly int s_FogHeightEndID;

	private static readonly int s_FogHeightFalloffID;

	private static readonly int s_NoiseStrengthID;

	private static readonly int s_NoiseScaleID;

	private static readonly int s_NoiseSpeedID;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnQualityChange(QualityPostFx quality)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 21)]
	public void SetGlobalVolume(HeightFogVolume volume)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public void EnterVolume(HeightFogVolume volume)
	{
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void ExitVolume(HeightFogVolume volume)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(HeightFogManager), Member = "ApplySettings")]
	[Calls(Type = typeof(HeightFogSettings), Member = "IsFogVisible")]
	[Calls(Type = typeof(HeightFogSettings), Member = "ApplyLightSources")]
	[Calls(Type = typeof(HeightFogSettings), Member = "Blend")]
	[Calls(Type = typeof(HeightFogVolume), Member = "GetBlendAmount")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(HeightFogSettings), Member = "Clear")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(HeightFogManager), Member = "Update")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	private void ApplySettings(HeightFogSettings settings)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public HeightFogManager()
	{
	}
}
