using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Serialization;
using UnityEngine;

public class SceneMusicManager : MonoBehaviour
{
	public static SceneMusicManager instance;

	public AK.Wwise.Event m_SceneEnterMusicEvent;

	private string m_SceneEnterMusic;

	public bool m_PlaySceneEnterEveryTime;

	public float m_DelaySecondsSceneEnterMusic;

	public ExploreMusic[] m_SceneExploreMusic;

	public float m_MinSecondsBetweenExploreMusic;

	public float m_MaxSecondsBetweenExploreMusic;

	private bool m_HasBeenPlayed;

	private float m_TimeToPlayNextExploreMusic;

	private float m_TimeToPlaySceneEnterMusic;

	private List<AK.Wwise.Event> m_ExploreMusicDay;

	private List<AK.Wwise.Event> m_ExploreMusicNight;

	private List<AK.Wwise.Event> m_ExploreMusicAurora;

	private List<MusicSuppressor> m_MusicSuppressors;

	private bool m_MusicSuppressorInRange;

	public bool m_SupressExploreMusic;

	private static SceneMusicSaveData m_SceneMusicSaveData;

	[Calls(Type = typeof(Utils), Member = "IsSceneTransition")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(SceneMusicManager), Member = "ResetExploreMusicTimer")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(SceneMusicManager), Member = "PlayExploreMusic")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsUnknownMethods(Count = 14)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void AddMusicSuppressor(MusicSuppressor ms)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void PlaySceneEnterMusic()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SceneMusicManager), Member = "Update")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_exploremusic")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(SceneMusicManager), Member = "ResetExploreMusicTimer")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	public void PlayExploreMusic()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveMusicSuppressor(MusicSuppressor ms)
	{
	}

	[CalledBy(Type = typeof(SceneMusicManager), Member = "PlayExploreMusic")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ACtion_SuppressExploreMusic), Member = "OnExecute")]
	[CalledBy(Type = typeof(SceneMusicManager), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public void ResetExploreMusicTimer()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SceneMusicManager()
	{
	}
}
