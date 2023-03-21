using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HighlightFogManaged : MonoBehaviour
{
	public GameObject m_FogQuad;

	public float m_NearVanish;

	public float m_FadeDistance;

	public Color m_BaseColor;

	public float m_SoftEdgeFactor;

	public bool m_FadeAtNight;

	public bool m_FadeAtRightAngles;

	public bool m_LookAtPlayer;

	public Light m_LightDriver;

	private Vector3 m_PlanePoint;

	private float m_CurrentDistanceSqr;

	private Renderer m_Rend;

	private Color m_CurrentColor;

	private Plane m_Plane;

	private Vector3 m_PlaneCalculator;

	private float m_TODMultiplier;

	private float m_LightDriverMax;

	private float m_LightDriverMultiplier;

	private float m_Angle;

	private Vector3 m_Heading;

	private float m_AngleCos;

	private float m_DistanceMultiplier;

	private bool m_Initialized;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	private void UpdateAngles()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void UpdateDrive()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CalledBy(Type = typeof(HighlightFogManaged), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateMaterial()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "UpdateQuads")]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "Update")]
	[Calls(Type = typeof(HighlightFogManaged), Member = "UpdateMaterial")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(HighlightFogManaged), Member = "ManualUpdateAngles")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void ManualUpdate(float todMult, Vector3 heading)
	{
	}

	[CalledBy(Type = typeof(HighlightFogManaged), Member = "ManualUpdate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 10)]
	private void ManualUpdateAngles()
	{
	}

	[CallerCount(Count = 0)]
	public HighlightFogManaged()
	{
	}
}
