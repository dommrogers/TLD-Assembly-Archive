using System;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class MusicEventManager : MonoBehaviour
{
	public AK.Wwise.Event m_OutdoorLocationFirstTime;

	public AK.Wwise.Event m_OutdoorLocationSubsequentTimes;

	public AK.Wwise.Event m_IndoorLocationFirstTime;

	public AK.Wwise.Event m_IndoorLocationSubsequentTimes;

	public string[] m_IndoorLocationsToPlaySound;

	public AK.Wwise.Event m_HappySuccessMusic;

	public float m_HappySuccessMinHoursBetween;

	public AK.Wwise.Event m_SorrowMusic;

	public float m_SorrowNumHoursWithAffliction;

	public float m_SorrowHealthThreshold;

	public float m_SorrowMinHoursBetween;

	public AK.Wwise.Event m_RopeStressMusic;

	public float m_RopeStressFatigueBarThreshold;

	public float m_RopeStressMinHoursBetween;

	public AK.Wwise.Event m_BeingStalkedMusic;

	public AK.Wwise.Event m_ExitStalkMusic;

	public AK.Wwise.Event m_EnterAttackMusic;

	public float m_BeingStalkedMinHoursBetween;

	private PanelReference<Panel_BodyHarvest> m_BodyHarvest;

	private PanelReference<Panel_FeedFire> m_FeedFire;

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

	[Calls(Type = typeof(MusicEventManager), Member = "CheckForRopeClimbStress")]
	[Calls(Type = typeof(MusicEventManager), Member = "CheckForSorrow")]
	[Calls(Type = typeof(MusicEventManager), Member = "CheckForBeingStalked")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MusicEventManager), Member = "CheckForHappySuccess")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void PlaySorrowMusic()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Weather), Member = "IsClear")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CalledBy(Type = typeof(MusicEventManager), Member = "Update")]
	[CallsUnknownMethods(Count = 17)]
	private void CheckForHappySuccess()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CalledBy(Type = typeof(MusicEventManager), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "HasAffliction")]
	private void CheckForSorrow()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CalledBy(Type = typeof(MusicEventManager), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	private void CheckForRopeClimbStress()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(MusicEventManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	private void CheckForBeingStalked()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(HUDManager), Member = "TrackIndoorLocation")]
	[CalledBy(Type = typeof(HUDManager._003CWaitToShowLocationReveal_003Ed__22), Member = "MoveNext")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	public void PlayLocationSound(bool hasPlayedBefore)
	{
	}

	[CallerCount(Count = 0)]
	public MusicEventManager()
	{
	}
}
