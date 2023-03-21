using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using DigitalOpus.MB.Core;
using UnityEngine;

public class MB2_TextureBakeResults : ScriptableObject
{
	public class Material2AtlasRectangleMapper
	{
		private MB2_TextureBakeResults tbr;

		private int[] numTimesMatAppearsInAtlas;

		private MB_MaterialAndUVRect[] matsAndSrcUVRect;

		[CallsUnknownMethods(Count = 30)]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObjects")]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		public Material2AtlasRectangleMapper(MB2_TextureBakeResults res)
		{
		}

		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
		[CallsUnknownMethods(Count = 60)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(MB2_TextureBakeResults), Member = "IsMeshAndMaterialRectEnclosedByAtlasRect")]
		[Calls(Type = typeof(Rect), Member = "ToString")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetUv0Raw")]
		[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(MB_Utility), Member = "hasOutOfBoundsUVs")]
		public bool TryMapMaterialToUVRect(Material mat, Mesh m, int submeshIdx, int idxInResultMats, MB3_MeshCombinerSingle.MeshChannelsCache meshChannelCache, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisCache, out MB_TextureTilingTreatment tilingTreatment, out Rect rectInAtlas, out Rect encapsulatingRectOut, out Rect sourceMaterialTilingOut, ref string errorMsg, MB2_LogLevel logLevel)
		{
			System.Runtime.CompilerServices.Unsafe.As<MB_TextureTilingTreatment, @null>(ref tilingTreatment) = null;
			System.Runtime.CompilerServices.Unsafe.As<Rect, @null>(ref rectInAtlas) = null;
			System.Runtime.CompilerServices.Unsafe.As<Rect, @null>(ref encapsulatingRectOut) = null;
			System.Runtime.CompilerServices.Unsafe.As<Rect, @null>(ref sourceMaterialTilingOut) = null;
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		private void UpgradeToCurrentVersion(MB2_TextureBakeResults tbr)
		{
		}
	}

	public int version;

	public MB_MaterialAndUVRect[] materialsAndUVRects;

	public MB_MultiMaterial[] resultMaterials;

	public bool doMultiMaterial;

	public static int VERSION
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public MB2_TextureBakeResults()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MB_MultiMaterial), Member = ".ctor")]
	[CallsUnknownMethods(Count = 83)]
	[CalledBy(Type = typeof(MB3_MeshCombiner), Member = "_CreateTemporaryTextrueBakeResult")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(MB_Utility), Member = "GetGOMaterials")]
	public static MB2_TextureBakeResults CreateForMaterialsOnRenderer(GameObject[] gos, List<Material> matsOnTargetRenderer)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallsUnknownMethods(Count = 3)]
	public bool DoAnyResultMatsUseConsiderMeshUVs()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public bool ContainsMaterial(Material m)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 43)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	public string GetDescription()
	{
		return null;
	}

	[Calls(Type = typeof(MB3_UVTransformUtility), Member = "LineSegmentContainsShifted")]
	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(MB3_TextureCombinerMerging), Member = "DoIntegrityCheckMergedEncapsulatingSamplingRects")]
	[CalledBy(Type = typeof(MB3_TextureCombinerMerging), Member = "DoIntegrityCheckMergedEncapsulatingSamplingRects")]
	[CalledBy(Type = typeof(Material2AtlasRectangleMapper), Member = "TryMapMaterialToUVRect")]
	[Calls(Type = typeof(MB3_UVTransformUtility), Member = "LineSegmentContainsShifted")]
	[Calls(Type = typeof(MB3_UVTransformUtility), Member = "RectContainsShifted")]
	[Calls(Type = typeof(Rect), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Rect), Member = "ToString")]
	[Calls(Type = typeof(Rect), Member = "ToString")]
	[Calls(Type = typeof(Rect), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public static bool IsMeshAndMaterialRectEnclosedByAtlasRect(MB_TextureTilingTreatment tilingTreatment, Rect uvR, Rect sourceMaterialTiling, Rect samplingEncapsulatinRect, MB2_LogLevel logLevel)
	{
		return default(bool);
	}
}
