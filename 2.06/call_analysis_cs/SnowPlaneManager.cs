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
			return default(bool);
		}
	}

	[Calls(Type = typeof(SnowPlaneParticles), Member = "Reset")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "MaybeRefreshCameraForCommandBuffer")]
	[Calls(Type = typeof(SnowPlaneManager), Member = "SetComponentsActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "InitializeMesh")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(CommandBuffer), Member = "Dispose")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(SnowPlaneParticles), Member = "Reset")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "SetComponentsActive")]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	public void SetSnowColor(Color col)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Start")]
	[CallsUnknownMethods(Count = 17)]
	private void InitializeMesh()
	{
	}

	[Calls(Type = typeof(Mesh), Member = "set_colors")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "OnRenderObject")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(MeshFilter), Member = "get_mesh")]
	private void UpdateMesh()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Start")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Reset")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "InitializeForScene")]
	[CallsUnknownMethods(Count = 3)]
	private void SetComponentsActive(bool state)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnowPlaneManager), Member = "UpdateMesh")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	private void OnRenderObject()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "MaybeRefreshCameraForCommandBuffer")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "OnDestroy")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	private void RemoveCommandBuffer()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(SnowPlaneManager), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeRefreshCameraForCommandBuffer()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public SnowPlaneManager()
	{
	}
}
