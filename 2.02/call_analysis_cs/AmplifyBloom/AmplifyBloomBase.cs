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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float LensDirtStrength
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
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
		[CallerCount(Count = 1)]
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
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 5)]
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
			return default(float);
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
		[Calls(Type = typeof(AmplifyBloomBase), Member = "CleanTempFilterRT")]
		[CallerCount(Count = 0)]
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
			return default(bool);
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
			return default(float);
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
			return default(float);
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
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
			return default(float);
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
			return default(float);
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
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AmplifyBloomBase), Member = "CleanTempFilterRT")]
		set
		{
		}
	}

	public float TemporalFilteringValue
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
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
			return default(int);
		}
	}

	public int BloomDownsampleCount
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(int);
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
			return default(int);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public bool[] DownscaleSettingsFoldout
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public float[] UpscaleWeights
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
	}

	public AnimationCurve TemporalFilteringCurve
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
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
			return default(bool);
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
			return default(float);
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
			return default(bool);
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
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	public Texture MaskTexture
	{
		[CallerCount(Count = 29)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
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
			return default(bool);
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
			return default(bool);
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
			return default(bool);
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsUnknownMethods(Count = 55)]
	[Calls(Type = typeof(AmplifyUtils), Member = "DebugLog")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AmplifyUtils), Member = "DebugLog")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Material), Member = "GetTag")]
	[Calls(Type = typeof(AmplifyLensFlare), Member = "CreateLUTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 29)]
	[Calls(Type = typeof(AmplifyUtils), Member = "InitializeIds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(AmplifyGlare), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmplifyBokeh), Member = "Destroy")]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(RenderTexture), Member = "get_format")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseTempRenderTarget")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(RenderTexture), Member = "DiscardContents")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(RenderTexture), Member = "DiscardContents")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "CreateTempFilterRT")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "CleanTempFilterRT")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[Calls(Type = typeof(RenderTexture), Member = "get_format")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(RenderTexture), Member = "DiscardContents")]
	[Calls(Type = typeof(RenderTexture), Member = "DiscardContents")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(RenderTexture), Member = "DiscardContents")]
	[Calls(Type = typeof(AmplifyUtils), Member = "GetTempRenderTarget")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void ApplyGaussianBlur(RenderTexture renderTexture, int amount, float radius = 1f, bool applyTemporal = false)
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "ApplyGaussianBlur")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "CleanTempFilterRT")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTexture), Member = "get_format")]
	private void CreateTempFilterRT(RenderTexture source)
	{
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "set_TemporalFilteringActive")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "set_CurrentPrecisionMode")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "CreateTempFilterRT")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "set_HighPrecision")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "ApplyGaussianBlur")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void CleanTempFilterRT()
	{
	}

	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseTempRenderTarget")]
	[Calls(Type = typeof(AmplifyBokeh), Member = "ApplyBokehFilter")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseAllRT")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(AmplifyGlare), Member = "OnRenderImage")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(AmplifyUtils), Member = "GetTempRenderTarget")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(AmplifyBokeh), Member = "ApplyBokehFilter")]
	[Calls(Type = typeof(AmplifyLensFlare), Member = "ApplyFlare")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "ApplyGaussianBlur")]
	[Calls(Type = typeof(AmplifyUtils), Member = "GetTempRenderTarget")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(AmplifyUtils), Member = "GetTempRenderTarget")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseTempRenderTarget")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "ApplyUpscale")]
	[CallsUnknownMethods(Count = 308)]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseAllRT")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "FinalComposition")]
	[Calls(Type = typeof(RenderTexture), Member = "DiscardContents")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "SetMatrix")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "ApplyUpscale")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "FinalComposition")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "ApplyGaussianBlur")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "ApplyGaussianBlur")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(Material), Member = "SetColorImpl")]
	[Calls(Type = typeof(Vector3), Member = "Cross")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "Dot")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(Material), Member = "SetColorImpl")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(AmplifyUtils), Member = "EnsureKeywordEnabled")]
	[Calls(Type = typeof(AmplifyUtils), Member = "EnsureKeywordEnabled")]
	[Calls(Type = typeof(AmplifyUtils), Member = "EnsureKeywordEnabled")]
	[Calls(Type = typeof(AmplifyUtils), Member = "InitializeIds")]
	[CallsDeduplicatedMethods(Count = 42)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmplifyUtils), Member = "EnsureKeywordEnabled")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(Material), Member = "SetColorImpl")]
	[Calls(Type = typeof(AmplifyUtils), Member = "GetTempRenderTarget")]
	[Calls(Type = typeof(RenderTexture), Member = "DiscardContents")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "CreateTempFilterRT")]
	[Calls(Type = typeof(AmplifyBloomBase), Member = "CleanTempFilterRT")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetRenderTextureFormat")]
	[Calls(Type = typeof(RenderTexture), Member = "get_graphicsFormat")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetRenderTextureFormat")]
	[Calls(Type = typeof(Material), Member = "SetColorImpl")]
	[Calls(Type = typeof(RenderTexture), Member = "get_graphicsFormat")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(AmplifyUtils), Member = "GetTempRenderTarget")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseAllRT")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CallerCount(Count = 2)]
	private void FinalComposition(float srcContribution, float upscaleContribution, RenderTexture src, RenderTexture dest, int forcePassId)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AmplifyUtils), Member = "GetTempRenderTarget")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CallsUnknownMethods(Count = 26)]
	private void ApplyUpscale()
	{
	}

	[CalledBy(Type = typeof(AmplifyBloomEffect), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AmplifyLensFlare), Member = ".ctor")]
	[Calls(Type = typeof(AmplifyGlare), Member = ".ctor")]
	[Calls(Type = typeof(AmplifyBokeh), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 21)]
	public AmplifyBloomBase()
	{
	}
}
