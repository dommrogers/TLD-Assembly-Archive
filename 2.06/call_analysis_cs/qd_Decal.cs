using System;
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
		[CallerCount(Count = 44)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetScale(float scale)
	{
	}

	[CallerCount(Count = 85)]
	[DeduplicatedMethod]
	public void SetTexture(Texture2D tex)
	{
	}

	[CallerCount(Count = 33)]
	[DeduplicatedMethod]
	public void SetDecalId(string decalId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 18)]
	public string GetDecalId()
	{
		return null;
	}

	[CallerCount(Count = 55)]
	[DeduplicatedMethod]
	public void SetFullScreenDecalMaterial(Material mat)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(qdUtil), Member = "RefreshSceneDecals")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(qd_Mesh), Member = "CreateDecal")]
	public void SetUVRect(Rect r)
	{
	}

	[Calls(Type = typeof(Mesh), Member = "DefaultDimensionForChannel")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	public void FreezeTransform()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(qd_Decal), Member = "GetQuickDecalMaterial")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(qd_Decal), Member = "Awake")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(qd_Mesh), Member = "DecalMesh")]
	public void Verify()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TryGetStaticDecalUvs")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeUpdateUvsFromDecalManager()
	{
	}

	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[Calls(Type = typeof(Material), Member = "set_enableInstancing")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TryGetStaticDecalUvs")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(qd_Decal), Member = "Awake")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshStaticDecal()
	{
	}

	[CallerCount(Count = 0)]
	public Material GetStaticDecalMaterial()
	{
		return null;
	}

	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(qd_Decal), Member = "Verify")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	public static Material GetQuickDecalMaterial(Texture texture)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetAtlasUvPathWithoutExtensionFromPngPath(string texturePath)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public qd_Decal()
	{
	}
}
