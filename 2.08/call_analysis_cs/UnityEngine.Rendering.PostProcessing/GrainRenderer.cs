using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal sealed class GrainRenderer : PostProcessEffectRenderer<Grain>
{
	private RenderTexture m_GrainLookupRT;

	private const int k_SampleCount = 1024;

	private int m_SampleIndex;

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[CallerCount(Count = 0)]
	private RenderTextureFormat GetLookupFormat()
	{
		return default(RenderTextureFormat);
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallerCount(Count = 0)]
	public override void Release()
	{
	}

	[CallerCount(Count = 0)]
	public GrainRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
