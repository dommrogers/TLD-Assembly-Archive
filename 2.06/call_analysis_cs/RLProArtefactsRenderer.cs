using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public sealed class RLProArtefactsRenderer : PostProcessEffectRenderer<RLProArtefacts>
{
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void ParamSwitch(PropertySheet mat, bool paramValue, string paramName)
	{
	}

	[CallerCount(Count = 0)]
	public RLProArtefactsRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
