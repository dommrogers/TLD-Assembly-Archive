using System;
using System.Collections.Generic;
using System.Text;
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

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_copyAndAdjustUVsFromMesh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MB3_UVTransformUtility), Member = "GetShiftTransformToFitBinA")]
	public static Rect BuildTransformMeshUV2AtlasRect(bool considerMeshUVs, Rect _atlasRect, Rect _obUVRect, Rect _sourceMaterialTiling, Rect _encapsulatingRect)
	{
		return default(Rect);
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<__Step1_CollectDistinctMatTexturesAndUsedObjects>d__8", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	public MB3_TextureCombinerMerging(bool considerNonTextureProps, MB3_TextureCombinerNonTextureProperties resultMaterialTexBlender, bool fixObUVs, MB2_LogLevel logLevel)
	{
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<__Step1_CollectDistinctMatTexturesAndUsedObjects>d__8", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_isNull")]
	[Calls(Type = typeof(DRect), Member = "Equals")]
	[Calls(Type = typeof(MB_TexSet), Member = "GetDescription")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(MB_TexSet), Member = "SetAllTexturesUseSameMatTilingTrue")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "GetTexName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(MB_TexSet), Member = "CalcInitialFullSamplingRects")]
	[Calls(Type = typeof(MB_TexSet), Member = "CalcMatAndUVSamplingRects")]
	[Calls(Type = typeof(MB_TexSet), Member = "AllTexturesAreSameForMerge")]
	[Calls(Type = typeof(MB3_UVTransformUtility), Member = "GetEncapsulatingRectShifted")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(MB_TexSet), Member = "SetEncapsulatingSamplingRectWhenMergingTexSets")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(MB3_TextureCombinerMerging), Member = "DoIntegrityCheckMergedEncapsulatingSamplingRects")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 148)]
	public void MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects(List<MB_TexSet> distinctMaterialTextures)
	{
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerMerging), Member = "MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MB2_TextureBakeResults), Member = "IsMeshAndMaterialRectEnclosedByAtlasRect")]
	[Calls(Type = typeof(Rect), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 51)]
	public void DoIntegrityCheckMergedEncapsulatingSamplingRects(List<MB_TexSet> distinctMaterialTextures)
	{
	}
}
