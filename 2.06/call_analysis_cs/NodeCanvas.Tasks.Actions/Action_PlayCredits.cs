using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.UI;
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
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsUnknownMethods(Count = 2)]
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
	[CallsUnknownMethods(Count = 7)]
	protected override void OnExecute()
	{
	}

	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference), Member = "Get")]
	[Calls(Type = typeof(PanelReference), Member = "TryGetPanel")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(Type = typeof(Action_PlayCredits), Member = "OnMovieStop")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void PlayNextSkippableMovie()
	{
	}

	[CalledBy(Type = typeof(Action_PlayCredits), Member = "PlayNextSkippableMovie")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference), Member = "Get")]
	[Calls(Type = typeof(PanelReference), Member = "TryGetPanel")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[Calls(Type = typeof(MoviePlayer), Member = "StopAudio")]
	[Calls(Type = typeof(Action_PlayCredits), Member = "PlayCredits")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnMovieStop()
	{
	}

	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnMovieStop")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "GetAudioEventFromFileName")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[Calls(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void PlayCredits()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	[Calls(Type = typeof(GameManager), Member = "OnGameQuit")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryDestroyPanel")]
	[CallsUnknownMethods(Count = 1)]
	private void OnCreditsEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	[Calls(Type = typeof(GameManager), Member = "OnGameQuit")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CallsUnknownMethods(Count = 1)]
	private void OnActionComplete()
	{
	}

	[CallerCount(Count = 0)]
	public Action_PlayCredits()
	{
	}
}
