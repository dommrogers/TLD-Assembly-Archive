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
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterOnActionMovieCompleteCallback(Action onMovieCompleteCallback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void UnRegisterOnActionMovieCompleteCallback(Action onMovieCompleteCallback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[Calls(Type = typeof(Action_PlayVideo), Member = "PlayMovie")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessOnMovieCompleteCallback()
	{
	}

	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(Action_PlayVideo), Member = "OnExecute")]
	[Calls(Type = typeof(Action_PlayVideo), Member = "OnActionComplete")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	private void PlayMovie()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void OnMovieComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_PlayVideo), Member = "OnActionComplete")]
	private void OnFadeInComplete()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Action_PlayVideo), Member = "PlayMovie")]
	[CalledBy(Type = typeof(Action_PlayVideo), Member = "OnFadeInComplete")]
	[CallsUnknownMethods(Count = 2)]
	private void OnActionComplete()
	{
	}

	[CallerCount(Count = 0)]
	public Action_PlayVideo()
	{
	}
}
