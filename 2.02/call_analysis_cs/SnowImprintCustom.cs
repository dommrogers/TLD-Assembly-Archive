using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowImprintCustom : MonoBehaviour
{
	public Vector2 m_Dimensions;

	public float m_InsetDepth;

	public float m_InsetPower;

	public Vector3 m_NormalStep;

	public float m_DrawDistance;

	public float m_ShadeByZ;

	public float m_ShadeByZBand;

	public float m_ShadeByZPower;

	public bool m_CastShadows;

	public bool m_ReceiveShadows;

	public Mesh m_FinalPassMesh;

	public Mesh m_DepthResetMesh;

	public Material m_DepthResetMaterial;

	public Vector2 m_DepthResetTiltMinMax;

	public Vector3 m_DepthResetOffsetMin;

	public Vector3 m_DepthResetOffsetMax;

	public Material m_ImprintMaterial;

	public Shader m_ImprintExteriorShader;

	public Shader m_ImprintInteriorShader;

	private Vector3 m_MinPos;

	private Vector3 m_MaxPos;

	private Vector3[] m_HermiteCoefficients;

	private int[] m_CoeffIds;

	private int m_NormalStepId;

	private int m_ShadeByZId;

	private int m_MaxInsetId;

	private int m_InsetPowId;

	private int m_FadeDistanceId;

	private int m_VisibleDistanceId;

	private Bounds m_LocalBounds;

	private MaterialPropertyBlock m_MaterialPropertyBlock1;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 10)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowImprintCustom), Member = "Reposition")]
	private void Start()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(SnowImprintCustom), Member = "Start")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[Calls(Type = typeof(SnowImprintCustom), Member = "BuildMaterialPropertyBlocks")]
	[Calls(Type = typeof(Bounds), Member = "SetMinMax")]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	public void Reposition()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Matrix4x4), Member = "SetTRS")]
	[Calls(Type = typeof(Graphics), Member = "DrawMesh")]
	[Calls(Type = typeof(Matrix4x4), Member = "SetTRS")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Graphics), Member = "DrawMesh")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 17)]
	[CalledBy(Type = typeof(SnowImprintCustom), Member = "Reposition")]
	[CallsUnknownMethods(Count = 93)]
	private void BuildMaterialPropertyBlocks()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void SetInterior(bool interior)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SnowImprintCustom()
	{
	}
}
