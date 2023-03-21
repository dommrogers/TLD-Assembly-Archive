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
		[CallerCount(Count = 101)]
		[DeduplicatedMethod]
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
		[CalledBy(Type = typeof(MB_TexSet), Member = "CalcMatAndUVSamplingRects")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "CalculateAllTexturesAreNullAndSameColor")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GenerateReport")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPackerOneTextureInAtlas), Member = "CalculateAtlasRectangles")]
		[CalledBy(Type = typeof(MB_TexSet), Member = "AllTexturesAreSameForMerge")]
		[CalledBy(Type = typeof(MB_TexSet), Member = "CalcInitialFullSamplingRects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(MB_TexSet), Member = "GetMaxRawTextureHeightWidth")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPackerRoot._003CConvertTexturesToReadableFormats_003Ed__3), Member = "MoveNext")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPackerRoot), Member = "CreateTemporaryTexturesForAtlas")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallerCount(Count = 10)]
		[CalledBy(Type = typeof(MB_TexSet), Member = "CalcInitialFullSamplingRects")]
		get
		{
			return default(bool);
		}
	}

	public int width
	{
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GetAdjustedForScaleAndOffset2Dimensions")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GetAdjustedForScaleAndOffset2Dimensions")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GenerateReport")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPackerOneTextureInAtlas), Member = "CalculateAtlasRectangles")]
		[CalledBy(Type = typeof(MB_TexSet), Member = "GetMaxRawTextureHeightWidth")]
		[Calls(Type = typeof(Exception), Member = ".ctor")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(MB3_TextureCombinerPackerOneTextureInAtlas), Member = "CalculateAtlasRectangles")]
		get
		{
			return default(int);
		}
	}

	public int height
	{
		[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GenerateReport")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GetAdjustedForScaleAndOffset2Dimensions")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GetAdjustedForScaleAndOffset2Dimensions")]
		[CalledBy(Type = typeof(MB3_TextureCombinerPackerOneTextureInAtlas), Member = "CalculateAtlasRectangles")]
		[Calls(Type = typeof(Exception), Member = ".ctor")]
		[CalledBy(Type = typeof(MB_TexSet), Member = "GetMaxRawTextureHeightWidth")]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(MB3_TextureCombinerPackerOneTextureInAtlas), Member = "CalculateAtlasRectangles")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return default(int);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MeshBakerMaterialTexture()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public MeshBakerMaterialTexture(Texture tx)
	{
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline._003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Ed__8), Member = "MoveNext")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
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

	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBaker._003CCreateAtlases_003Ed__0), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity._003CCreateAtlases_003Ed__1), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity), Member = "GetAdjustedForScaleAndOffset2")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerOneTextureInAtlas._003CCreateAtlases_003Ed__2), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBaker._003CCopyScaledAndTiledToAtlas_003Ed__1), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB_TexSet), Member = "CreateColoredTexToReplaceNull")]
	[CalledBy(Type = typeof(MB_TextureCombinerRenderTexture), Member = "OnRenderObject")]
	[CalledBy(Type = typeof(MB_TextureCombinerRenderTexture), Member = "CopyScaledAndTiledToAtlas")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerRoot._003CConvertTexturesToReadableFormats_003Ed__3), Member = "MoveNext")]
	public Texture2D GetTexture2D()
	{
		return null;
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBaker._003CCreateAtlases_003Ed__0), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBaker._003CCreateAtlases_003Ed__0), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBaker._003CCreateAtlases_003Ed__0), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GenerateReport")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GetAdjustedForScaleAndOffset2Dimensions")]
	[CallsUnknownMethods(Count = 1)]
	public string GetTexName()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "CalculateAllTexturesAreNullAndSameColor")]
	[CalledBy(Type = typeof(MB_TexSet), Member = "AllTexturesAreSameForMerge")]
	[CalledBy(Type = typeof(MB_TexSet), Member = "AllTexturesAreSameForMerge")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(MB_TexSet), Member = "IsEqual")]
	public bool AreTexturesEqual(MeshBakerMaterialTexture b)
	{
		return default(bool);
	}
}
