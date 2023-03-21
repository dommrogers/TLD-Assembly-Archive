using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public sealed class RLPRO_SRP_ColormapPaletteRenderer : PostProcessEffectRenderer<RLProColormapPalette>
{
	public int tempPresetIndex;

	private bool m_Init;

	private Texture2D colormapPalette;

	private Texture3D colormapTexture;

	[CallerCount(Count = 0)]
	public override void Init()
	{
	}

	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyMaterialVariables")]
	[Calls(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyColormapToMaterial")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[CalledBy(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "Render")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	public void ApplyMaterialVariables(MaterialPropertyBlock bl)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyPalette")]
	[Calls(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyMap")]
	[CalledBy(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "Render")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyColormapToMaterial(MaterialPropertyBlock bl)
	{
	}

	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyColormapToMaterial")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	private void ApplyPalette(MaterialPropertyBlock bl)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyColormapToMaterial")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Texture3D), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture3D), Member = "Apply")]
	public void ApplyMap(MaterialPropertyBlock bl)
	{
	}

	[CallerCount(Count = 0)]
	public bool intHasChanged(int A, int B)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public RLPRO_SRP_ColormapPaletteRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
