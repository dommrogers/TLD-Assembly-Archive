using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_PlayVideo : ActionTask
{
	public bool waitForComplete;

	public string videoPath;

	public bool stopAllPlayerAudio;

	public bool fadeOutOnStart;

	public bool fadeInOnComplete;

	public bool blackOutOnComplete;

	public float fadeSeconds;

	private static List<Action> m_OnMovieCompleteCallbacks;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterOnActionMovieCompleteCallback(Action onMovieCompleteCallback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void UnRegisterOnActionMovieCompleteCallback(Action onMovieCompleteCallback)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(Action_PlayVideo), Member = "PlayMovie")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessOnMovieCompleteCallback()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Action_PlayVideo), Member = "OnExecute")]
	[Calls(Type = typeof(Action_PlayVideo), Member = "OnMovieComplete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	private void PlayMovie()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	[Calls(Type = typeof(Action_PlayVideo), Member = "OnActionComplete")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(Action_PlayVideo), Member = "PlayMovie")]
	[CallsUnknownMethods(Count = 7)]
	private void OnMovieComplete()
	{
	}

	[Calls(Type = typeof(Action_PlayVideo), Member = "OnActionComplete")]
	[CallerCount(Count = 0)]
	private void OnFadeInComplete()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_PlayVideo), Member = "OnFadeInComplete")]
	[CalledBy(Type = typeof(Action_PlayVideo), Member = "OnMovieComplete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void OnActionComplete()
	{
	}

	[CallerCount(Count = 0)]
	public Action_PlayVideo()
	{
	}
}
