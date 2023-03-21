using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal sealed class VignetteRenderer : PostProcessEffectRenderer<Vignette>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[CallsUnknownMethods(Count = 31)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public VignetteRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
