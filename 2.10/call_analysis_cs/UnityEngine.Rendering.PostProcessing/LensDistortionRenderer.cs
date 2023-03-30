using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal sealed class LensDistortionRenderer : PostProcessEffectRenderer<LensDistortion>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	public LensDistortionRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
