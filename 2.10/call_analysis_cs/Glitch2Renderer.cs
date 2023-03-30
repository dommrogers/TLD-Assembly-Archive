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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Glitch2Renderer), Member = "SetUpResources")]
	[Calls(Type = typeof(Glitch2Renderer), Member = "UpdateNoiseTexture")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(Glitch2Renderer), Member = "Render")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
	[Calls(Type = typeof(Texture), Member = "set_filterMode")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Glitch2Renderer), Member = "UpdateNoiseTexture")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void SetUpResources(float g_2Res)
	{
	}

	[CalledBy(Type = typeof(Glitch2Renderer), Member = "Render")]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "SetUpResources")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Glitch2Renderer), Member = "RandomColor")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateNoiseTexture(float g_2Res)
	{
	}

	[CalledBy(Type = typeof(Glitch2Renderer), Member = "UpdateNoiseTexture")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
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
