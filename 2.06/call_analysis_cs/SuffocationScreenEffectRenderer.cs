using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public sealed class SuffocationScreenEffectRenderer : PostProcessEffectRenderer<SuffocationScreenEffect>
{
	private Shader m_Shader;

	private static readonly int s_IntensityPropertyID;

	private static readonly int s_PackedParametersPropertyID;

	private static readonly int s_NoiseScaleAndSpeedPropertyID;

	private static readonly int s_NoiseTexturePropertyID;

	private static readonly int s_BlurTexturePropertyID;

	[Calls(Type = typeof(Shader), Member = "Find")]
	[CallerCount(Count = 0)]
	public override void Init()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsUnknownMethods(Count = 4)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	public SuffocationScreenEffectRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
