using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public class Config : ScriptableObject
{
	public bool geometryOverrideLayer;

	public int geometryLayerID;

	public string geometryTag;

	public int geometryRenderQueue;

	private RenderPipeline _RenderPipeline;

	private RenderingMode _RenderingMode;

	public float ditheringFactor;

	public int sharedMeshSides;

	public int sharedMeshSegments;

	public float globalNoiseScale;

	public Vector3 globalNoiseVelocity;

	public string fadeOutCameraTag;

	public TextAsset noise3DData;

	public int noise3DSize;

	public ParticleSystem dustParticlesPrefab;

	public Texture2D ditheringNoiseTexture;

	public FeatureEnabledColorGradient featureEnabledColorGradient;

	public bool featureEnabledDepthBlend;

	public bool featureEnabledNoise3D;

	public bool featureEnabledDynamicOcclusion;

	public bool featureEnabledMeshSkewing;

	public bool featureEnabledShaderAccuracyHigh;

	private int pluginVersion;

	private Material _DummyMaterial;

	private Shader _BeamShader;

	private Transform m_CachedFadeOutCamera;

	private static Config ms_Instance;

	public RenderPipeline renderPipeline
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(RenderPipeline);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public RenderingMode renderingMode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(RenderingMode);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public RenderingMode actualRenderingMode
	{
		[CalledBy(Type = typeof(BatchingHelper), Member = "get_forceEnableDepthBlend")]
		[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
		[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "get_shouldUseGPUInstancedMaterial")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "RegenerateMesh")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMatricesPropertiesForGPUInstancingSRP")]
		[CalledBy(Type = typeof(Config), Member = "get_useSinglePassShader")]
		[CalledBy(Type = typeof(Config), Member = "get_requiresDoubleSidedMesh")]
		[CalledBy(Type = typeof(GlobalMesh), Member = "Get")]
		[CalledBy(Type = typeof(MeshGenerator), Member = "GetSharedMeshVertexCount")]
		[CalledBy(Type = typeof(MeshGenerator), Member = "GetSharedMeshIndicesCount")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(RenderingMode);
		}
	}

	public bool useSinglePassShader
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Config), Member = "get_actualRenderingMode")]
		get
		{
			return false;
		}
	}

	public bool requiresDoubleSidedMesh
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Config), Member = "get_actualRenderingMode")]
		get
		{
			return false;
		}
	}

	public Shader beamShader
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public Transform fadeOutCameraTransform
	{
		[CalledBy(TypeFullName = "VLB.BeamGeometry.<CoUpdateFadeOut>d__31", Member = "MoveNext")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	public bool hasRenderPipelineMismatch
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public static Config Instance
	{
		[CallAnalysisFailed]
		[CallerCount(Count = 62)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsSRPBatcherSupported()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void ForceUpdateFadeOutCamera()
	{
	}

	[RuntimeInitializeOnLoadMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private static void OnStartup()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshGlobalShaderProperties()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void ResetInternalData()
	{
	}

	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "InstantiateParticleSystem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Consts), Member = "get_ProceduralObjectsHideFlags")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public ParticleSystem NewVolumetricDustParticles()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private static Config GetInstance(bool assertIfNotFound)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public Config()
	{
	}
}
