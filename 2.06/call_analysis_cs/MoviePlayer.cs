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

	[CalledBy(Type = typeof(Panel_Debug), Member = "PopulateMovieOptions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 9)]
	public static string[] GetFilenameList()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static uint GetAudioPlayingID()
	{
		return 0u;
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePrepare")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "PlayCredits")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetAudioEventFromFileName(string fileName)
	{
		return null;
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "TryToUsePreparedMovie")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Play")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetupMovie(OnPlaybackComplete onPlaybackComplete, Options opts, string fullpath)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "BuildPathDictionary")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsUnknownMethods(Count = 1)]
	private static string FindFullMoviePath(string filename)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "SetupMovie")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool TryToUsePreparedMovie(string fullpath, OnPlaybackComplete onPlaybackComplete, Options opts)
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Play(string filename, string audioEventName, OnPlaybackComplete onPlaybackComplete, Options opts = Options.None)
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyPlayMovie")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "PlayIntroMovie")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_movie")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_movie_alpha")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_movie_alpha_ext")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventPlayMovie")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventPrepareMovie")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "PlayNextSkippableMovie")]
	[CalledBy(Type = typeof(Action_PlayVideo), Member = "PlayMovie")]
	[CalledBy(Type = typeof(Action_PlayOverlayAlphaVideo), Member = "OnExecute")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(MoviePlayer), Member = "BuildPathDictionary")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(MoviePlayer), Member = "SetupMovie")]
	[Calls(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static void Play(string filename, OnPlaybackComplete onPlaybackComplete, Options opts = Options.None)
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "Play")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MoviePlayer), Member = "SetupMovie")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsUsingWwiseAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "MuteGameplayAudio")]
	[Calls(Type = typeof(InterfaceManager), Member = "HidePanelsForSubtitle")]
	[Calls(Type = typeof(MoviePlayer), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	public static void PlayMovieFromFullPath(OnPlaybackComplete onPlaybackComplete, Options opts, string fullpath, string filename)
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventStopMovie")]
	[CalledBy(Type = typeof(Action_StopVideo), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(MoviePlayer), Member = "DoStop")]
	public static void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static float GetCurrentMovieDurationSeconds()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsPreparingPending()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsPreparingReady()
	{
		return false;
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "EventPlayMovie")]
	[CalledBy(Type = typeof(CinematicManager), Member = "MaybeSeekMovie")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public static void Seek(float newTime)
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "Stop")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "GetCurrentMovieDurationSeconds")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Seek")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Awake")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(CinematicManager), Member = "MaybeSeekMovie")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static bool IsInitialized()
	{
		return false;
	}

	[CallerCount(Count = 25)]
	public static bool IsPlaying()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[CalledBy(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[CallerCount(Count = 2)]
	public static bool IsPaused()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool IsScreenFilled()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallerCount(Count = 2)]
	public static bool IsGameplayRendering()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool IsAudioEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePrepare")]
	[CallerCount(Count = 2)]
	public static bool IsUsingWwiseAudio()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool SuppressingErrors()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool ShouldWaitFirstFrame()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool ShouldPrepareMovieOnly()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool HasNoUserInterrupt()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool ShouldTryToUsePreparedMovie(Options opts)
	{
		return false;
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePrepare")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "OnAkVoiceEvent")]
	[CallerCount(Count = 2)]
	public static bool ShouldSyncToAudio()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool ShouldStopAudio()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(MoviePlayer), Member = "InstantiateCameraForPlayer")]
	[Calls(Type = typeof(MoviePlayer), Member = "BuildPathDictionary")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	[Calls(Type = typeof(MoviePlayer), Member = "CheckForInterrupt")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudioImmediate")]
	[Calls(Type = typeof(MoviePlayer), Member = "DoStop")]
	[Calls(Type = typeof(VideoPlayer), Member = "Play")]
	[Calls(Type = typeof(GameAudioManager), Member = "UnPauseAudio")]
	[Calls(Type = typeof(MoviePlayer), Member = "GetCurrentFrame")]
	[Calls(Type = typeof(MoviePlayer), Member = "UpdatePlayback")]
	[Calls(Type = typeof(MoviePlayer), Member = "UpdatePrepare")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInteractPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool CheckForInterrupt()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudioImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void CheckForPause()
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "Stop")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "OnLoopPointReached")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "OnLoopPointReached")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InterfaceManager), Member = "RestorePanelsAfterSubtitle")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(ProfileState), Member = "AddViewedCinematic")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "UnmuteGameplayAudio")]
	[Calls(Type = typeof(MoviePlayer), Member = "StopAudio")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
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

	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsUsingWwiseAudio")]
	[Calls(Type = typeof(MoviePlayer), Member = "GetAudioEventFromFileName")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(MoviePlayer), Member = "ShouldSyncToAudio")]
	[Calls(Type = typeof(VideoPlayer), Member = "set_timeReference")]
	[Calls(Type = typeof(VideoPlayer), Member = "set_externalReferenceTime")]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdatePrepare()
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "GetCurrentFrame")]
	[Calls(Type = typeof(Utils), Member = "UpdateSubtitles")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	[Calls(Type = typeof(VideoPlayer), Member = "set_externalReferenceTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdatePlayback()
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 28)]
	private void InstantiateCameraForPlayer()
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "BuildPathDictionary")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[Calls(Type = typeof(Path), Member = "GetExtension")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool ShouldReplacePathEntry(FileInfo fi)
	{
		return false;
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "FindFullMoviePath")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Play")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Awake")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
	[Calls(Type = typeof(Path), Member = "GetExtension")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(MoviePlayer), Member = "ShouldReplacePathEntry")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	private static void BuildPathDictionary()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static void OnErrorReceived(VideoPlayer source, string message)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MoviePlayer), Member = "DoStop")]
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

	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePlayback")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private long GetCurrentFrame()
	{
		return 0L;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private long GetLastFrame()
	{
		return 0L;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public MoviePlayer()
	{
	}
}
