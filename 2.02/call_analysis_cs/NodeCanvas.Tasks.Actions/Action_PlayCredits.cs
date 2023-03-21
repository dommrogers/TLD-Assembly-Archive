using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_PlayCredits : ActionTask
{
	[Serializable]
	public class VideoDefinition
	{
		public string m_VideoName;

		public string m_AudioEventName;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public VideoDefinition()
		{
		}
	}

	public int m_EpisodeIndex;

	public VideoDefinition[] m_Videos;

	public bool m_ContinueMusicFromVideo;

	public int m_MusicStartOffsetMs;

	public bool stopAllPlayerAudio;

	public bool fade;

	public float fadeSeconds;

	public bool legacyAdjustHUDAlpha;

	private bool m_QuitToMainMenu;

	private int m_CurrentVideoIndex;

	private string m_MusicID;

	private int m_MusicStartOffset;

	private uint m_MusicPlayingID;

	protected override string info
	{
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(Action_PlayCredits), Member = "PlayNextSkippableMovie")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsUnknownMethods(Count = 9)]
	protected override void OnExecute()
	{
	}

	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnExecute")]
	[Calls(Type = typeof(Action_PlayCredits), Member = "OnMovieStop")]
	[CallsUnknownMethods(Count = 12)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	private void PlayNextSkippableMovie()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "PlayNextSkippableMovie")]
	private void OnMovieStop()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(MoviePlayer), Member = "GetAudioEventFromFileName")]
	[Calls(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void PlayCredits()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Action_PlayCredits), Member = "OnActionComplete")]
	private void OnCreditsEnd()
	{
	}

	[Calls(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnCreditsEnd")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "DoQuitGame")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	private void OnActionComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	private bool AllowContinueToNextEpisode()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public Action_PlayCredits()
	{
	}
}
