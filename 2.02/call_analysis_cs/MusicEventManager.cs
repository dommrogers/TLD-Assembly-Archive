using System;
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MusicEventManager), Member = "CheckForHappySuccess")]
	[Calls(Type = typeof(MusicEventManager), Member = "CheckForSorrow")]
	[Calls(Type = typeof(MusicEventManager), Member = "CheckForRopeClimbStress")]
	[Calls(Type = typeof(MusicEventManager), Member = "CheckForBeingStalked")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsUnknownMethods(Count = 1)]
	public void PlaySorrowMusic()
	{
	}

	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(MusicEventManager), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Weather), Member = "IsClear")]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void CheckForHappySuccess()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(MusicEventManager), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "HasAffliction")]
	private void CheckForSorrow()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(MusicEventManager), Member = "Update")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetSprintStaminaRemainingAsPercentage")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void CheckForRopeClimbStress()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(MusicEventManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	private void CheckForBeingStalked()
	{
	}

	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(HUDManager), Member = "TrackIndoorLocation")]
	[CalledBy(Type = typeof(HUDManager), Member = "MaybeShowLocationReveal")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallerCount(Count = 3)]
	public void PlayLocationSound(bool hasPlayedBefore)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MusicEventManager()
	{
	}
}
