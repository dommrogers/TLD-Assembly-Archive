using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class SceneMusicManager : MonoBehaviour
{
	public static SceneMusicManager instance;

	public string m_SceneEnterMusic;

	public bool m_PlaySceneEnterEveryTime;

	public float m_DelaySecondsSceneEnterMusic;

	public ExploreMusic[] m_SceneExploreMusic;

	public float m_MinSecondsBetweenExploreMusic;

	public float m_MaxSecondsBetweenExploreMusic;

	private bool m_HasBeenPlayed;

	private float m_TimeToPlayNextExploreMusic;

	private float m_TimeToPlaySceneEnterMusic;

	private List<string> m_ExploreMusicDay;

	private List<string> m_ExploreMusicNight;

	private List<string> m_ExploreMusicAurora;

	private List<MusicSuppressor> m_MusicSuppressors;

	private bool m_MusicSuppressorInRange;

	public bool m_SupressExploreMusic;

	private static SceneMusicSaveData m_SceneMusicSaveData;

	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(Utils), Member = "IsSceneTransition")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(SceneMusicManager), Member = "ResetExploreMusicTimer")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(SceneMusicManager), Member = "PlayExploreMusic")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsUnknownMethods(Count = 12)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void AddMusicSuppressor(MusicSuppressor ms)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsUnknownMethods(Count = 1)]
	public void PlaySceneEnterMusic()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SceneMusicManager), Member = "Update")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_exploremusic")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(SceneMusicManager), Member = "ResetExploreMusicTimer")]
	public void PlayExploreMusic()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveMusicSuppressor(MusicSuppressor ms)
	{
	}

	[CalledBy(Type = typeof(SceneMusicManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ACtion_SuppressExploreMusic), Member = "OnExecute")]
	[CalledBy(Type = typeof(SceneMusicManager), Member = "PlayExploreMusic")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public void ResetExploreMusicTimer()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SceneMusicManager()
	{
	}
}
