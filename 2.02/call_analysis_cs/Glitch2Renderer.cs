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
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(Glitch2Renderer), Member = "UpdateNoiseTexture")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Glitch2Renderer), Member = "SetUpResources")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Glitch2Renderer), Member = "SetUpResources")]
	[Calls(Type = typeof(Glitch2Renderer), Member = "UpdateNoiseTexture")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "Render")]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "Render")]
	[Calls(Type = typeof(Glitch2Renderer), Member = "UpdateNoiseTexture")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture), Member = "set_filterMode")]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	private void SetUpResources(float g_2Res)
	{
	}

	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "SetUpResources")]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "Render")]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "Render")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Glitch2Renderer), Member = "RandomColor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Glitch2Renderer), Member = "RandomColor")]
	private void UpdateNoiseTexture(float g_2Res)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "UpdateNoiseTexture")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "UpdateNoiseTexture")]
	private static Color RandomColor()
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Glitch2Renderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
