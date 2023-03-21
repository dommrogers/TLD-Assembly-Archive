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

	[CalledBy(Type = typeof(BoxVolume), Member = "OnEnable")]
	[CalledBy(Type = typeof(ConeVolume), Member = "OnEnable")]
	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = "OnEnable")]
	[CalledBy(Type = typeof(SphereVolume), Member = "OnEnable")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "SetupUnitVerts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "CreateCube")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 26)]
	protected virtual void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void CleanUp()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void PopulateShaderName()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(BoxVolume), Member = "HasChanged")]
	[CalledBy(Type = typeof(ConeVolume), Member = "HasChanged")]
	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = "HasChanged")]
	[CalledBy(Type = typeof(SphereVolume), Member = "HasChanged")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool HasChanged()
	{
		return false;
	}

	[CalledBy(Type = typeof(BoxVolume), Member = "SetChangedValues")]
	[CalledBy(Type = typeof(ConeVolume), Member = "SetChangedValues")]
	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = "SetChangedValues")]
	[CalledBy(Type = typeof(SphereVolume), Member = "SetChangedValues")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void SetChangedValues()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void UpdateVolume()
	{
	}

	[CalledBy(Type = typeof(VolumetricObjectBase), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 49)]
	public void SetupUnitVerts()
	{
	}

	[CalledBy(Type = typeof(VolumetricObjectBase), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 83)]
	public Mesh CreateCube()
	{
		return null;
	}

	[CalledBy(Type = typeof(BoxVolume), Member = "UpdateVolume")]
	[CalledBy(Type = typeof(SphereVolume), Member = "UpdateVolume")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "ScaleMesh")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ScaleMesh(Mesh mesh, Vector3 scaleFactor)
	{
	}

	[CalledBy(Type = typeof(ConeVolume), Member = "UpdateVolume")]
	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = "UpdateVolume")]
	[CalledBy(Type = typeof(VolumetricObjectBase), Member = "ScaleMesh")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public void ScaleMesh(Mesh mesh, Vector3 scaleFactor, Vector3 addVector)
	{
	}

	[CallerCount(Count = 0)]
	private Vector3 ScaleVector(Vector3 vector, Vector3 scale)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Mesh), Member = "get_uv")]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	[Calls(Type = typeof(Mesh), Member = "get_uv2")]
	[Calls(Type = typeof(Mesh), Member = "set_uv2")]
	[Calls(Type = typeof(Mesh), Member = "get_normals")]
	[Calls(Type = typeof(Mesh), Member = "set_normals")]
	[Calls(Type = typeof(Mesh), Member = "get_tangents")]
	[Calls(Type = typeof(Mesh), Member = "set_tangents")]
	[Calls(Type = typeof(Mesh), Member = "get_colors")]
	[Calls(Type = typeof(Mesh), Member = "set_colors")]
	[Calls(Type = typeof(Mesh), Member = "GetTriangles")]
	[Calls(Type = typeof(Mesh), Member = "SetTriangles")]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 27)]
	public Mesh CopyMesh(Mesh original)
	{
		return null;
	}

	[CalledBy(Type = typeof(BoxVolume), Member = ".ctor")]
	[CalledBy(Type = typeof(ConeVolume), Member = ".ctor")]
	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = ".ctor")]
	[CalledBy(Type = typeof(SphereVolume), Member = ".ctor")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public VolumetricObjectBase()
	{
	}
}
