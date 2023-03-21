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
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallerCount(Count = 0)]
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
		set
		{
		}
	}

	public RenderingMode actualRenderingMode
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
		get
		{
			return default(RenderingMode);
		}
	}

	public bool useSinglePassShader
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
		get
		{
			return default(bool);
		}
	}

	public bool requiresDoubleSidedMesh
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
		get
		{
			return default(bool);
		}
	}

	public Shader beamShader
	{
		[CallerCount(Count = 49)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public Transform fadeOutCameraTransform
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CalledBy(Type = typeof(BeamGeometry._003CCoUpdateFadeOut_003Ed__31), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	public bool hasRenderPipelineMismatch
	{
		[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public static Config Instance
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Config), Member = "GetInstance")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	public bool IsSRPBatcherSupported()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	public void ForceUpdateFadeOutCamera()
	{
	}

	[RuntimeInitializeOnLoadMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 3)]
	private static void OnStartup()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshGlobalShaderProperties()
	{
	}

	[Calls(Type = typeof(Resources), Member = "Load")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public void ResetInternalData()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "InstantiateParticleSystem")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public ParticleSystem NewVolumetricDustParticles()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 75)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 3)]
	private static Config GetInstance(bool assertIfNotFound)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public Config()
	{
	}
}
