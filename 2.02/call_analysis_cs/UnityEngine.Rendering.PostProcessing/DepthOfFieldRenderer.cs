using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal sealed class DepthOfFieldRenderer : PostProcessEffectRenderer<DepthOfField>
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

	private const int k_NumEyes = 2;

	private const int k_NumCoCHistoryTextures = 2;

	private readonly RenderTexture[][] m_CoCHistoryTextures;

	private int[] m_HistoryPingPong;

	private const float k_FilmHeight = 0.024f;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public DepthOfFieldRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary)
	{
		return default(RenderTextureFormat);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float CalculateMaxCoCRadius(int screenHeight)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format)
	{
		return null;
	}

	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "PushDebugOverlay")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[CallsUnknownMethods(Count = 52)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(DepthOfFieldRenderer), Member = "CheckHistory")]
	[Calls(Type = typeof(DepthOfFieldRenderer), Member = "CheckHistory")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(RenderTexture), Member = "ReleaseTemporary")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override void Release()
	{
	}
}
