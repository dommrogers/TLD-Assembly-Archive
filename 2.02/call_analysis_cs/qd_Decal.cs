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
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(qd_Decal), Member = "RefreshStaticDecal")]
	[Calls(Type = typeof(qd_Decal), Member = "Verify")]
	private void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	private void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetScale(float scale)
	{
	}

	[CallerCount(Count = 71)]
	[DeduplicatedMethod]
	public void SetTexture(Texture2D tex)
	{
	}

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public void SetDecalId(string decalId)
	{
	}

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public string GetDecalId()
	{
		return null;
	}

	[CallerCount(Count = 41)]
	[DeduplicatedMethod]
	public void SetFullScreenDecalMaterial(Material mat)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(qd_Mesh), Member = "CreateDecal")]
	[CalledBy(Type = typeof(qdUtil), Member = "RefreshSceneDecals")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	public void SetUVRect(Rect r)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	public void FreezeTransform()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(qd_Mesh), Member = "DecalMesh")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(qd_Decal), Member = "GetQuickDecalMaterial")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(qd_Decal), Member = "Awake")]
	public void Verify()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TryGetStaticDecalUvs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void MaybeUpdateUvsFromDecalManager()
	{
	}

	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "set_enableInstancing")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TryGetStaticDecalUvs")]
	[CalledBy(Type = typeof(qd_Decal), Member = "Awake")]
	[CallsUnknownMethods(Count = 61)]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void RefreshStaticDecal()
	{
	}

	[CallerCount(Count = 0)]
	public Material GetStaticDecalMaterial()
	{
		return null;
	}

	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(qd_Decal), Member = "Verify")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
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
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	public qd_Decal()
	{
	}
}
