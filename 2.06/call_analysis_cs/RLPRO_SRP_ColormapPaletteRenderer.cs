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
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyMaterialVariables")]
	[Calls(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyMap")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyPalette")]
	[CallsUnknownMethods(Count = 3)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "Render")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void ApplyMaterialVariables(MaterialPropertyBlock bl)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyPalette")]
	[Calls(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyMap")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyColormapToMaterial(MaterialPropertyBlock bl)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyColormapToMaterial")]
	[CalledBy(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "Render")]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	private void ApplyPalette(MaterialPropertyBlock bl)
	{
	}

	[CalledBy(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "Render")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyColormapToMaterial")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture3D), Member = "Apply")]
	[Calls(Type = typeof(Texture3D), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
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
