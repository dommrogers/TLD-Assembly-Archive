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
		[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void RegisterOnActionMovieCompleteCallback(Action onMovieCompleteCallback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void UnRegisterOnActionMovieCompleteCallback(Action onMovieCompleteCallback)
	{
	}

	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Action_PlayVideo), Member = "PlayMovie")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
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

	[CalledBy(Type = typeof(Action_PlayVideo), Member = "OnExecute")]
	[Calls(Type = typeof(Action_PlayVideo), Member = "OnMovieComplete")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	private void PlayMovie()
	{
	}

	[CalledBy(Type = typeof(Action_PlayVideo), Member = "PlayMovie")]
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	private void OnMovieComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_PlayVideo), Member = "OnActionComplete")]
	private void OnFadeInComplete()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
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
