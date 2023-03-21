using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public sealed class SuffocationScreenEffectRenderer : PostProcessEffectRenderer<SuffocationScreenEffect>
{
	private Shader m_Shader;

	private static readonly int s_IntensityPropertyID;

	private static readonly int s_PackedParametersPropertyID;

	private static readonly int s_NoiseScaleAndSpeedPropertyID;

	private static readonly int s_NoiseTexturePropertyID;

	private static readonly int s_BlurTexturePropertyID;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void Init()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SuffocationScreenEffectRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
