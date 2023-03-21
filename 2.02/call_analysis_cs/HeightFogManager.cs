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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnQualityChange(QualityPostFx quality)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 23)]
	public void SetGlobalVolume(HeightFogVolume volume)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void EnterVolume(HeightFogVolume volume)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ExitVolume(HeightFogVolume volume)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
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

	[CalledBy(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(HeightFogSettings), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(HeightFogVolume), Member = "GetBlendAmount")]
	[Calls(Type = typeof(HeightFogSettings), Member = "Blend")]
	[Calls(Type = typeof(HeightFogSettings), Member = "ApplyLightSources")]
	[Calls(Type = typeof(HeightFogSettings), Member = "IsFogVisible")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(Renderer), Member = "get_enabled")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(HeightFogManager), Member = "ApplySettings")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 17)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(HeightFogManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 32)]
	private void ApplySettings(HeightFogSettings settings)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HeightFogManager()
	{
	}
}
