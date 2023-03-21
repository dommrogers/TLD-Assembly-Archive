using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal sealed class LensDistortionRenderer : PostProcessEffectRenderer<LensDistortion>
{
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public LensDistortionRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
