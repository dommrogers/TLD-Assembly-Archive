using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

internal sealed class MaskedBlurEffectRenderer : PostProcessEffectRenderer<MaskedBlurEffect>
{
	private enum Pass
	{
		CoCCalculation,
		CoCTemporalFilter,
		DownsampleAndPrefilter,
		BokehSmallKernel,
		BokehMediumKernel,
		BokehLargeKernel,
		BokehVeryLargeKernel,
		PostFilter,
		Combine,
		DebugOverlay
	}

	private Shader m_Shader;

	private int m_DepthTextureShaderId;

	private int m_DepthTextureBlendShaderId;

	private const int k_NumEyes = 2;

	private const int k_NumCoCHistoryTextures = 2;

	private readonly RenderTexture[][] m_CoCHistoryTextures;

	private int[] m_HistoryPingPong;

	private const float k_FilmHeight = 0.024f;

	[Calls(Type = typeof(Shader), Member = "Find")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public MaskedBlurEffectRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary)
	{
		return default(RenderTextureFormat);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private float CalculateMaxCoCRadius(int screenHeight)
	{
		return default(float);
	}

	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString")]
	private RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format)
	{
		return null;
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "PushDebugOverlay")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(MaskedBlurEffectRenderer), Member = "CheckHistory")]
	[Calls(Type = typeof(MaskedBlurEffectRenderer), Member = "CheckHistory")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_blackTexture")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override void Release()
	{
	}
}
