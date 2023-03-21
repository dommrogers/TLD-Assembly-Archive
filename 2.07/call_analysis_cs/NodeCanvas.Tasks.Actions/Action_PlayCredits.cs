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
		[CallerCount(Count = 6)]
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
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Action_PlayCredits), Member = "PlayNextSkippableMovie")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(Type = typeof(Action_PlayCredits), Member = "OnMovieStop")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	private void PlayNextSkippableMovie()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "PlayNextSkippableMovie")]
	[Calls(Type = typeof(Action_PlayCredits), Member = "PlayCredits")]
	[Calls(Type = typeof(MoviePlayer), Member = "StopAudio")]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void OnMovieStop()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MoviePlayer), Member = "GetAudioEventFromFileName")]
	[Calls(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnMovieStop")]
	[CallsUnknownMethods(Count = 3)]
	private void PlayCredits()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[Calls(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	private void OnCreditsEnd()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[Calls(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	private void OnActionComplete()
	{
	}

	[CallerCount(Count = 0)]
	public Action_PlayCredits()
	{
	}
}
