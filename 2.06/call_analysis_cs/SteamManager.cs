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
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static bool Initialized
	{
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "ResetAllAchievements")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Initialize")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Update")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Shutdown")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Unlock")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "SendStatistic")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "RequestStatsAndAchievements")]
		[CalledBy(Type = typeof(TextInputField), Member = "Select")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVsync")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateDisplayMenuItems")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CanLockFPS")]
		[CalledBy(Type = typeof(InputSystemRewired), Member = "InitializeSteamController")]
		[CalledBy(Type = typeof(SteamRichPresenceProvider), Member = "IsUserSignedOn")]
		[CalledBy(Type = typeof(SteamRichPresenceProvider), Member = "ChangePresence")]
		[CalledBy(Type = typeof(SteamManager), Member = "Update")]
		[CalledBy(Type = typeof(SteamManager), Member = "IsRunningOnSteamDeck")]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return false;
		}
	}

	public static bool IsOverlayActive
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static event OnGameOverlayActivatedDelegate s_OnGameOverlayActivated
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Packsize), Member = "Test")]
	[Calls(Type = typeof(Application), Member = "Quit")]
	[Calls(TypeFullName = "Steamworks.CSteamAPIContext", Member = "Init")]
	[Calls(Type = typeof(CallbackDispatcher), Member = "Initialize")]
	[Calls(Type = typeof(SteamUser), Member = "BLoggedOn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DontDestroyOnLoad")]
	[Calls(Type = typeof(Callback<>), Member = "Create")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CallbackDispatcher), Member = "Unregister")]
	[Calls(Type = typeof(OptionalContent), Member = "Destroy")]
	[Calls(Type = typeof(CallbackDispatcher), Member = "Shutdown")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	private void OnGameOverlayActivated(GameOverlayActivated_t args)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(TypeFullName = "Steamworks.NativeMethods", Member = "ISteamUtils_IsSteamRunningOnSteamDeck")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsRunningOnSteamDeck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public SteamManager()
	{
	}
}
