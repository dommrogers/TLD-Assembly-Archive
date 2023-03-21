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
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
		get
		{
			return default(bool);
		}
	}

	public bool requiresDoubleSidedMesh
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
		get
		{
			return default(bool);
		}
	}

	public Shader beamShader
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
	}

	public Transform fadeOutCameraTransform
	{
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(BeamGeometry._003CCoUpdateFadeOut_003Ed__31), Member = "MoveNext")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
	}

	public bool hasRenderPipelineMismatch
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
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

	[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[RuntimeInitializeOnLoadMethod]
	private static void OnStartup()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Reset()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void RefreshGlobalShaderProperties()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	public void ResetInternalData()
	{
	}

	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "InstantiateParticleSystem")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 75)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	private static Config GetInstance(bool assertIfNotFound)
	{
		return null;
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Config()
	{
	}
}
