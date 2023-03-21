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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FlyOver), Member = "MaybeSpawnFlyover")]
	[Calls(Type = typeof(FlyOver), Member = "MoveFlyover")]
	[Calls(Type = typeof(FlyOver), Member = "MaybeDestroyFlyover")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FlyOver), Member = "ResetFlyoverTimer")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public void SetFlyoverTimeToMax()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasClearFlightPath(Vector3 start, Vector3 dir)
	{
		return false;
	}

	[CalledBy(Type = typeof(Carrion), Member = "Create")]
	[CalledBy(Type = typeof(FlyOver), Member = "MaybeSpawnFlyover")]
	[CalledBy(Type = typeof(FlyOver), Member = "MoveFlyover")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[Calls(Type = typeof(Vector3), Member = "Magnitude")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool TryGetClearFlightHeight(Vector3 center, float radius, out float height, out float updatedRadius)
	{
		height = default(float);
		updatedRadius = default(float);
		return false;
	}

	[CalledBy(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static GameObject GetCurrentFormation()
	{
		return null;
	}

	[CalledBy(Type = typeof(FlyOver), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FlyOver), Member = "CanSpawnFlyover")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Random), Member = "get_insideUnitCircle")]
	[Calls(Type = typeof(Vector2), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(FlyOver), Member = "TryGetClearFlightHeight")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(FlyOver), Member = "ResetFlyoverTimer")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 21)]
	private void MaybeSpawnFlyover()
	{
	}

	[CalledBy(Type = typeof(FlyOver), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(FlyOver), Member = "TryGetClearFlightHeight")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "RotateAround")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 59)]
	private void MoveFlyover()
	{
	}

	[CalledBy(Type = typeof(FlyOver), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 18)]
	private void MaybeDestroyFlyover()
	{
	}

	[CalledBy(Type = typeof(FlyOver), Member = "MaybeSpawnFlyover")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(Weather), Member = "IsSnowing")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private bool CanSpawnFlyover()
	{
		return false;
	}

	[CalledBy(Type = typeof(FlyOver), Member = "Start")]
	[CalledBy(Type = typeof(FlyOver), Member = "Deserialize")]
	[CalledBy(Type = typeof(FlyOver), Member = "MaybeSpawnFlyover")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ResetFlyoverTimer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FlyOver()
	{
	}
}
