using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Rainbow : MonoBehaviour
{
	public GameObject m_RainbowQuad;

	public float m_NearVanish;

	public float m_FadeDistance;

	public Color m_BaseColor;

	public float m_SoftEdgeFactor;

	private Vector3 m_PlanePoint;

	private float m_CurrentDistance;

	private Renderer m_Rend;

	private Color m_CurrentColor;

	private Plane m_Plane;

	private Vector3 m_PlaneCalculator;

	private UniStormWeatherSystem m_UniStorm;

	private float m_TargetOpacity;

	private float m_CurrentOpacity;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 19)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private Vector3 ProjectPointOnPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 point)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public Rainbow()
	{
	}
}
