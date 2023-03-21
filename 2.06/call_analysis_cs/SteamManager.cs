using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Hint;
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
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool Initialized
	{
		[CalledBy(Type = typeof(SteamManager), Member = "IsRunningOnSteamDeck")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVsync")]
		[CalledBy(Type = typeof(SteamManager), Member = "Update")]
		[CalledBy(Type = typeof(SteamRichPresenceProvider), Member = "ChangePresence")]
		[CalledBy(Type = typeof(SteamRichPresenceProvider), Member = "IsUserSignedOn")]
		[CalledBy(Type = typeof(InputSystemRewired), Member = "InitializeSteamController")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CanLockFPS")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateDisplayMenuItems")]
		[CalledBy(Type = typeof(TextInputField), Member = "Select")]
		[CallerCount(Count = 17)]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "SendStatistic")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Unlock")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Shutdown")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Update")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Update")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Initialize")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "ResetAllAchievements")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "RequestStatsAndAchievements")]
		get
		{
			return default(bool);
		}
	}

	public static bool IsOverlayActive
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
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
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DontDestroyOnLoad")]
	[Calls(Type = typeof(SteamUser), Member = "BLoggedOn")]
	[Calls(Type = typeof(Steamworks.CSteamAPIContext), Member = "Init")]
	[Calls(Type = typeof(CallbackDispatcher), Member = "Initialize")]
	[Calls(Type = typeof(Packsize), Member = "Test")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "Quit")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(CallbackDispatcher), Member = "RunFrame")]
	[Calls(Type = typeof(OptionalContent), Member = "Update")]
	private void Update()
	{
	}

	[Calls(Type = typeof(CallbackDispatcher), Member = "Shutdown")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(OptionalContent), Member = "Destroy")]
	[Calls(Type = typeof(CallbackDispatcher), Member = "Unregister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public SteamManager()
	{
	}
}
