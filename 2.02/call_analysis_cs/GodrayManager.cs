using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GodrayManager : MonoBehaviour
{
	private class GodRayObject
	{
		public Transform m_Transform;

		public Vector3 m_OriginalPosition;

		public float m_Timer;

		public float m_TimerMax;

		public Renderer m_Renderer;

		public GameObject m_GameObject;

		private float m_RotationOffset;

		private float m_RotationSpeed;

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CalledBy(Type = typeof(GodrayManager), Member = "Start")]
		[CallsUnknownMethods(Count = 5)]
		public GodRayObject(Transform thisTransform, GameObject go)
		{
		}

		[CallsUnknownMethods(Count = 13)]
		[CalledBy(Type = typeof(GodRayObject), Member = "Update")]
		[Calls(Type = typeof(Random), Member = "Range")]
		[Calls(Type = typeof(Random), Member = "Range")]
		[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
		[CallsDeduplicatedMethods(Count = 6)]
		[Calls(Type = typeof(Random), Member = "Range")]
		[Calls(Type = typeof(Random), Member = "Range")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Random), Member = "Range")]
		private void NewRay(GodrayManager manager)
		{
		}

		[Calls(Type = typeof(Vector3), Member = "Normalize")]
		[CallsUnknownMethods(Count = 17)]
		[Calls(Type = typeof(Plane), Member = "GetDistanceToPoint")]
		[Calls(Type = typeof(Transform), Member = "get_forward")]
		[CalledBy(Type = typeof(GodrayManager), Member = "Update")]
		[Calls(Type = typeof(GodRayObject), Member = "NewRay")]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Quaternion), Member = "Euler")]
		public void Update(GodrayManager manager, Quaternion sunRotation, Color rayColor, Vector3 playerPosition)
		{
		}
	}

	public bool m_RequireTrigger;

	private MinMax m_CycleSpeedSeconds;

	private MinMax m_RotationSpeed;

	private float m_PositionOffset;

	private MinMax m_Width;

	private Vector3 m_Scale;

	private float m_VerticalPosition;

	private Transform[] m_Rays;

	private float m_FadeDistance;

	private bool m_DebugMode;

	private List<GodRayObject> m_RayObjects;

	private float m_MasterOpacity;

	private int m_TintID;

	private bool m_Initialized;

	private float m_TransitionFadeTarget;

	private Quaternion m_WorldLightRotation;

	private MaterialPropertyBlock m_PropBlock;

	private Quaternion m_LightRotationOffset;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GodRayObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 24)]
	private void Start()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GodRayObject), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public void StartRays()
	{
	}

	[CallerCount(Count = 0)]
	public void StopRays()
	{
	}

	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	public GodrayManager()
	{
	}
}
