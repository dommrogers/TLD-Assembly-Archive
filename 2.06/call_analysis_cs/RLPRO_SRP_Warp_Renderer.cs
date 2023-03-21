using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public sealed class RLPRO_SRP_Warp_Renderer : PostProcessEffectRenderer<RLProWarp>
{
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[CallerCount(Count = 0)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	public RLPRO_SRP_Warp_Renderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
