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

	[Calls(Type = typeof(SnowPlaneManager), Member = "SetComponentsActive")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "MaybeRefreshCameraForCommandBuffer")]
	[Calls(Type = typeof(SnowPlaneParticles), Member = "Reset")]
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
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 4)]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Start")]
	[CallsUnknownMethods(Count = 9)]
	private void InitializeMesh()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "OnRenderObject")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Mesh), Member = "set_colors")]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(MeshFilter), Member = "get_mesh")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void UpdateMesh()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "MaybeRefreshCameraForCommandBuffer")]
	[Calls(Type = typeof(Weather), Member = "GetFallingSnowIntensity")]
	[Calls(Type = typeof(SnowPlaneManager), Member = "SetComponentsActive")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawRenderer")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "InitializeForScene")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Reset")]
	[CallerCount(Count = 4)]
	private void SetComponentsActive(bool state)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "UpdateMesh")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	private void OnRenderObject()
	{
	}

	[CalledBy(Type = typeof(SnowPlaneManager), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "MaybeRefreshCameraForCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	private void RemoveCommandBuffer()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Start")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeRefreshCameraForCommandBuffer()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SnowPlaneManager()
	{
	}
}
