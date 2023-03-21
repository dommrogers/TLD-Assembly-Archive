using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class MB3_TextureCombinerMerging
{
	private bool _considerNonTextureProperties;

	private MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender;

	private bool fixOutOfBoundsUVs;

	public MB2_LogLevel LOG_LEVEL;

	private static bool LOG_LEVEL_TRACE_MERGE_MAT_SUBRECTS;

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MB3_UVTransformUtility), Member = "GetShiftTransformToFitBinA")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_copyAndAdjustUVsFromMesh")]
	public static Rect BuildTransformMeshUV2AtlasRect(bool considerMeshUVs, Rect _atlasRect, Rect _obUVRect, Rect _sourceMaterialTiling, Rect _encapsulatingRect)
	{
		return default(Rect);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline._003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Ed__8), Member = "MoveNext")]
	public MB3_TextureCombinerMerging(bool considerNonTextureProps, MB3_TextureCombinerNonTextureProperties resultMaterialTexBlender, bool fixObUVs, MB2_LogLevel logLevel)
	{
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline._003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Ed__8), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	public void MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects(List<MB_TexSet> distinctMaterialTextures)
	{
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MB2_TextureBakeResults), Member = "IsMeshAndMaterialRectEnclosedByAtlasRect")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Rect), Member = "ToString")]
	[Calls(Type = typeof(Rect), Member = "ToString")]
	[Calls(Type = typeof(Rect), Member = "ToString")]
	[Calls(Type = typeof(MB2_TextureBakeResults), Member = "IsMeshAndMaterialRectEnclosedByAtlasRect")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 51)]
	public void DoIntegrityCheckMergedEncapsulatingSamplingRects(List<MB_TexSet> distinctMaterialTextures)
	{
	}
}
