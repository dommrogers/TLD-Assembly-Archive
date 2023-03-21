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
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetScale(float scale)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 79)]
	public void SetTexture(Texture2D tex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 38)]
	public void SetDecalId(string decalId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 16)]
	public string GetDecalId()
	{
		return null;
	}

	[CallerCount(Count = 60)]
	[DeduplicatedMethod]
	public void SetFullScreenDecalMaterial(Material mat)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel")]
	[CalledBy(Type = typeof(qdUtil), Member = "RefreshSceneDecals")]
	[CalledBy(Type = typeof(qd_Mesh), Member = "CreateDecal")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public void SetUVRect(Rect r)
	{
	}

	[Calls(Type = typeof(Array), Member = "get_Length")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel")]
	public void FreezeTransform()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(qd_Mesh), Member = "DecalMesh")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[CalledBy(Type = typeof(qd_Decal), Member = "Awake")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void Verify()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TryGetStaticDecalUvs")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeUpdateUvsFromDecalManager()
	{
	}

	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "set_enableInstancing")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TryGetStaticDecalUvs")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[CalledBy(Type = typeof(qd_Decal), Member = "Awake")]
	private void RefreshStaticDecal()
	{
	}

	[CallerCount(Count = 0)]
	public Material GetStaticDecalMaterial()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static Material GetQuickDecalMaterial(Texture texture)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static string GetAtlasUvPathWithoutExtensionFromPngPath(string texturePath)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public qd_Decal()
	{
	}
}
