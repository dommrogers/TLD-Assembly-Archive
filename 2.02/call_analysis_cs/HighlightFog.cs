using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HighlightFog : MonoBehaviour
{
	public GameObject m_FogQuad;

	public float m_NearVanish;

	public float m_FadeDistance;

	public float m_CheatTowardPlayer;

	public Color m_BaseColor;

	public float m_SoftEdgeFactor;

	public bool m_FadeAtNight;

	public bool m_FadeAtRightAngles;

	public float m_AngleFadeThreshold;

	public bool m_LookAtPlayer;

	public Light m_LightDriver;

	public float m_LightDriverMax;

	public bool m_LinkLightColor;

	private Vector3 m_PlanePoint;

	private float m_CurrentDistanceSqr;

	private Renderer m_Rend;

	private MaterialPropertyBlock m_PropertyBlock;

	private Color m_CurrentColor;

	private Plane m_Plane;

	private Vector3 m_PlaneCalculator;

	private UniStormWeatherSystem m_UniStorm;

	private float m_TODMultiplier;

	private float m_LightDriverMultiplier;

	private float m_Angle;

	private Vector3 m_Heading;

	private float m_AngleCos;

	private float m_DistanceMultiplier;

	private float m_WeatherMultiplier;

	private Transform m_CachedTransform;

	private Transform m_CachedCameraTransform;

	private static readonly int s_SoftEdgeFactorPropertyID;

	private static readonly int s_TintColorPropertyID;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HighlightFog), Member = "UpdateAngleAndPosition")]
	[Calls(Type = typeof(HighlightFog), Member = "UpdateTOD")]
	[Calls(Type = typeof(HighlightFog), Member = "UpdateDrive")]
	[Calls(Type = typeof(HighlightFog), Member = "UpdateMaterial")]
	[CallsUnknownMethods(Count = 9)]
	private void Start()
	{
	}

	[Calls(Type = typeof(HighlightFog), Member = "UpdateDrive")]
	[Calls(Type = typeof(HighlightFog), Member = "UpdateMaterial")]
	[Calls(Type = typeof(HighlightFog), Member = "UpdateTOD")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighlightFog), Member = "UpdateAngleAndPosition")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(HighlightFog), Member = "Update")]
	[CalledBy(Type = typeof(HighlightFog), Member = "Start")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	private void UpdateAngleAndPosition()
	{
	}

	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[CalledBy(Type = typeof(HighlightFog), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[CalledBy(Type = typeof(HighlightFog), Member = "Start")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[CallerCount(Count = 2)]
	private void UpdateTOD()
	{
	}

	[CalledBy(Type = typeof(HighlightFog), Member = "Update")]
	[CalledBy(Type = typeof(HighlightFog), Member = "Start")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void UpdateDrive()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(HighlightFog), Member = "Start")]
	[CalledBy(Type = typeof(HighlightFog), Member = "Update")]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateMaterial()
	{
	}

	[CallerCount(Count = 0)]
	private Vector3 Heading3D(Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HighlightFog()
	{
	}
}
