using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class MeshBakerMaterialTexture
{
	private Texture2D _t;

	public float texelDensity;

	internal static bool readyToBuildAtlases;

	private DRect encapsulatingSamplingRect;

	private DRect _003CmatTilingRect_003Ek__BackingField;

	public Texture2D t
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	public DRect matTilingRect
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(DRect);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public bool isNull
	{
		[CalledBy(Type = typeof(MB3_TextureCombinerPackerRoot), Member = "CreateTemporaryTexturesForAtlas")]
		[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerRoot.<ConvertTexturesToReadableFormats>d__3", Member = "MoveNext")]
		[CalledBy(Type = typeof(MB_TexSet), Member = "GetMaxRawTextureHeightWidth")]
		[CalledBy(Type = typeof(MB_TexSet), Member = "CalcInitialFullSamplingRects")]
		[CalledBy(Type = typeof(MB_TexSet), Member = "CalcMatAndUVSamplingRects")]
		[CalledBy(Type = typeof(MB_TexSet), Member = "AllTexturesAreSameForMerge")]
		[CalledBy(Type = typeof(MB3_TextureCombinerMerging), Member = "MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPackerOneTextureInAtlas), Member = "CalculateAtlasRectangles")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "CalculateAllTexturesAreNullAndSameColor")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GenerateReport")]
		[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<CalculateIdealSizesForTexturesInAtlasAndPadding>d__10", Member = "MoveNext")]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public int width
	{
		[CalledBy(Type = typeof(MB_TexSet), Member = "GetMaxRawTextureHeightWidth")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPackerOneTextureInAtlas), Member = "CalculateAtlasRectangles")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GenerateReport")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GetAdjustedForScaleAndOffset2Dimensions")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Exception), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return 0;
		}
	}

	public int height
	{
		[CalledBy(Type = typeof(MB_TexSet), Member = "GetMaxRawTextureHeightWidth")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPackerOneTextureInAtlas), Member = "CalculateAtlasRectangles")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GenerateReport")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GetAdjustedForScaleAndOffset2Dimensions")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Exception), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return 0;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public MeshBakerMaterialTexture()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public MeshBakerMaterialTexture(Texture tx)
	{
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<__Step1_CollectDistinctMatTexturesAndUsedObjects>d__8", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public MeshBakerMaterialTexture(Texture tx, Vector2 matTilingOffset, Vector2 matTilingScale, float texelDens)
	{
	}

	[CallerCount(Count = 0)]
	public DRect GetEncapsulatingSamplingRect()
	{
		return default(DRect);
	}

	[CallerCount(Count = 0)]
	public void SetEncapsulatingSamplingRect(MB_TexSet ts, DRect r)
	{
	}

	[CalledBy(Type = typeof(MB_TextureCombinerRenderTexture), Member = "OnRenderObject")]
	[CalledBy(Type = typeof(MB_TextureCombinerRenderTexture), Member = "CopyScaledAndTiledToAtlas")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerRoot.<ConvertTexturesToReadableFormats>d__3", Member = "MoveNext")]
	[CalledBy(Type = typeof(MB_TexSet), Member = "CreateColoredTexToReplaceNull")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerMeshBaker.<CreateAtlases>d__0", Member = "MoveNext")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerMeshBaker.<CopyScaledAndTiledToAtlas>d__1", Member = "MoveNext")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerOneTextureInAtlas.<CreateAtlases>d__2", Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity), Member = "GetAdjustedForScaleAndOffset2")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerUnity.<CreateAtlases>d__1", Member = "MoveNext")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Texture2D GetTexture2D()
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerMerging), Member = "MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerMeshBaker.<CreateAtlases>d__0", Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GenerateReport")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GetAdjustedForScaleAndOffset2Dimensions")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<CalculateIdealSizesForTexturesInAtlasAndPadding>d__10", Member = "MoveNext")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetTexName()
	{
		return null;
	}

	[CalledBy(Type = typeof(MB_TexSet), Member = "IsEqual")]
	[CalledBy(Type = typeof(MB_TexSet), Member = "AllTexturesAreSameForMerge")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "CalculateAllTexturesAreNullAndSameColor")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool AreTexturesEqual(MeshBakerMaterialTexture b)
	{
		return false;
	}
}
