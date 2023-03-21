using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class EpisodeManager
{
	public const Episode MOST_RECENTLY_RELEASED_EPISODE = Episode.Four;

	public static readonly int NumEpisodes;

	public static EpisodeData[] m_Episodes;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 14)]
	public static void Init()
	{
	}

	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(GameManager), Member = "OnDestroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static void Shutdown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public static string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeProgress")]
	[CallsUnknownMethods(Count = 3)]
	public static void Deserialize(string data)
	{
	}

	[CallerCount(Count = 0)]
	public static bool CanPlayEpisode(Episode episode)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 33)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Episode GetActiveEpisode()
	{
		return default(Episode);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SetCurrentEpisode")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SetCurrentEpisode")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SetCurrentEpisode")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SetCurrentEpisode")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SetCurrentEpisode")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "Init")]
	[CalledBy(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStory")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "OnStartEpisodeSelected")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "ProcessMenu")]
	[Calls(Type = typeof(SoundbankLoader), Member = "LoadEpisodeBanks")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	public static void SetActiveEpisode(Episode episode)
	{
	}

	[CalledBy(Type = typeof(EpisodeManager), Member = "UnlockAllToEpisode")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "AllowContinueToNextEpisode")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnActionComplete")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "HasCompletedEpisode")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_complete")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "AddMenuItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	public static EpisodeState GetState(Episode episode)
	{
		return default(EpisodeState);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_SetEpisodeState), Member = "OnExecute")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "UnlockAllToEpisode")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_complete")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_complete")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "UnlockEpisode")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "UnlockAllToEpisode")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "UnlockEpisode")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "UnlockEpisode")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "UnlockEpisode")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "UnlockEpisode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "UnlockEpisode")]
	public static void SetState(Episode episode, EpisodeState state)
	{
	}

	[CallerCount(Count = 0)]
	public static VoicePersona GetVoicePersona(Episode episode)
	{
		return default(VoicePersona);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static string GetDescriptionLocId(Episode episode)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateSelection")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "AddMenuItem")]
	public static string GetNamedTitleLocId(Episode episode)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateSelection")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetHeaderLocId(Episode episode)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string EpisodeLockedDestcription(Episode episode)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetLockedDescriptionFutureEpisode()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnLoadStory")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "RefreshDetails")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	public static bool NextEpisodeIsUnlocked(Episode episode)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	public static bool HasCompletedEpisode(Episode episode)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "GetContinueToEpisodeButtonText")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "RefreshDetails")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "RefreshDetails")]
	public static string GetEpisodeGenericNameLocId(Episode episode)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetEpisodeLargeTexturePath(Episode episode)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "UpdateNextEpisodeCards")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnActionComplete")]
	[CalledBy(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_complete")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "GetContinueToEpisodeButtonText")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "AllowContinueToNextEpisode")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "RefreshDetails")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "GetEpisodeTitleText")]
	public static Episode GetNextEpisode(Episode episode)
	{
		return default(Episode);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Episode GetEpisodeFromInteger(int episode)
	{
		return default(Episode);
	}

	[CalledBy(Type = typeof(EpisodeManager), Member = "OnAchievementsChanged")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_unlock")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	public static void UnlockAllToEpisode(Episode episode)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[Calls(Type = typeof(EpisodeManager), Member = "UnlockAllToEpisode")]
	private static void OnAchievementsChanged()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public EpisodeManager()
	{
	}
}
