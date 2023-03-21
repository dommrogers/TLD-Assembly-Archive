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

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "PopulateMovieOptions")]
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
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	public static string GetAudioEventFromFileName(string fileName)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "TryToUsePreparedMovie")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Play")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[CallsUnknownMethods(Count = 2)]
	private static void SetupMovie(OnPlaybackComplete onPlaybackComplete, Options opts, string fullpath)
	{
	}

	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "BuildPathDictionary")]
	private static string FindFullMoviePath(string filename)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "SetupMovie")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	public static bool TryToUsePreparedMovie(string fullpath, OnPlaybackComplete onPlaybackComplete, Options opts)
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Play(string filename, string audioEventName, OnPlaybackComplete onPlaybackComplete, Options opts = Options.None)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_movie_alpha_ext")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventPlayMovie")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "PlayNextSkippableMovie")]
	[CalledBy(Type = typeof(Action_PlayVideo), Member = "PlayMovie")]
	[CalledBy(Type = typeof(Action_PlayOverlayAlphaVideo), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_movie")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventPrepareMovie")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "PlayIntroMovie")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_movie_alpha")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyPlayMovie")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[Calls(Type = typeof(MoviePlayer), Member = "BuildPathDictionary")]
	[Calls(Type = typeof(MoviePlayer), Member = "SetupMovie")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	public static void Play(string filename, OnPlaybackComplete onPlaybackComplete, Options opts = Options.None)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(Type = typeof(MoviePlayer), Member = "Stop")]
	[Calls(Type = typeof(InterfaceManager), Member = "HidePanelsForSubtitle")]
	[Calls(Type = typeof(GameAudioManager), Member = "MuteGameplayAudio")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsUsingWwiseAudio")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[Calls(Type = typeof(MoviePlayer), Member = "SetupMovie")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	public static void PlayMovieFromFullPath(OnPlaybackComplete onPlaybackComplete, Options opts, string fullpath, string filename)
	{
	}

	[CalledBy(Type = typeof(Action_StopVideo), Member = "OnExecute")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventStopMovie")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[Calls(Type = typeof(MoviePlayer), Member = "DoStop")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[CalledBy(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[CallerCount(Count = 1)]
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

	[CalledBy(Type = typeof(CinematicManager), Member = "MaybeSeekMovie")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventPlayMovie")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	public static void Seek(float newTime)
	{
	}

	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Stop")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "GetCurrentMovieDurationSeconds")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Seek")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Awake")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(CinematicManager), Member = "MaybeSeekMovie")]
	public static bool IsInitialized()
	{
		return default(bool);
	}

	[CallerCount(Count = 25)]
	public static bool IsPlaying()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[CallerCount(Count = 2)]
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

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePrepare")]
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
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(MoviePlayer), Member = "BuildPathDictionary")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(MoviePlayer), Member = "InstantiateCameraForPlayer")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MoviePlayer), Member = "UpdatePrepare")]
	[Calls(Type = typeof(MoviePlayer), Member = "UpdatePlayback")]
	[Calls(Type = typeof(MoviePlayer), Member = "GetCurrentFrame")]
	[Calls(Type = typeof(MoviePlayer), Member = "GetCurrentFrame")]
	[Calls(Type = typeof(MoviePlayer), Member = "GetCurrentFrame")]
	[Calls(Type = typeof(GameAudioManager), Member = "UnPauseAudio")]
	[Calls(Type = typeof(VideoPlayer), Member = "Play")]
	[Calls(Type = typeof(MoviePlayer), Member = "DoStop")]
	[Calls(Type = typeof(MoviePlayer), Member = "DoStop")]
	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudioImmediate")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(MoviePlayer), Member = "CheckForInterrupt")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "GetInteractPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
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

	[CalledBy(Type = typeof(MoviePlayer), Member = "Stop")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "OnLoopPointReached")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[Calls(Type = typeof(MoviePlayer), Member = "StopAudio")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "OnLoopPointReached")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(ProfileState), Member = "AddViewedCinematic")]
	[Calls(Type = typeof(InterfaceManager), Member = "RestorePanelsAfterSubtitle")]
	[Calls(Type = typeof(GameAudioManager), Member = "UnmuteGameplayAudio")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 5)]
	private static void DoStop()
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "DoStop")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnMovieStop")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
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

	[Calls(Type = typeof(VideoPlayer), Member = "set_timeReference")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(MoviePlayer), Member = "ShouldSyncToAudio")]
	[Calls(Type = typeof(VideoPlayer), Member = "set_externalReferenceTime")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(MoviePlayer), Member = "GetAudioEventFromFileName")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsUsingWwiseAudio")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	private void UpdatePrepare()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(MoviePlayer), Member = "GetCurrentFrame")]
	[Calls(Type = typeof(VideoPlayer), Member = "set_externalReferenceTime")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[Calls(Type = typeof(MoviePlayer), Member = "GetCurrentFrame")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "UpdateSubtitles")]
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

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "BuildPathDictionary")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(Path), Member = "GetExtension")]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	private static void BuildPathDictionary()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePlayback")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePlayback")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	private long GetCurrentFrame()
	{
		return default(long);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
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
