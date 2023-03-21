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
	[DeduplicatedMethod]
	public override void Init()
	{
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyMaterialVariables")]
	[Calls(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyColormapToMaterial")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[CalledBy(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "Render")]
	[CallsUnknownMethods(Count = 29)]
	public void ApplyMaterialVariables(MaterialPropertyBlock bl)
	{
	}

	[Calls(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyPalette")]
	[CalledBy(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "Render")]
	[Calls(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyMap")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void ApplyColormapToMaterial(MaterialPropertyBlock bl)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyColormapToMaterial")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void ApplyPalette(MaterialPropertyBlock bl)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Texture3D), Member = ".ctor")]
	[Calls(Type = typeof(Texture3D), Member = "Apply")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyColormapToMaterial")]
	[CallsUnknownMethods(Count = 22)]
	public void ApplyMap(MaterialPropertyBlock bl)
	{
	}

	[CallerCount(Count = 0)]
	public bool intHasChanged(int A, int B)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RLPRO_SRP_ColormapPaletteRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
