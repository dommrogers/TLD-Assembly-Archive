using System;
using System.Collections.Generic;
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

		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObjects")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 30)]
		public Material2AtlasRectangleMapper(MB2_TextureBakeResults res)
		{
		}

		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
		[Calls(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetUv0Raw")]
		[Calls(Type = typeof(MB_Utility), Member = "hasOutOfBoundsUVs")]
		[Calls(Type = typeof(Rect), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(MB2_TextureBakeResults), Member = "IsMeshAndMaterialRectEnclosedByAtlasRect")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 60)]
		public bool TryMapMaterialToUVRect(Material mat, Mesh m, int submeshIdx, int idxInResultMats, MB3_MeshCombinerSingle.MeshChannelsCache meshChannelCache, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisCache, out MB_TextureTilingTreatment tilingTreatment, out Rect rectInAtlas, out Rect encapsulatingRectOut, out Rect sourceMaterialTilingOut, ref string errorMsg, MB2_LogLevel logLevel)
		{
			tilingTreatment = default(MB_TextureTilingTreatment);
			rectInAtlas = default(Rect);
			encapsulatingRectOut = default(Rect);
			sourceMaterialTilingOut = default(Rect);
			return false;
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
			return 0;
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

	[CalledBy(Type = typeof(MB3_MeshCombiner), Member = "_CreateTemporaryTextrueBakeResult")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HashSet<>), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MB_Utility), Member = "GetGOMaterials")]
	[Calls(Type = typeof(HashSet<>), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(MB_MultiMaterial), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 83)]
	public static MB2_TextureBakeResults CreateForMaterialsOnRenderer(GameObject[] gos, List<Material> matsOnTargetRenderer)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool DoAnyResultMatsUseConsiderMeshUVs()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public bool ContainsMaterial(Material m)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(HashSet<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 43)]
	public string GetDescription()
	{
		return null;
	}

	[CalledBy(Type = typeof(Material2AtlasRectangleMapper), Member = "TryMapMaterialToUVRect")]
	[CalledBy(Type = typeof(MB3_TextureCombinerMerging), Member = "DoIntegrityCheckMergedEncapsulatingSamplingRects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Rect), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB3_UVTransformUtility), Member = "RectContainsShifted")]
	[Calls(Type = typeof(MB3_UVTransformUtility), Member = "LineSegmentContainsShifted")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 41)]
	public static bool IsMeshAndMaterialRectEnclosedByAtlasRect(MB_TextureTilingTreatment tilingTreatment, Rect uvR, Rect sourceMaterialTiling, Rect samplingEncapsulatinRect, MB2_LogLevel logLevel)
	{
		return false;
	}
}
