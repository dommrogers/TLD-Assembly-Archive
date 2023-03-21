using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public sealed class RLPRO_SRP_LowRes_Renderer : PostProcessEffectRenderer<RLProLowRes>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsUnknownMethods(Count = 12)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public RLPRO_SRP_LowRes_Renderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
