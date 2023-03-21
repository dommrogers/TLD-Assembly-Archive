using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public sealed class Glitch2Renderer : PostProcessEffectRenderer<RLProGlitch2>
{
	private float T;

	private RenderTexture _trashFrame1;

	private RenderTexture _trashFrame2;

	private Texture2D _noiseTexture;

	private RenderTexture trashFrame;

	[Calls(Type = typeof(Shader), Member = "Find")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(Glitch2Renderer), Member = "UpdateNoiseTexture")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(Glitch2Renderer), Member = "UpdateNoiseTexture")]
	[Calls(Type = typeof(Glitch2Renderer), Member = "SetUpResources")]
	[Calls(Type = typeof(Glitch2Renderer), Member = "SetUpResources")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(Glitch2Renderer), Member = "Render")]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "Render")]
	[Calls(Type = typeof(Glitch2Renderer), Member = "UpdateNoiseTexture")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Texture), Member = "set_filterMode")]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	private void SetUpResources(float g_2Res)
	{
	}

	[CalledBy(Type = typeof(Glitch2Renderer), Member = "Render")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "SetUpResources")]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "Render")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Glitch2Renderer), Member = "RandomColor")]
	[Calls(Type = typeof(Glitch2Renderer), Member = "RandomColor")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void UpdateNoiseTexture(float g_2Res)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "UpdateNoiseTexture")]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "UpdateNoiseTexture")]
	[CallsUnknownMethods(Count = 4)]
	private static Color RandomColor()
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	public Glitch2Renderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
