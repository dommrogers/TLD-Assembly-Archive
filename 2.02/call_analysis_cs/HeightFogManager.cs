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
	[CallerCount(Count = 20)]
	public void SetGlobalVolume(HeightFogVolume volume)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void EnterVolume(HeightFogVolume volume)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public void ExitVolume(HeightFogVolume volume)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[Calls(Type = typeof(HeightFogVolume), Member = "GetBlendAmount")]
	[Calls(Type = typeof(HeightFogManager), Member = "ApplySettings")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Renderer), Member = "get_enabled")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(HeightFogSettings), Member = "IsFogVisible")]
	[Calls(Type = typeof(HeightFogSettings), Member = "ApplyLightSources")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(HeightFogSettings), Member = "Clear")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HeightFogSettings), Member = "Blend")]
	[CallsUnknownMethods(Count = 17)]
	public void Update()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(HeightFogManager), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
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
