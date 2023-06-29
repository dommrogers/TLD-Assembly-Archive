using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public sealed class CinematicBars_Renderer : PostProcessEffectRenderer<RLProCinematicBars>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsUnknownMethods(Count = 1)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	public CinematicBars_Renderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
