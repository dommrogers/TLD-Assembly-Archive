using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(FlyOver), Member = "MaybeSpawnFlyover")]
	[Calls(Type = typeof(FlyOver), Member = "MoveFlyover")]
	[Calls(Type = typeof(FlyOver), Member = "MaybeDestroyFlyover")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(FlyOver), Member = "ResetFlyoverTimer")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public void SetFlyoverTimeToMax()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private bool HasClearFlightPath(Vector3 start, Vector3 dir)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[CalledBy(Type = typeof(FlyOver), Member = "MoveFlyover")]
	[CalledBy(Type = typeof(FlyOver), Member = "MaybeSpawnFlyover")]
	[CalledBy(Type = typeof(Carrion), Member = "Create")]
	[Calls(Type = typeof(Vector3), Member = "Magnitude")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	public static bool TryGetClearFlightHeight(Vector3 center, float radius, out float height, out float updatedRadius)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref height) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref updatedRadius) = null;
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[CalledBy(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	public static GameObject GetCurrentFormation()
	{
		return null;
	}

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(FlyOver), Member = "TryGetClearFlightHeight")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector2), Member = "Normalize")]
	[CalledBy(Type = typeof(FlyOver), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(FlyOver), Member = "CanSpawnFlyover")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FlyOver), Member = "ResetFlyoverTimer")]
	[Calls(Type = typeof(Random), Member = "get_insideUnitCircle")]
	[CallsUnknownMethods(Count = 21)]
	private void MaybeSpawnFlyover()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(FlyOver), Member = "TryGetClearFlightHeight")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "RotateAround")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CalledBy(Type = typeof(FlyOver), Member = "Update")]
	[CallsUnknownMethods(Count = 59)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 26)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	private void MoveFlyover()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(FlyOver), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	private void MaybeDestroyFlyover()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(FlyOver), Member = "MaybeSpawnFlyover")]
	[Calls(Type = typeof(Weather), Member = "IsSnowing")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool CanSpawnFlyover()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(FlyOver), Member = "MaybeSpawnFlyover")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CalledBy(Type = typeof(FlyOver), Member = "Deserialize")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CalledBy(Type = typeof(FlyOver), Member = "Start")]
	private void ResetFlyoverTimer()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public FlyOver()
	{
	}
}
