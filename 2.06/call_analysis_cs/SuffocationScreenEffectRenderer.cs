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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "Find")]
	public override void Init()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsDeduplicatedMethods(Count = 4)]
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
