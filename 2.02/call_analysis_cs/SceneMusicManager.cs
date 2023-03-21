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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneMusicManager), Member = "ResetExploreMusicTimer")]
	[Calls(Type = typeof(Utils), Member = "IsSceneTransition")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 29)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(SceneMusicManager), Member = "PlayExploreMusic")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 12)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AddMusicSuppressor(MusicSuppressor ms)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void PlaySceneEnterMusic()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_exploremusic")]
	[CalledBy(Type = typeof(SceneMusicManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SceneMusicManager), Member = "ResetExploreMusicTimer")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public void PlayExploreMusic()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveMusicSuppressor(MusicSuppressor ms)
	{
	}

	[CalledBy(Type = typeof(SceneMusicManager), Member = "Awake")]
	[CalledBy(Type = typeof(SceneMusicManager), Member = "PlayExploreMusic")]
	[CalledBy(Type = typeof(ACtion_SuppressExploreMusic), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ResetExploreMusicTimer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public SceneMusicManager()
	{
	}
}
