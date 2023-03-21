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

		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(GodrayManager), Member = "Start")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 1)]
		public GodRayObject(Transform thisTransform, GameObject go)
		{
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 5)]
		[Calls(Type = typeof(Random), Member = "Range")]
		[Calls(Type = typeof(Random), Member = "Range")]
		[Calls(Type = typeof(Random), Member = "Range")]
		[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
		[Calls(Type = typeof(Random), Member = "Range")]
		[Calls(Type = typeof(Random), Member = "Range")]
		[CalledBy(Type = typeof(GodRayObject), Member = "Update")]
		[CallsUnknownMethods(Count = 6)]
		private void NewRay(GodrayManager manager)
		{
		}

		[CallsUnknownMethods(Count = 13)]
		[CalledBy(Type = typeof(GodrayManager), Member = "Update")]
		[Calls(Type = typeof(Transform), Member = "get_forward")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 9)]
		[Calls(Type = typeof(GodRayObject), Member = "NewRay")]
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
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GodRayObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 15)]
	private void Start()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GodRayObject), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public void StartRays()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void StopRays()
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public GodrayManager()
	{
	}
}
