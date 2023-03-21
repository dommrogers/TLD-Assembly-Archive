using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public sealed class RLProArtefactsRenderer : PostProcessEffectRenderer<RLProArtefacts>
{
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void ParamSwitch(PropertySheet mat, bool paramValue, string paramName)
	{
	}

	[CallerCount(Count = 0)]
	public RLProArtefactsRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
