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

	public bool m_LinkToElectrostatic;

	public bool m_FadeAtRightAngles;

	public float m_AngleFadeThreshold;

	public bool m_LookAtPlayer;

	public Light m_LightDriver;

	public float m_LightDriverMax;

	public bool m_LinkLightColor;

	private float m_CurrentDistanceSqr;

	private Renderer m_Rend;

	private MaterialPropertyBlock m_PropertyBlock;

	private Color m_CurrentColor;

	private UniStormWeatherSystem m_UniStorm;

	private float m_TODMultiplier;

	private float m_LightDriverMultiplier;

	private float m_Angle;

	private Vector3 m_Heading;

	private float m_AngleCos;

	private float m_DistanceMultiplier;

	private float m_ElectrostaticForce;

	private bool m_UseExternalDistanceMultiplier;

	private Transform m_CachedTransform;

	private Transform m_CachedCameraTransform;

	private static readonly int s_SoftEdgeFactorPropertyID;

	private static readonly int s_TintColorPropertyID;

	public float ElectrostaticForce
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(HighlightFog), Member = "UpdateMaterial")]
	[Calls(Type = typeof(HighlightFog), Member = "UpdateTOD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(HighlightFog), Member = "UpdateAngleAndPosition")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(HighlightFog), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 12)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	private void UpdateAngleAndPosition()
	{
	}

	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(HighlightFog), Member = "Update")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[CallerCount(Count = 1)]
	private void UpdateTOD()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void UpdateDrive()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(HighlightFog), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateMaterial()
	{
	}

	[CallerCount(Count = 0)]
	private Vector3 Heading3D(Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public HighlightFog()
	{
	}
}
