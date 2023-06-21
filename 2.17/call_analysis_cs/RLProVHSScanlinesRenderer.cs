using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public sealed class RLProVHSScanlinesRenderer : PostProcessEffectRenderer<RLProVHSScanlines>
{
	private int pass;

	private float T;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	public RLProVHSScanlinesRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
