using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class FlyOver : MonoBehaviour
{
	public GameObject[] m_FormationPrefabs;

	public float m_FormationHeightMin;

	public float m_FormationHeightMax;

	public float m_XZDistanceSpawn;

	public float m_XZDistanceRemove;

	public float m_SpeedMin;

	public float m_SpeedMax;

	public float m_SecondsBetweenFlyoversMin;

	public float m_SecondsBetweenFlyoversMax;

	public float m_ClearFlightRadius;

	public float m_ClearFlightLimitRatio;

	public float m_HeightTransitionSpeedFactor;

	private GameObject m_FormationInstance;

	private float m_Speed;

	private float m_FormationHeight;

	private float m_CurrentFlightRadius;

	private uint m_LoopAudioID;

	private float m_SecondsBetweenFlyovers;

	private float m_SecondsSinceLastFlyover;

	private float m_InitialRandomFlockHeight;

	private bool m_DirectionLocked;

	private bool m_StartHasBeenCalled;

	public static bool m_AlwaysSelectFrontPosition;

	public static float m_DebugAngle;

	private static FlyoverDataProxy m_FlyoverDataProxy;

	private const float MAX_FLOCK_HEIGHT = 1000f;

	private const float FLOCK_HEIGHT = 6f;

	private Vector3 m_LastCheckedPoint;

	private float m_CurrentHeightTransitionSpeedFactor;

	private float m_CurrentHeightTransitionSpeedDamping;

	private Quaternion m_TowardPlayerHorizontalOrientation;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FlyOver), Member = "ResetFlyoverTimer")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FlyOver), Member = "MaybeSpawnFlyover")]
	[Calls(Type = typeof(FlyOver), Member = "MoveFlyover")]
	[Calls(Type = typeof(FlyOver), Member = "MaybeDestroyFlyover")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FlyOver), Member = "ResetFlyoverTimer")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public void SetFlyoverTimeToMax()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[CallsUnknownMethods(Count = 1)]
	private bool HasClearFlightPath(Vector3 start, Vector3 dir)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(FlyOver), Member = "MoveFlyover")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(FlyOver), Member = "MaybeSpawnFlyover")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Carrion), Member = "Create")]
	public static bool TryGetClearFlightHeight(Vector3 center, float radius, out float height, out float updatedRadius)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref height) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref updatedRadius) = null;
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[CalledBy(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[CalledBy(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[CallsUnknownMethods(Count = 1)]
	public static GameObject GetCurrentFormation()
	{
		return null;
	}

	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(FlyOver), Member = "ResetFlyoverTimer")]
	[CalledBy(Type = typeof(FlyOver), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(FlyOver), Member = "TryGetClearFlightHeight")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(FlyOver), Member = "CanSpawnFlyover")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Random), Member = "get_insideUnitCircle")]
	[Calls(Type = typeof(Random), Member = "Range")]
	private void MaybeSpawnFlyover()
	{
	}

	[Calls(Type = typeof(FlyOver), Member = "TryGetClearFlightHeight")]
	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(FlyOver), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(Transform), Member = "RotateAround")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void MoveFlyover()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(FlyOver), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	private void MaybeDestroyFlyover()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(FlyOver), Member = "MaybeSpawnFlyover")]
	[Calls(Type = typeof(Weather), Member = "IsSnowing")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private bool CanSpawnFlyover()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FlyOver), Member = "MaybeSpawnFlyover")]
	[CalledBy(Type = typeof(FlyOver), Member = "Deserialize")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(FlyOver), Member = "Start")]
	private void ResetFlyoverTimer()
	{
	}

	[CallerCount(Count = 0)]
	public FlyOver()
	{
	}
}
