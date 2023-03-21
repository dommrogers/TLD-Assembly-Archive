using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_PlayCredits : ActionTask
{
	[Serializable]
	public class VideoDefinition
	{
		public string m_VideoName;

		public string m_AudioEventName;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(Action_PlayCredits), Member = "PlayNextSkippableMovie")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	protected override void OnExecute()
	{
	}

	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(Type = typeof(Action_PlayCredits), Member = "OnMovieStop")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	private void PlayNextSkippableMovie()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "PlayNextSkippableMovie")]
	[CallerCount(Count = 1)]
	private void OnMovieStop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "GetAudioEventFromFileName")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[Calls(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void PlayCredits()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_PlayCredits), Member = "OnActionComplete")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryDestroyPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnCreditsEnd()
	{
	}

	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnCreditsEnd")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	[Calls(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "DoQuitGame")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void OnActionComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool AllowContinueToNextEpisode()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public Action_PlayCredits()
	{
	}
}
