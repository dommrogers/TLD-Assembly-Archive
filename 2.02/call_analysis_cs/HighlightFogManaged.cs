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

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	private void UpdateAngles()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(HighlightFogManaged), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "Update")]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "UpdateQuads")]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateDrive()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "UpdateQuads")]
	[CalledBy(Type = typeof(HighlightFogManaged), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "Update")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	private void UpdateMaterial()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighlightFogManaged), Member = "ManualUpdateAngles")]
	[Calls(Type = typeof(HighlightFogManaged), Member = "UpdateDrive")]
	[Calls(Type = typeof(HighlightFogManaged), Member = "UpdateMaterial")]
	public void ManualUpdate(float todMult, Vector3 heading)
	{
	}

	[CalledBy(Type = typeof(HighlightFogManager), Member = "Update")]
	[CalledBy(Type = typeof(HighlightFogManaged), Member = "ManualUpdate")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "UpdateQuads")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 13)]
	private void ManualUpdateAngles()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public HighlightFogManaged()
	{
	}
}
