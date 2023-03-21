using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MusicEventManager : MonoBehaviour
{
	public string m_OutdoorLocationFirstTime;

	public string m_OutdoorLocationSubsequentTimes;

	public string m_IndoorLocationFirstTime;

	public string m_IndoorLocationSubsequentTimes;

	public string[] m_IndoorLocationsToPlaySound;

	public string m_HappySuccessMusic;

	public float m_HappySuccessMinHoursBetween;

	public string m_SorrowMusic;

	public float m_SorrowNumHoursWithAffliction;

	public float m_SorrowHealthThreshold;

	public float m_SorrowMinHoursBetween;

	public string m_RopeStressMusic;

	public float m_RopeStressFatigueBarThreshold;

	public float m_RopeStressMinHoursBetween;

	public string m_BeingStalkedMusic;

	public string m_ExitStalkMusic;

	public string m_EnterAttackMusic;

	public float m_BeingStalkedMinHoursBetween;

	private float m_HappySuccessLastPlayTime;

	private float m_SorrowLastPlayTime;

	private float m_RopeClimbStressLastPlayTime;

	private float m_BeingStalkedLastPlayTime;

	private float m_NumHoursWithAffliction;

	private bool m_WasBeingStalkedLastFrame;

	private bool m_WasBeingAttackedLastFrame;

	private bool m_MusicPlayedThisStalk;

	private static MusicEventSaveData m_MusicEventSaveData;

	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MusicEventManager), Member = "CheckForHappySuccess")]
	[Calls(Type = typeof(MusicEventManager), Member = "CheckForSorrow")]
	[Calls(Type = typeof(MusicEventManager), Member = "CheckForRopeClimbStress")]
	[Calls(Type = typeof(MusicEventManager), Member = "CheckForBeingStalked")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
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
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void PlaySorrowMusic()
	{
	}

	[CalledBy(Type = typeof(MusicEventManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Weather), Member = "IsClear")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 34)]
	private void CheckForHappySuccess()
	{
	}

	[CalledBy(Type = typeof(MusicEventManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Condition), Member = "HasAffliction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	private void CheckForSorrow()
	{
	}

	[CalledBy(Type = typeof(MusicEventManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetSprintStaminaRemainingAsPercentage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void CheckForRopeClimbStress()
	{
	}

	[CalledBy(Type = typeof(MusicEventManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 20)]
	private void CheckForBeingStalked()
	{
	}

	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(HUDManager), Member = "MaybeShowLocationReveal")]
	[CalledBy(Type = typeof(HUDManager), Member = "TrackIndoorLocation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public void PlayLocationSound(bool hasPlayedBefore)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public MusicEventManager()
	{
	}
}
