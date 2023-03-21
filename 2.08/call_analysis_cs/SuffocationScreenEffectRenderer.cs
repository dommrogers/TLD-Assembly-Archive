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
	[Calls(Type = typeof(Shader), Member = "Find")]
	public override void Init()
	{
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	public SuffocationScreenEffectRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
