using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.SaveState;
using UnityEngine;
using UnityEngine.Video;

public class MoviePlayer : MonoBehaviour
{
	public enum Options
	{
		None = 0,
		FillScreen = 1,
		RenderGameplay = 2,
		PlayAudio = 4,
		SuppressErrors = 8,
		WwiseAudio = 0x10,
		WaitFirstFrame = 0x20,
		NoUserInterrupt = 0x40,
		PrepareMovieOnly = 0x80,
		TryToUsePreparedMovie = 0x100,
		DoNotSyncToAudio = 0x200,
		DoNotStopAudio = 0x400
	}

	private enum State
	{
		Stopped,
		Preparing,
		Playing,
		Paused,
		Stopping
	}

	public delegate void OnPlaybackComplete();

	public static bool m_MovieInterrupted;

	public static bool m_MovieCancelledWithEscape;

	public static bool m_HasIntroPlayedForMainMenu;

	private static string m_AudioEventName;

	private static string m_Filename;

	private static string m_FullPath;

	private static Camera m_Camera;

	private static State m_State;

	private static State m_PrePauseState;

	private static Options m_Options;

	private static bool m_PlaybackFailed;

	private static bool m_RestorePause;

	private static bool m_RestoreAudio;

	public static bool m_IsSkippable;

	private static OnPlaybackComplete m_OnPlaybackComplete;

	private static VideoPlayer m_Player;

	private static readonly string SUBTITLE_EXTENSION;

	private const int MAX_SUBTITLES = 100;

	private static Utils.Subtitle[] m_Subtitles;

	private static uint m_NumSubtitles;

	private static long m_SubtitleFrameRate;

	private static string s_MoviePath;

	private static string s_SubtitlesPath;

	private static uint s_AudioPlayingID;

	private static long m_LastFrameId;

	private static Dictionary<string, string> s_FilePaths;

	private GameObject m_CameraPrefab;

	[CallerCount(Count = 0)]
	internal static string GetPlatformName()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "PopulateMovieOptions")]
	[CallsUnknownMethods(Count = 8)]
	public static string[] GetFilenameList()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static uint GetAudioPlayingID()
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePrepare")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "PlayCredits")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetAudioEventFromFileName(string fileName)
	{
		return null;
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "Play")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "TryToUsePreparedMovie")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[CallsUnknownMethods(Count = 2)]
	private static void SetupMovie(OnPlaybackComplete onPlaybackComplete, Options opts, string fullpath)
	{
	}

	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "BuildPathDictionary")]
	[CallsUnknownMethods(Count = 1)]
	private static string FindFullMoviePath(string filename)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(MoviePlayer), Member = "SetupMovie")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool TryToUsePreparedMovie(string fullpath, OnPlaybackComplete onPlaybackComplete, Options opts)
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Play(string filename, string audioEventName, OnPlaybackComplete onPlaybackComplete, Options opts = Options.None)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_PlayOverlayAlphaVideo), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayVideo), Member = "PlayMovie")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "PlayNextSkippableMovie")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventPrepareMovie")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_movie_alpha_ext")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_movie_alpha")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_movie")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "PlayIntroMovie")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventPlayMovie")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyPlayMovie")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[Calls(Type = typeof(MoviePlayer), Member = "BuildPathDictionary")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(MoviePlayer), Member = "SetupMovie")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void Play(string filename, OnPlaybackComplete onPlaybackComplete, Options opts = Options.None)
	{
	}

	[Calls(Type = typeof(MoviePlayer), Member = "IsUsingWwiseAudio")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(Type = typeof(MoviePlayer), Member = "Stop")]
	[Calls(Type = typeof(InterfaceManager), Member = "HidePanelsForSubtitle")]
	[Calls(Type = typeof(GameAudioManager), Member = "MuteGameplayAudio")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(MoviePlayer), Member = "SetupMovie")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(File), Member = "Exists")]
	public static void PlayMovieFromFullPath(OnPlaybackComplete onPlaybackComplete, Options opts, string fullpath, string filename)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "EventStopMovie")]
	[CalledBy(Type = typeof(Action_StopVideo), Member = "OnExecute")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(MoviePlayer), Member = "DoStop")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	public static void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[CallsUnknownMethods(Count = 2)]
	public static float GetCurrentMovieDurationSeconds()
	{
		return default(float);
	}

	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	public static bool IsPreparingPending()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsPreparingReady()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "EventPlayMovie")]
	[CalledBy(Type = typeof(CinematicManager), Member = "MaybeSeekMovie")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	public static void Seek(float newTime)
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Awake")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Seek")]
	[CalledBy(Type = typeof(CinematicManager), Member = "MaybeSeekMovie")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Stop")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "GetCurrentMovieDurationSeconds")]
	public static bool IsInitialized()
	{
		return default(bool);
	}

	[CallerCount(Count = 25)]
	public static bool IsPlaying()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[CalledBy(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	public static bool IsPaused()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool IsScreenFilled()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	public static bool IsGameplayRendering()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool IsAudioEnabled()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePrepare")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	public static bool IsUsingWwiseAudio()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool SuppressingErrors()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool ShouldWaitFirstFrame()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool ShouldPrepareMovieOnly()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool HasNoUserInterrupt()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool ShouldTryToUsePreparedMovie(Options opts)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePrepare")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "OnAkVoiceEvent")]
	public static bool ShouldSyncToAudio()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool ShouldStopAudio()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "BuildPathDictionary")]
	[Calls(Type = typeof(MoviePlayer), Member = "InstantiateCameraForPlayer")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "UnPauseAudio")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MoviePlayer), Member = "UpdatePrepare")]
	[Calls(Type = typeof(MoviePlayer), Member = "DoStop")]
	[Calls(Type = typeof(MoviePlayer), Member = "UpdatePlayback")]
	[Calls(Type = typeof(MoviePlayer), Member = "GetCurrentFrame")]
	[Calls(Type = typeof(MoviePlayer), Member = "GetCurrentFrame")]
	[Calls(Type = typeof(MoviePlayer), Member = "GetCurrentFrame")]
	[Calls(Type = typeof(VideoPlayer), Member = "Play")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "DoStop")]
	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudioImmediate")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(MoviePlayer), Member = "CheckForInterrupt")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	private void Update()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "GetInteractPressed")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[CallerCount(Count = 1)]
	private bool CheckForInterrupt()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudioImmediate")]
	[CallsUnknownMethods(Count = 2)]
	private void CheckForPause()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "OnLoopPointReached")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "OnLoopPointReached")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Stop")]
	[Calls(Type = typeof(ProfileState), Member = "AddViewedCinematic")]
	[Calls(Type = typeof(GameAudioManager), Member = "UnmuteGameplayAudio")]
	[Calls(Type = typeof(InterfaceManager), Member = "RestorePanelsAfterSubtitle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MoviePlayer), Member = "StopAudio")]
	private static void DoStop()
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "DoStop")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnMovieStop")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 2)]
	public static void StopAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(VideoPlayer), Member = "Play")]
	[Calls(Type = typeof(GameAudioManager), Member = "UnPauseAudio")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdatePause()
	{
	}

	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[Calls(Type = typeof(VideoPlayer), Member = "set_externalReferenceTime")]
	[Calls(Type = typeof(VideoPlayer), Member = "set_timeReference")]
	[Calls(Type = typeof(MoviePlayer), Member = "ShouldSyncToAudio")]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[Calls(Type = typeof(MoviePlayer), Member = "GetAudioEventFromFileName")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsUsingWwiseAudio")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	private void UpdatePrepare()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[Calls(Type = typeof(MoviePlayer), Member = "GetCurrentFrame")]
	[Calls(Type = typeof(VideoPlayer), Member = "set_externalReferenceTime")]
	[Calls(Type = typeof(Utils), Member = "UpdateSubtitles")]
	[Calls(Type = typeof(MoviePlayer), Member = "GetCurrentFrame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdatePlayback()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Awake")]
	[CallsUnknownMethods(Count = 18)]
	private void InstantiateCameraForPlayer()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "BuildPathDictionary")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Path), Member = "GetExtension")]
	private static bool ShouldReplacePathEntry(FileInfo fi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Awake")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Play")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "FindFullMoviePath")]
	[Calls(Type = typeof(MoviePlayer), Member = "ShouldReplacePathEntry")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(Path), Member = "GetExtension")]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	private static void BuildPathDictionary()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	private static void OnErrorReceived(VideoPlayer source, string message)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "DoStop")]
	[CallerCount(Count = 0)]
	private void OnLoopPointReached(VideoPlayer vp)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "DoStop")]
	private static void OnLoopPointReached()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private static void LogError(string err)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "ShouldSyncToAudio")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "get_playingID")]
	[CallsUnknownMethods(Count = 2)]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePlayback")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePlayback")]
	[CallsUnknownMethods(Count = 2)]
	private long GetCurrentFrame()
	{
		return default(long);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private long GetLastFrame()
	{
		return default(long);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MoviePlayer()
	{
	}
}
