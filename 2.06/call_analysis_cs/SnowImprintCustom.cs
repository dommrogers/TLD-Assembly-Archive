using System;
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
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
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

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(SnowImprintCustom), Member = "Start")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[Calls(Type = typeof(SnowImprintCustom), Member = "BuildMaterialPropertyBlocks")]
	[Calls(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public void Reposition()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Graphics), Member = "DrawMesh")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Graphics), Member = "DrawMesh")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(SnowImprintCustom), Member = "Reposition")]
	[CallsUnknownMethods(Count = 24)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 16)]
	private void BuildMaterialPropertyBlocks()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SetInterior(bool interior)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public SnowImprintCustom()
	{
	}
}
