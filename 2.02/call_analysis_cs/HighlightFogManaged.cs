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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateAngles()
	{
	}

	[CalledBy(Type = typeof(HighlightFogManaged), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "Update")]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "UpdateQuads")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateDrive()
	{
	}

	[CalledBy(Type = typeof(HighlightFogManaged), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "Update")]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "UpdateQuads")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
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

	[CalledBy(Type = typeof(HighlightFogManaged), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "Update")]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "UpdateQuads")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
	private void ManualUpdateAngles()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HighlightFogManaged()
	{
	}
}
