using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using Steamworks;
using UnityEngine;

public class SteamManager : MonoBehaviour
{
	public delegate void OnGameOverlayActivatedDelegate(bool activated);

	private bool m_Initialized;

	private bool m_DoneStatsInit;

	private static SteamManager _003CInstance_003Ek__BackingField;

	private static bool _003CIsOverlayActive_003Ek__BackingField;

	public uint SteamAppID;

	private Callback<GameOverlayActivated_t> m_OnGameOverlayActivatedCallback;

	public static SteamManager Instance
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static bool Initialized
	{
		[CalledBy(Type = typeof(SteamManager), Member = "IsRunningOnSteamDeck")]
		[CalledBy(Type = typeof(SteamManager), Member = "Update")]
		[CalledBy(Type = typeof(SteamRichPresenceProvider), Member = "ChangePresence")]
		[CalledBy(Type = typeof(SteamRichPresenceProvider), Member = "IsUserSignedOn")]
		[CalledBy(Type = typeof(InputSystemRewired), Member = "InitializeSteamController")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CanLockFPS")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateDisplayMenuItems")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVsync")]
		[CalledBy(Type = typeof(TextInputField), Member = "Select")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Unlock")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "SendStatistic")]
		[CallerCount(Count = 17)]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "ResetAllAchievements")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Initialize")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "RequestStatsAndAchievements")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Update")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Shutdown")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Update")]
		get
		{
			return default(bool);
		}
	}

	public static bool IsOverlayActive
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static event OnGameOverlayActivatedDelegate s_OnGameOverlayActivated
	{
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DontDestroyOnLoad")]
	[Calls(Type = typeof(SteamUser), Member = "BLoggedOn")]
	[Calls(Type = typeof(CallbackDispatcher), Member = "Initialize")]
	[Calls(Type = typeof(Application), Member = "Quit")]
	[Calls(Type = typeof(Steamworks.CSteamAPIContext), Member = "Init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Marshal), Member = "SizeOf")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "SizeOf")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(CallbackDispatcher), Member = "RunFrame")]
	private void Update()
	{
	}

	[Calls(Type = typeof(CallbackDispatcher), Member = "Shutdown")]
	[Calls(Type = typeof(CallbackDispatcher), Member = "Unregister")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Steamworks.CSteamAPIContext), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	private void OnGameOverlayActivated(GameOverlayActivated_t args)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(Steamworks.NativeMethods), Member = "ISteamUtils_IsSteamRunningOnSteamDeck")]
	public static bool IsRunningOnSteamDeck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SteamManager()
	{
	}
}
