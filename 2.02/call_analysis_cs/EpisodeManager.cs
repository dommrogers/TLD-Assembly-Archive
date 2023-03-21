using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class EpisodeManager
{
	public const Episode MOST_RECENTLY_RELEASED_EPISODE = Episode.Four;

	public static readonly int NumEpisodes;

	public static EpisodeData[] m_Episodes;

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public static void Init()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "OnDestroy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void Shutdown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeProgress")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void Deserialize(string data)
	{
	}

	[CallerCount(Count = 0)]
	public static bool CanPlayEpisode(Episode episode)
	{
		return false;
	}

	[CallerCount(Count = 33)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static Episode GetActiveEpisode()
	{
		return default(Episode);
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "OnStartEpisodeSelected")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStory")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "Init")]
	[CalledBy(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SetCurrentEpisode")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SoundbankLoader), Member = "LoadEpisodeBanks")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static void SetActiveEpisode(Episode episode)
	{
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_complete")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "HasCompletedEpisode")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "UnlockAllToEpisode")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnActionComplete")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "AllowContinueToNextEpisode")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static EpisodeState GetState(Episode episode)
	{
		return default(EpisodeState);
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "UnlockEpisode")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_complete")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "UnlockAllToEpisode")]
	[CalledBy(Type = typeof(Action_SetEpisodeState), Member = "OnExecute")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void SetState(Episode episode, EpisodeState state)
	{
	}

	[CallerCount(Count = 0)]
	public static VoicePersona GetVoicePersona(Episode episode)
	{
		return default(VoicePersona);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetDescriptionLocId(Episode episode)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateSelection")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "AddMenuItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetNamedTitleLocId(Episode episode)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateSelection")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "AddMenuItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetHeaderLocId(Episode episode)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnLoadStory")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool NextEpisodeIsUnlocked(Episode episode)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool HasCompletedEpisode(Episode episode)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "GetContinueToEpisodeButtonText")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetEpisodeGenericNameLocId(Episode episode)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetEpisodeLargeTexturePath(Episode episode)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "GetContinueToEpisodeButtonText")]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "GetEpisodeTitleText")]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "UpdateNextEpisodeCards")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_complete")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[CalledBy(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnActionComplete")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "AllowContinueToNextEpisode")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Episode GetNextEpisode(Episode episode)
	{
		return default(Episode);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Episode GetEpisodeFromInteger(int episode)
	{
		return default(Episode);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_unlock")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "OnAchievementsChanged")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void UnlockAllToEpisode(Episode episode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[Calls(Type = typeof(EpisodeManager), Member = "UnlockAllToEpisode")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void OnAchievementsChanged()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public EpisodeManager()
	{
	}
}
