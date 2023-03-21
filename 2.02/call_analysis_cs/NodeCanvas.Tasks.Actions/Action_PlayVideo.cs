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
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterOnActionMovieCompleteCallback(Action onMovieCompleteCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void UnRegisterOnActionMovieCompleteCallback(Action onMovieCompleteCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[Calls(Type = typeof(Action_PlayVideo), Member = "PlayMovie")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessOnMovieCompleteCallback()
	{
	}

	[CalledBy(Type = typeof(Action_PlayVideo), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(Type = typeof(Action_PlayVideo), Member = "OnMovieComplete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void PlayMovie()
	{
	}

	[CalledBy(Type = typeof(Action_PlayVideo), Member = "PlayMovie")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	[Calls(Type = typeof(Action_PlayVideo), Member = "OnActionComplete")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void OnMovieComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_PlayVideo), Member = "OnActionComplete")]
	private void OnFadeInComplete()
	{
	}

	[CalledBy(Type = typeof(Action_PlayVideo), Member = "OnMovieComplete")]
	[CalledBy(Type = typeof(Action_PlayVideo), Member = "OnFadeInComplete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnActionComplete()
	{
	}

	[CallerCount(Count = 0)]
	public Action_PlayVideo()
	{
	}
}
