using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class MB_Utility
{
	public struct MeshAnalysisResult
	{
		public Rect uvRect;

		public bool hasOutOfBoundsUVs;

		public bool hasOverlappingSubmeshVerts;

		public bool hasOverlappingSubmeshTris;

		public bool hasUVs;

		public float submeshArea;
	}

	private class MB_Triangle
	{
		private int submeshIdx;

		private int[] vs;

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(MB_Utility), Member = "doSubmeshesShareVertsOrTris")]
		[CallsUnknownMethods(Count = 20)]
		public bool isSame(object obj)
		{
			return default(bool);
		}

		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(MB_Utility), Member = "doSubmeshesShareVertsOrTris")]
		[CallsUnknownMethods(Count = 23)]
		public bool sharesVerts(MB_Triangle obj)
		{
			return default(bool);
		}

		[CalledBy(Type = typeof(MB_Utility), Member = "doSubmeshesShareVertsOrTris")]
		[CalledBy(Type = typeof(MB_Utility), Member = "doSubmeshesShareVertsOrTris")]
		[CallsUnknownMethods(Count = 18)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		public void Initialize(int[] ts, int idx, int sIdx)
		{
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(MB_Utility), Member = "doSubmeshesShareVertsOrTris")]
		[CalledBy(Type = typeof(MB_Utility), Member = "doSubmeshesShareVertsOrTris")]
		public MB_Triangle()
		{
		}
	}

	public static bool DO_INTEGRITY_CHECKS;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "_createTextureCopy")]
	[CallsUnknownMethods(Count = 9)]
	public static Texture2D createTextureCopy(Texture2D source)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public static bool ArrayBIsSubsetOfA(object[] a, object[] b)
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CalledBy(Type = typeof(MB2_TextureBakeResults), Member = "CreateForMaterialsOnRenderer")]
	[CalledBy(Type = typeof(MB3_MeshBakerRoot), Member = "DoCombinedValidate")]
	[CalledBy(Type = typeof(MB3_TextureBaker), Member = "_ValidateResultMaterials")]
	[CalledBy(Type = typeof(MB3_TextureBaker._003CCreateAtlasesCoroutine_003Ed__94), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "SuggestTreatment")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "SuggestTreatment")]
	[CalledBy(Type = typeof(MB3_TextureCombiner._003C_CombineTexturesIntoAtlases_003Ed__69), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline._003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Ed__8), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "get_sharedMesh")]
	public static Material[] GetGOMaterials(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline._003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Ed__8), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "SuggestTreatment")]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "_distributeAmongBakers")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetBoneWeights")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetBindposes")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(MB3_MeshBakerGrouperCore), Member = "AddMeshBaker")]
	[CalledBy(Type = typeof(MB3_MeshBakerRoot), Member = "DoCombinedValidate")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "get_sharedMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 10)]
	public static Mesh GetMesh(GameObject go)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "set_sharedMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static void SetMesh(GameObject go, Mesh m)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CalledBy(Type = typeof(MB_Utility), Member = "GetBounds")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CalledBy(Type = typeof(MB3_MeshBakerCommon), Member = "EnableDisableSourceObjectRenderers")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static Renderer GetRenderer(GameObject go)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallsUnknownMethods(Count = 3)]
	public static void DisableRendererInSource(GameObject go)
	{
	}

	[Calls(Type = typeof(MB_Utility), Member = "hasOutOfBoundsUVs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool hasOutOfBoundsUVs(Mesh m, ref Rect uvBounds)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mesh), Member = "get_uv4")]
	[Calls(Type = typeof(Mesh), Member = "get_uv3")]
	[Calls(Type = typeof(Mesh), Member = "get_uv2")]
	[Calls(Type = typeof(Mesh), Member = "get_uv")]
	[Calls(Type = typeof(MB_Utility), Member = "hasOutOfBoundsUVs")]
	[CalledBy(Type = typeof(MB_Utility), Member = "hasOutOfBoundsUVs")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "SuggestTreatment")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline._003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Ed__8), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	public static bool hasOutOfBoundsUVs(Mesh m, ref MeshAnalysisResult putResultHere, int submeshIndex = -1, int uvChannel = 0)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(MB_Utility), Member = "hasOutOfBoundsUVs")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_collectOutOfBoundsUVRects2")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mesh), Member = "GetTriangles")]
	[CalledBy(Type = typeof(MB2_TextureBakeResults.Material2AtlasRectangleMapper), Member = "TryMapMaterialToUVRect")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool hasOutOfBoundsUVs(Vector2[] uvs, Mesh m, ref MeshAnalysisResult putResultHere, int submeshIndex = -1)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "_createTemporaryTexture")]
	[CalledBy(Type = typeof(MB_TexSet), Member = "CreateColoredTexToReplaceNull")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity), Member = "_copyTexturesIntoAtlas")]
	public static void setSolidColor(Texture2D t, Color c)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity), Member = "_copyTexturesIntoAtlas")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "_resizeTexture")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = "GetPixelBilinear")]
	public static Texture2D resampleTexture(Texture2D source, int newWidth, int newHeight)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline._003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Ed__8), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static bool AreAllSharedMaterialsDistinct(Material[] sharedMaterials)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 33)]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "SuggestTreatment")]
	[CalledBy(Type = typeof(MB3_MeshBakerRoot), Member = "DoCombinedValidate")]
	[Calls(Type = typeof(MB_Triangle), Member = "isSame")]
	[Calls(Type = typeof(MB_Triangle), Member = "Initialize")]
	[Calls(Type = typeof(MB_Triangle), Member = "Initialize")]
	[Calls(Type = typeof(MB_Triangle), Member = "sharesVerts")]
	[Calls(Type = typeof(Mesh), Member = "GetTriangles")]
	[Calls(Type = typeof(MB_Triangle), Member = ".ctor")]
	[Calls(Type = typeof(MB_Triangle), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	public static int doSubmeshesShareVertsOrTris(Mesh m, ref MeshAnalysisResult mar)
	{
		return default(int);
	}

	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MB3_MeshCombiner), Member = "UpdateSkinnedMeshApproximateBoundsFromBoundsStatic")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(MB3_MeshCombiner), Member = "UpdateSkinnedMeshApproximateBoundsFromBoundsStatic")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MB_Utility), Member = "GetRenderer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallerCount(Count = 2)]
	public static bool GetBounds(GameObject go, out Bounds b)
	{
		System.Runtime.CompilerServices.Unsafe.As<Bounds, @null>(ref b) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "BuildPrefabHierarchy")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "BuildPrefabHierarchy")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "_getMeshNormals")]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "AddDeleteGameObjectsByID")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "_destroyTemporaryTextures")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerFast._003CCreateAtlases_003Ed__2), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity), Member = "_copyTexturesIntoAtlas")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "BuildPrefabHierarchy")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "_destroyAllTemporaryTextures")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "BuildSceneHierarchPreBake")]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "DestroyMesh")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "BuildSceneHierarchPreBake")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "DestroyMesh")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "ClearBuffers")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "AddDeleteGameObjectsByID")]
	[CalledBy(Type = typeof(MB_TextureCombinerRenderTexture), Member = "DoRenderAtlas")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "BuildSceneHierarchPreBake")]
	[CalledBy(Type = typeof(MB_TextureCombinerRenderTexture), Member = "DoRenderAtlas")]
	[CalledBy(Type = typeof(MB3_TextureBaker), Member = "CreateAtlases")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 19)]
	public static void Destroy(UnityEngine.Object o)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MB_Utility()
	{
	}
}
