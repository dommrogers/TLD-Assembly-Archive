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

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	[Calls(Type = typeof(SnowImprintCustom), Member = "BuildMaterialPropertyBlocks")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 13)]
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

	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Graphics), Member = "DrawMesh")]
	[Calls(Type = typeof(Graphics), Member = "DrawMesh")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 16)]
	[CalledBy(Type = typeof(SnowImprintCustom), Member = "Reposition")]
	[CallsUnknownMethods(Count = 19)]
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
	public SnowImprintCustom()
	{
	}
}
