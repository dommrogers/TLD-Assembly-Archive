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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyColormapToMaterial")]
	[Calls(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyMaterialVariables")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "Render")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void ApplyMaterialVariables(MaterialPropertyBlock bl)
	{
	}

	[CalledBy(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "Render")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyPalette")]
	[Calls(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyMap")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyColormapToMaterial(MaterialPropertyBlock bl)
	{
	}

	[CalledBy(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyColormapToMaterial")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void ApplyPalette(MaterialPropertyBlock bl)
	{
	}

	[CalledBy(Type = typeof(RLPRO_SRP_ColormapPaletteRenderer), Member = "ApplyColormapToMaterial")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture3D), Member = ".ctor")]
	[Calls(Type = typeof(Texture3D), Member = "Apply")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void ApplyMap(MaterialPropertyBlock bl)
	{
	}

	[CallerCount(Count = 0)]
	public bool intHasChanged(int A, int B)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public RLPRO_SRP_ColormapPaletteRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
