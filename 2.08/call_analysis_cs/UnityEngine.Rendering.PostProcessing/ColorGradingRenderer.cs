using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.PostProcessing;

internal sealed class ColorGradingRenderer : PostProcessEffectRenderer<ColorGrading>
{
	private enum Pass
	{
		LutGenLDRFromScratch,
		LutGenLDR,
		LutGenHDR2D,
		LutGenBlendHDR2D
	}

	private Texture2D m_GradingCurves;

	private readonly Color[] m_Pixels;

	private RenderTexture m_InternalLdrLut;

	private RenderTexture m_InternalLogLut;

	private RenderTexture m_InternalBlendLut1A;

	private RenderTexture m_InternalBlendLut1B;

	private RenderTexture m_InternalBlendLut2A;

	private RenderTexture m_InternalBlendLut2B;

	private RenderTexture m_PainSettingsLut;

	private RenderTexture m_StimSettingsLut;

	private RenderTexture m_ElectrocutionSettingsLut;

	private RenderTexture m_BoostSettingsLut;

	private RenderTexture m_HeadacheSettingsLut;

	private RenderTexture m_SuffocationSettingsLut;

	private RenderTexture m_AuxSettingsLut;

	private const int k_Lut2DSize = 32;

	private const int k_Lut3DSize = 33;

	private readonly HableCurve m_HableCurve;

	private MaterialPropertyBlock m_Settings1AProperties;

	private MaterialPropertyBlock m_Settings1BProperties;

	private MaterialPropertyBlock m_Settings2AProperties;

	private MaterialPropertyBlock m_Settings2BProperties;

	private MaterialPropertyBlock m_PainSettingsProperties;

	private MaterialPropertyBlock m_StimSettingsProperties;

	private MaterialPropertyBlock m_ElectrocutionSettingsProperties;

	private MaterialPropertyBlock m_BoostSettingsProperties;

	private MaterialPropertyBlock m_HeadacheSettingsProperties;

	private MaterialPropertyBlock m_SuffocationSettingsProperties;

	private MaterialPropertyBlock m_AuxSettingsProperties;

	public static float s_Brightness;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private void RenderExternalPipeline3D(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "CheckInternalLogLut")]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(ColorUtilities), Member = "ComputeColorBalance")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "GetCurveTexture")]
	[Calls(Type = typeof(HableCurve), Member = "Init")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	private void RenderHDRPipeline3D(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(ColorUtilities), Member = "ComputeColorBalance")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "GetCurveTexture")]
	[Calls(Type = typeof(ColorGrading), Member = "GetBlendGammaForBrightness")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(HableCurve), Member = "Init")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsDeduplicatedMethods(Count = 28)]
	[CallsUnknownMethods(Count = 30)]
	private void RenderHDRPipeline2D(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(ColorGrading), Member = "GetBlendGammaForBrightness")]
	[Calls(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 48)]
	[CallsUnknownMethods(Count = 30)]
	private void RenderHDRBlendPipeline2D(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(ColorUtilities), Member = "ComputeColorBalance")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "GetCurveTexture")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 19)]
	private void RenderLDRPipeline2D(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "GetLutFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 11)]
	private void CheckInternalLogLut()
	{
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "GetLutFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	private void MaybeCreateLut(ref RenderTexture lut)
	{
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderLDRPipeline2D")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "MaybeCreateLut")]
	private void CheckInternalStripLut()
	{
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderLDRPipeline2D")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsTextureFormat")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private Texture2D GetCurveTexture(bool hdr)
	{
		return null;
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "GetLutFormat")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsRenderTextureFormatSupportedForLinearFiltering(RenderTextureFormat format)
	{
		return false;
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "CheckInternalLogLut")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "MaybeCreateLut")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "IsRenderTextureFormatSupportedForLinearFiltering")]
	private static RenderTextureFormat GetLutFormat()
	{
		return default(RenderTextureFormat);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsTextureFormat")]
	public static TextureFormat GetCurveFormat()
	{
		return default(TextureFormat);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	public override void Release()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HableCurve), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public ColorGradingRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
