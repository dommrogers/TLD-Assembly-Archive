using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering;

public class SnowPlaneManager : MonoBehaviour
{
	public float m_UV_XY_Scalar;

	public float m_UV_Z_Scalar;

	public float m_YawAngleToBaseUVScalar;

	public float m_PitchAngleToBaseUVScalar;

	public float m_AngleToUVRangeScalar;

	public float m_MaxTiltOffset;

	public float[] m_LayerDepths;

	public RenderTexture m_RenderTexture;

	public SnowPlaneParticles m_Particles;

	public MeshFilter m_MeshFilter;

	public MeshRenderer m_MeshRenderer;

	private Vector3[] m_Verts;

	private Vector2[] m_Uvs;

	private Color[] m_Colors;

	private int[] m_Tris;

	private int m_LayerCountSub;

	private CommandBuffer m_CommandBuffer;

	private ParticleSystemRenderer m_ParticleRenderer;

	private Camera m_CurrentCamera;

	private bool m_IsActive;

	public Color m_SnowColor;

	private static Vector2[] m_CornerOffsets;

	public bool IsEnabled
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "InitializeMesh")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(SnowPlaneManager), Member = "MaybeRefreshCameraForCommandBuffer")]
	[Calls(Type = typeof(SnowPlaneManager), Member = "SetComponentsActive")]
	[Calls(Type = typeof(SnowPlaneParticles), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(CommandBuffer), Member = "Dispose")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "SetComponentsActive")]
	[Calls(Type = typeof(SnowPlaneParticles), Member = "Reset")]
	[CallsUnknownMethods(Count = 1)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	public void SetSnowColor(Color col)
	{
	}

	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 17)]
	private void InitializeMesh()
	{
	}

	[CalledBy(Type = typeof(SnowPlaneManager), Member = "OnRenderObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(MeshFilter), Member = "get_mesh")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	[Calls(Type = typeof(Mesh), Member = "set_colors")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateMesh()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Start")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Reset")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "InitializeForScene")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SetComponentsActive(bool state)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "UpdateMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	private void OnRenderObject()
	{
	}

	[CalledBy(Type = typeof(SnowPlaneManager), Member = "OnDestroy")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "MaybeRefreshCameraForCommandBuffer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveCommandBuffer()
	{
	}

	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(SnowPlaneManager), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeRefreshCameraForCommandBuffer()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public SnowPlaneManager()
	{
	}
}
