using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Steamworks;
using UnityEngine;

public class SteamManager : MonoBehaviour
{
	public delegate void OnGameOverlayActivatedDelegate(bool activated);

	private bool m_Initialized;

	private bool m_DoneStatsInit;

	private static SteamManager _003CInstance_003Ek__BackingField;

	public uint SteamAppID;

	private Callback<GameOverlayActivated_t> m_OnGameOverlayActivatedCallback;

	public static SteamManager Instance
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static bool Initialized
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(SteamManager), Member = "Update")]
		[CalledBy(Type = typeof(SteamManager), Member = "IsRunningOnSteamDeck")]
		[CalledBy(Type = typeof(SteamRichPresenceProvider), Member = "ChangePresence")]
		[CalledBy(Type = typeof(SteamRichPresenceProvider), Member = "IsUserSignedOn")]
		[CalledBy(Type = typeof(InputSystemRewired), Member = "InitializeSteamController")]
		[CalledBy(Type = typeof(TextInputField), Member = "Select")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "RequestStatsAndAchievements")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "SendStatistic")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetupLockedFPS")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Shutdown")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Update")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Update")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Initialize")]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "ResetAllAchievements")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 15)]
		[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Unlock")]
		get
		{
			return default(bool);
		}
	}

	public static event OnGameOverlayActivatedDelegate s_OnGameOverlayActivated
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(Steamworks.NativeMethods), Member = "ISteamUtils_IsSteamRunningOnSteamDeck")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsRunningOnSteamDeck()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DontDestroyOnLoad")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(SteamUser), Member = "BLoggedOn")]
	[Calls(Type = typeof(CallbackDispatcher), Member = "Initialize")]
	[Calls(Type = typeof(Steamworks.CSteamAPIContext), Member = "Init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Packsize), Member = "Test")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "Quit")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(CallbackDispatcher), Member = "RunFrame")]
	private void Update()
	{
	}

	[Calls(Type = typeof(SteamAPI), Member = "Shutdown")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CallbackDispatcher), Member = "Unregister")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnGameOverlayActivated(GameOverlayActivated_t args)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SteamManager()
	{
	}
}
