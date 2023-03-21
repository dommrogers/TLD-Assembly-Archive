using System;
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

		[CalledBy(Type = typeof(MB_Utility), Member = "doSubmeshesShareVertsOrTris")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 20)]
		public bool isSame(object obj)
		{
			return false;
		}

		[CalledBy(Type = typeof(MB_Utility), Member = "doSubmeshesShareVertsOrTris")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 23)]
		public bool sharesVerts(MB_Triangle obj)
		{
			return false;
		}

		[CalledBy(Type = typeof(MB_Utility), Member = "doSubmeshesShareVertsOrTris")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 18)]
		public void Initialize(int[] ts, int idx, int sIdx)
		{
		}

		[CalledBy(Type = typeof(MB_Utility), Member = "doSubmeshesShareVertsOrTris")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		public MB_Triangle()
		{
		}
	}

	public static bool DO_INTEGRITY_CHECKS;

	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "_createTextureCopy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public static Texture2D createTextureCopy(Texture2D source)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public static bool ArrayBIsSubsetOfA(object[] a, object[] b)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB2_TextureBakeResults), Member = "CreateForMaterialsOnRenderer")]
	[CalledBy(Type = typeof(MB3_MeshBakerRoot), Member = "DoCombinedValidate")]
	[CalledBy(Type = typeof(MB3_TextureBaker), Member = "_ValidateResultMaterials")]
	[CalledBy(TypeFullName = "MB3_TextureBaker.<CreateAtlasesCoroutine>d__94", Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "SuggestTreatment")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombiner.<_CombineTexturesIntoAtlases>d__69", Member = "MoveNext")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<__Step1_CollectDistinctMatTexturesAndUsedObjects>d__8", Member = "MoveNext")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "get_sharedMesh")]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 24)]
	public static Material[] GetGOMaterials(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_MeshBakerRoot), Member = "DoCombinedValidate")]
	[CalledBy(Type = typeof(MB3_MeshBakerGrouperCore), Member = "AddMeshBaker")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetBindposes")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetBoneWeights")]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "_distributeAmongBakers")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "SuggestTreatment")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<__Step1_CollectDistinctMatTexturesAndUsedObjects>d__8", Member = "MoveNext")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "get_sharedMesh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static Mesh GetMesh(GameObject go)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "set_sharedMesh")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void SetMesh(GameObject go, Mesh m)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshBakerCommon), Member = "EnableDisableSourceObjectRenderers")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
	[CalledBy(Type = typeof(MB_Utility), Member = "GetBounds")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Renderer GetRenderer(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void DisableRendererInSource(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB_Utility), Member = "hasOutOfBoundsUVs")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool hasOutOfBoundsUVs(Mesh m, ref Rect uvBounds)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB_Utility), Member = "hasOutOfBoundsUVs")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "SuggestTreatment")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<__Step1_CollectDistinctMatTexturesAndUsedObjects>d__8", Member = "MoveNext")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mesh), Member = "get_uv4")]
	[Calls(Type = typeof(Mesh), Member = "get_uv3")]
	[Calls(Type = typeof(Mesh), Member = "get_uv2")]
	[Calls(Type = typeof(Mesh), Member = "get_uv")]
	[Calls(Type = typeof(MB_Utility), Member = "hasOutOfBoundsUVs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static bool hasOutOfBoundsUVs(Mesh m, ref MeshAnalysisResult putResultHere, int submeshIndex = -1, int uvChannel = 0)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB2_TextureBakeResults.Material2AtlasRectangleMapper), Member = "TryMapMaterialToUVRect")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_collectOutOfBoundsUVRects2")]
	[CalledBy(Type = typeof(MB_Utility), Member = "hasOutOfBoundsUVs")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mesh), Member = "GetTriangles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public static bool hasOutOfBoundsUVs(Vector2[] uvs, Mesh m, ref MeshAnalysisResult putResultHere, int submeshIndex = -1)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "_createTemporaryTexture")]
	[CalledBy(Type = typeof(MB_TexSet), Member = "CreateColoredTexToReplaceNull")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity), Member = "_copyTexturesIntoAtlas")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void setSolidColor(Texture2D t, Color c)
	{
	}

	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "_resizeTexture")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity), Member = "_copyTexturesIntoAtlas")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixelBilinear")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public static Texture2D resampleTexture(Texture2D source, int newWidth, int newHeight)
	{
		return null;
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<__Step1_CollectDistinctMatTexturesAndUsedObjects>d__8", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static bool AreAllSharedMaterialsDistinct(Material[] sharedMaterials)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_MeshBakerRoot), Member = "DoCombinedValidate")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "SuggestTreatment")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MB_Triangle), Member = ".ctor")]
	[Calls(Type = typeof(Mesh), Member = "GetTriangles")]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	[Calls(Type = typeof(MB_Triangle), Member = "Initialize")]
	[Calls(Type = typeof(MB_Triangle), Member = "isSame")]
	[Calls(Type = typeof(MB_Triangle), Member = "sharesVerts")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 33)]
	public static int doSubmeshesShareVertsOrTris(Mesh m, ref MeshAnalysisResult mar)
	{
		return 0;
	}

	[CalledBy(Type = typeof(MB3_MeshCombiner), Member = "UpdateSkinnedMeshApproximateBoundsFromBoundsStatic")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MB_Utility), Member = "GetRenderer")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static bool GetBounds(GameObject go, out Bounds b)
	{
		b = default(Bounds);
		return false;
	}

	[CalledBy(Type = typeof(MB3_TextureBaker), Member = "CreateAtlases")]
	[CalledBy(Type = typeof(MB_TextureCombinerRenderTexture), Member = "DoRenderAtlas")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "AddDeleteGameObjectsByID")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "ClearBuffers")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "DestroyMesh")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "BuildSceneHierarchPreBake")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "BuildPrefabHierarchy")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "_getMeshNormals")]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "AddDeleteGameObjectsByID")]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "DestroyMesh")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "_destroyAllTemporaryTextures")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "_destroyTemporaryTextures")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerMeshBakerFast.<CreateAtlases>d__2", Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity), Member = "_copyTexturesIntoAtlas")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void Destroy(UnityEngine.Object o)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public MB_Utility()
	{
	}
}
