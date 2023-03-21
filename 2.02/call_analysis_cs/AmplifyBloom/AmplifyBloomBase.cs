using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace AmplifyBloom;

[Serializable]
public class AmplifyBloomBase : MonoBehaviour
{
	public const int MaxGhosts = 5;

	public const int MinDownscales = 1;

	public const int MaxDownscales = 6;

	public const int MaxGaussian = 8;

	private const float MaxDirtIntensity = 1f;

	private const float MaxStarburstIntensity = 1f;

	public Texture m_maskTexture;

	public RenderTexture m_targetTexture;

	public bool m_showDebugMessages;

	public int m_softMaxdownscales;

	public DebugToScreenEnum m_debugToScreen;

	public bool m_highPrecision;

	public Vector4 m_bloomRange;

	public float m_overallThreshold;

	public Vector4 m_bloomParams;

	public bool m_temporalFilteringActive;

	public float m_temporalFilteringValue;

	public int m_bloomDownsampleCount;

	public AnimationCurve m_temporalFilteringCurve;

	public bool m_separateFeaturesThreshold;

	public float m_featuresThreshold;

	public AmplifyLensFlare m_lensFlare;

	public bool m_applyLensDirt;

	public float m_lensDirtStrength;

	public Texture m_lensDirtTexture;

	public bool m_applyLensStardurst;

	public Texture m_lensStardurstTex;

	public float m_lensStarburstStrength;

	public AmplifyGlare m_anamorphicGlare;

	public AmplifyBokeh m_bokehFilter;

	public float[] m_upscaleWeights;

	public float[] m_gaussianRadius;

	public int[] m_gaussianSteps;

	public float[] m_lensDirtWeights;

	public float[] m_lensStarburstWeights;

	public bool[] m_downscaleSettingsFoldout;

	public int m_featuresSourceId;

	public UpscaleQualityEnum m_upscaleQuality;

	public MainThresholdSizeEnum m_mainThresholdSize;

	private Transform m_cameraTransform;

	private Matrix4x4 m_starburstMat;

	private Shader m_bloomShader;

	private Material m_bloomMaterial;

	private Shader m_finalCompositionShader;

	private Material m_finalCompositionMaterial;

	private RenderTexture m_tempFilterBuffer;

	private Camera m_camera;

	private RenderTexture[] m_tempUpscaleRTs;

	private RenderTexture[] m_tempAuxDownsampleRTs;

	private Vector2[] m_tempDownsamplesSizes;

	private bool silentError;

	public AmplifyGlare LensGlareInstance
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
	}

	public AmplifyBokeh BokehFilterInstance
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public AmplifyLensFlare LensFlareInstance
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		get
		{
			return null;
		}
	}

	public bool ApplyLensDirt
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float LensDirtStrength
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public Texture LensDirtTexture
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		set
		{
		}
	}

	public bool ApplyLensStardurst
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Texture LensStardurstTex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		set
		{
		}
	}

	public float LensStarburstStrength
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public PrecisionModes CurrentPrecisionMode
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(PrecisionModes);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AmplifyBloomBase), Member = "CleanTempFilterRT")]
		set
		{
		}
	}

	public bool HighPrecision
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AmplifyBloomBase), Member = "CleanTempFilterRT")]
		set
		{
		}
	}

	public float BloomRange
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float OverallThreshold
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public Vector4 BloomParams
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector4);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float OverallIntensity
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float BloomScale
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float UpscaleBlurRadius
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool TemporalFilteringActive
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AmplifyBloomBase), Member = "CleanTempFilterRT")]
		set
		{
		}
	}

	public float TemporalFilteringValue
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return 0f;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int SoftMaxdownscales
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
	}

	public int BloomDownsampleCount
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public int FeaturesSourceId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public bool[] DownscaleSettingsFoldout
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
	}

	public float[] UpscaleWeights
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public float[] LensDirtWeights
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public float[] LensStarburstWeights
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public float[] GaussianRadius
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public int[] GaussianSteps
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
	}

	public AnimationCurve TemporalFilteringCurve
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 19)]
		set
		{
		}
	}

	public bool SeparateFeaturesThreshold
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float FeaturesThreshold
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public DebugToScreenEnum DebugToScreen
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(DebugToScreenEnum);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public UpscaleQualityEnum UpscaleQuality
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(UpscaleQualityEnum);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool ShowDebugMessages
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public MainThresholdSizeEnum MainThresholdSize
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(MainThresholdSizeEnum);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public RenderTexture TargetTexture
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		set
		{
		}
	}

	public Texture MaskTexture
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		set
		{
		}
	}

	public bool ApplyBokehFilter
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public bool ApplyLensFlare
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public bool ApplyLensGlare
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmplifyUtils), Member = "InitializeIds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(AmplifyLensFlare), Member = "CreateLUTexture")]
	[Calls(Type = typeof(Material), Member = "GetTag")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(AmplifyUtils), Member = "DebugLog")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 28)]
	[CallsUnknownMethods(Count = 55)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmplifyBokeh), Member = "Destroy")]
	[Calls(Type = typeof(AmplifyGlare), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AmplifyUtils), Member = "GetTempRenderTarget")]
	[Calls(Type = typeof(RenderTexture), Member = "DiscardContents")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(RenderTexture), Member = "get_format")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "CleanTempFilterRT")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "CreateTempFilterRT")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseTempRenderTarget")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 13)]
	private void ApplyGaussianBlur(RenderTexture renderTexture, int amount, float radius = 1f, bool applyTemporal = false)
	{
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "ApplyGaussianBlur")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "CleanTempFilterRT")]
	[Calls(Type = typeof(RenderTexture), Member = "get_format")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 14)]
	private void CreateTempFilterRT(RenderTexture source)
	{
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "ApplyGaussianBlur")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "CreateTempFilterRT")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "set_CurrentPrecisionMode")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "set_HighPrecision")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "set_TemporalFilteringActive")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void CleanTempFilterRT()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmplifyUtils), Member = "InitializeIds")]
	[Calls(Type = typeof(AmplifyUtils), Member = "EnsureKeywordEnabled")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "Dot")]
	[Calls(Type = typeof(Vector3), Member = "Cross")]
	[Calls(Type = typeof(Material), Member = "SetColorImpl")]
	[Calls(Type = typeof(AmplifyUtils), Member = "GetTempRenderTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(RenderTexture), Member = "get_graphicsFormat")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetRenderTextureFormat")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "CleanTempFilterRT")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "CreateTempFilterRT")]
	[Calls(Type = typeof(RenderTexture), Member = "DiscardContents")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "ApplyGaussianBlur")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseTempRenderTarget")]
	[Calls(Type = typeof(AmplifyBokeh), Member = "ApplyBokehFilter")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseAllRT")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(AmplifyLensFlare), Member = "ApplyFlare")]
	[Calls(Type = typeof(AmplifyGlare), Member = "OnRenderImage")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "ApplyUpscale")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Material), Member = "SetMatrix")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "FinalComposition")]
	[CallsDeduplicatedMethods(Count = 42)]
	[CallsUnknownMethods(Count = 274)]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseAllRT")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void FinalComposition(float srcContribution, float upscaleContribution, RenderTexture src, RenderTexture dest, int forcePassId)
	{
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AmplifyUtils), Member = "GetTempRenderTarget")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 26)]
	private void ApplyUpscale()
	{
	}

	[CalledBy(Type = typeof(AmplifyBloomEffect), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AmplifyLensFlare), Member = ".ctor")]
	[Calls(Type = typeof(AmplifyGlare), Member = ".ctor")]
	[Calls(Type = typeof(AmplifyBokeh), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	public AmplifyBloomBase()
	{
	}
}
