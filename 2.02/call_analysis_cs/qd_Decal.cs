using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using ProCore.Decals;
using UnityEngine;

public class qd_Decal : MonoBehaviour
{
	private Texture2D _texture;

	private Rect _rect;

	private float _scale;

	private string _decalId;

	public Material m_fullscreenDecalMaterial;

	public int m_Layer;

	public float m_ClipAngleDegrees;

	private StaticDecal m_StaticDecal;

	public static int ID_DecalZTestModeID;

	private static Dictionary<Texture, Material> m_QuickDecalMaterials;

	private static Dictionary<Texture, Material> m_StaticDecalMaterials;

	private static Dictionary<Texture, Material> m_CameraClippedStaticDecalMaterials;

	public Texture2D texture
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(qd_Decal), Member = "Verify")]
	[Calls(Type = typeof(qd_Decal), Member = "RefreshStaticDecal")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetScale(float scale)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 77)]
	public void SetTexture(Texture2D tex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 18)]
	public void SetDecalId(string decalId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 9)]
	public string GetDecalId()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 46)]
	public void SetFullScreenDecalMaterial(Material mat)
	{
	}

	[CalledBy(Type = typeof(qdUtil), Member = "RefreshSceneDecals")]
	[CalledBy(Type = typeof(qd_Mesh), Member = "CreateDecal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public void SetUVRect(Rect r)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 16)]
	public void FreezeTransform()
	{
	}

	[CalledBy(Type = typeof(qd_Decal), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(qd_Decal), Member = "GetQuickDecalMaterial")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(qd_Mesh), Member = "DecalMesh")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public void Verify()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TryGetStaticDecalUvs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeUpdateUvsFromDecalManager()
	{
	}

	[CalledBy(Type = typeof(qd_Decal), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[Calls(Type = typeof(Material), Member = "set_enableInstancing")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TryGetStaticDecalUvs")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 61)]
	private void RefreshStaticDecal()
	{
	}

	[CallerCount(Count = 0)]
	public Material GetStaticDecalMaterial()
	{
		return null;
	}

	[CalledBy(Type = typeof(qd_Decal), Member = "Verify")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public static Material GetQuickDecalMaterial(Texture texture)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetAtlasUvPathWithoutExtensionFromPngPath(string texturePath)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public qd_Decal()
	{
	}
}
