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

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[CallsUnknownMethods(Count = 3)]
	private void RenderExternalPipeline3D(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "GetCurveTexture")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(HableCurve), Member = "Init")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(ColorUtilities), Member = "ComputeColorBalance")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "CheckInternalLogLut")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	private void RenderHDRPipeline3D(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(HableCurve), Member = "Init")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "GetCurveTexture")]
	[Calls(Type = typeof(ColorUtilities), Member = "ComputeColorBalance")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[CallsDeduplicatedMethods(Count = 28)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorGrading), Member = "GetBlendGammaForBrightness")]
	private void RenderHDRPipeline2D(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[CallsUnknownMethods(Count = 265)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Exp2")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(Vector4), Member = "op_Implicit")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[Calls(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "CreateImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "CreateImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "CreateImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "CreateImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "CreateImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "CreateImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "CreateImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "CreateImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "CreateImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "CreateImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "CreateImpl")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[CallsDeduplicatedMethods(Count = 53)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[Calls(Type = typeof(ColorGrading), Member = "GetBlendGammaForBrightness")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample")]
	[Calls(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorImpl")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	private void RenderHDRBlendPipeline2D(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 26)]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "GetCurveTexture")]
	[Calls(Type = typeof(ColorUtilities), Member = "ComputeColorBalance")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void RenderLDRPipeline2D(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "GetLutFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	private void CheckInternalLogLut()
	{
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "GetLutFormat")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "CheckInternalStripLut")]
	private void MaybeCreateLut(ref RenderTexture lut)
	{
	}

	[Calls(Type = typeof(ColorGradingRenderer), Member = "MaybeCreateLut")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderLDRPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "MaybeCreateLut")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "MaybeCreateLut")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "MaybeCreateLut")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "MaybeCreateLut")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "MaybeCreateLut")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "MaybeCreateLut")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "MaybeCreateLut")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "MaybeCreateLut")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "MaybeCreateLut")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "MaybeCreateLut")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "MaybeCreateLut")]
	[CallerCount(Count = 3)]
	private void CheckInternalStripLut()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderLDRPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsTextureFormat")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "set_name")]
	private Texture2D GetCurveTexture(bool hdr)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "GetLutFormat")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "GetLutFormat")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool IsRenderTextureFormatSupportedForLinearFiltering(RenderTextureFormat format)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "MaybeCreateLut")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "IsRenderTextureFormatSupportedForLinearFiltering")]
	[Calls(Type = typeof(ColorGradingRenderer), Member = "IsRenderTextureFormatSupportedForLinearFiltering")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "CheckInternalLogLut")]
	private static RenderTextureFormat GetLutFormat()
	{
		return default(RenderTextureFormat);
	}

	[Calls(Type = typeof(SystemInfo), Member = "SupportsTextureFormat")]
	[CallerCount(Count = 0)]
	public static TextureFormat GetCurveFormat()
	{
		return default(TextureFormat);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	public override void Release()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HableCurve), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public ColorGradingRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
