using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class VolumetricObjectBase : MonoBehaviour
{
	public string volumeShader;

	protected Material volumetricMaterial;

	public float visibility;

	public Color volumeColor;

	public Texture2D texture;

	public float textureScale;

	public Vector3 textureMovement;

	protected Mesh meshInstance;

	protected Material materialInstance;

	protected Transform thisTransform;

	protected float previousVisibility;

	protected Color previousVolumeColor;

	protected Vector3 forcedLocalScale;

	protected Texture2D previousTexture;

	protected float previousTextureScale;

	protected Vector3 previousTextureMovement;

	protected Vector3[] unitVerts;

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(SphereVolume), Member = "OnEnable")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "CreateCube")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BoxVolume), Member = "OnEnable")]
	[CalledBy(Type = typeof(ConeVolume), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = "OnEnable")]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "SetupUnitVerts")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	protected virtual void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnDestroy()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected virtual void OnDisable()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected virtual void CleanUp()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void PopulateShaderName()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(BoxVolume), Member = "HasChanged")]
	[Calls(Type = typeof(Vector3), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "op_Inequality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConeVolume), Member = "HasChanged")]
	[CalledBy(Type = typeof(SphereVolume), Member = "HasChanged")]
	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = "HasChanged")]
	public virtual bool HasChanged()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SphereVolume), Member = "SetChangedValues")]
	[CalledBy(Type = typeof(ConeVolume), Member = "SetChangedValues")]
	[CalledBy(Type = typeof(BoxVolume), Member = "SetChangedValues")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = "SetChangedValues")]
	protected virtual void SetChangedValues()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void UpdateVolume()
	{
	}

	[CallsUnknownMethods(Count = 49)]
	[CalledBy(Type = typeof(VolumetricObjectBase), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	public void SetupUnitVerts()
	{
	}

	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[CalledBy(Type = typeof(VolumetricObjectBase), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 83)]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds")]
	public Mesh CreateCube()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "ScaleMesh")]
	[CalledBy(Type = typeof(BoxVolume), Member = "UpdateVolume")]
	[CalledBy(Type = typeof(SphereVolume), Member = "UpdateVolume")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public void ScaleMesh(Mesh mesh, Vector3 scaleFactor)
	{
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(VolumetricObjectBase), Member = "ScaleMesh")]
	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = "UpdateVolume")]
	[CalledBy(Type = typeof(ConeVolume), Member = "UpdateVolume")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[CallsDeduplicatedMethods(Count = 3)]
	public void ScaleMesh(Mesh mesh, Vector3 scaleFactor, Vector3 addVector)
	{
	}

	[CallerCount(Count = 0)]
	private Vector3 ScaleVector(Vector3 vector, Vector3 scale)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Mesh), Member = "set_normals")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Mesh), Member = "set_uv2")]
	[Calls(Type = typeof(Mesh), Member = "get_tangents")]
	[Calls(Type = typeof(Mesh), Member = "get_normals")]
	[Calls(Type = typeof(Mesh), Member = "get_normals")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Mesh), Member = "get_uv2")]
	[Calls(Type = typeof(Mesh), Member = "get_tangents")]
	[Calls(Type = typeof(Mesh), Member = "get_colors")]
	[Calls(Type = typeof(Mesh), Member = "set_tangents")]
	[Calls(Type = typeof(Mesh), Member = "get_colors")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds")]
	[Calls(Type = typeof(Mesh), Member = "get_uv2")]
	[Calls(Type = typeof(Mesh), Member = "SetTriangles")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Mesh), Member = "GetTriangles")]
	[Calls(Type = typeof(Mesh), Member = "set_colors")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Mesh), Member = "set_uv2")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Mesh), Member = "get_uv2")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[Calls(Type = typeof(Mesh), Member = "get_uv")]
	[Calls(Type = typeof(Mesh), Member = "get_uv")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	[Calls(Type = typeof(Mesh), Member = "get_uv2")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	public Mesh CopyMesh(Mesh original)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SphereVolume), Member = ".ctor")]
	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = ".ctor")]
	[CalledBy(Type = typeof(ConeVolume), Member = ".ctor")]
	[CalledBy(Type = typeof(BoxVolume), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public VolumetricObjectBase()
	{
	}
}
