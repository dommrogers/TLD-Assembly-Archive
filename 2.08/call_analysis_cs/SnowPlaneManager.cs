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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "InitializeMesh")]
	[Calls(Type = typeof(SnowPlaneManager), Member = "MaybeRefreshCameraForCommandBuffer")]
	[Calls(Type = typeof(SnowPlaneManager), Member = "SetComponentsActive")]
	[Calls(Type = typeof(SnowPlaneParticles), Member = "Reset")]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(CommandBuffer), Member = "Dispose")]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "SetComponentsActive")]
	[Calls(Type = typeof(SnowPlaneParticles), Member = "Reset")]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	public void SetSnowColor(Color col)
	{
	}

	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Start")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	private void InitializeMesh()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "OnRenderObject")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Mesh), Member = "set_colors")]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	[Calls(Type = typeof(MeshFilter), Member = "get_mesh")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	private void UpdateMesh()
	{
	}

	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawRenderer")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "SetComponentsActive")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(SnowPlaneManager), Member = "MaybeRefreshCameraForCommandBuffer")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "GetFallingSnowIntensity")]
	private void Update()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Start")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Reset")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "InitializeForScene")]
	[CallsUnknownMethods(Count = 3)]
	private void SetComponentsActive(bool state)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(SnowPlaneManager), Member = "UpdateMesh")]
	private void OnRenderObject()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "OnDestroy")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "MaybeRefreshCameraForCommandBuffer")]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveCommandBuffer()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Update")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Start")]
	[Calls(Type = typeof(SnowPlaneManager), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	private void MaybeRefreshCameraForCommandBuffer()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SnowPlaneManager()
	{
	}
}
