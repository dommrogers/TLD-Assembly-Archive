using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.Audio;
using TLD.Serialization;
using UnityEngine;

public class EpisodeManager
{
	public const Episode MOST_RECENTLY_RELEASED_EPISODE = Episode.Four;

	public static readonly int NumEpisodes;

	public static EpisodeData[] m_Episodes;

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	public static void Init()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CalledBy(Type = typeof(GameManager), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 2)]
	public static void Shutdown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void Deserialize(string data)
	{
	}

	[CallerCount(Count = 0)]
	public static bool CanPlayEpisode(Episode episode)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_complete")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[CalledBy(Type = typeof(Breath), Member = "ShouldSuppressBreathEffect")]
	[CalledBy(Type = typeof(Breath), Member = "ShouldSuppressBreathEffect")]
	[CalledBy(Type = typeof(Condition_CheckEpisode), Member = "OnCheck")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Enable")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Enable")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[CalledBy(Type = typeof(StoryMissionListEntry), Member = "Refresh")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateTrustListData")]
	public static Episode GetActiveEpisode()
	{
		return default(Episode);
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "SetCurrentEpisode")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SetCurrentEpisode")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SetCurrentEpisode")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SetCurrentEpisode")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SetCurrentEpisode")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "Init")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(Type = typeof(SoundbankLoader), Member = "LoadEpisodeBanks")]
	[CallerCount(Count = 9)]
	public static void SetActiveEpisode(Episode episode)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(EpisodeManager), Member = "HasCompletedEpisode")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_complete")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[CallerCount(Count = 4)]
	public static EpisodeState GetState(Episode episode)
	{
		return default(EpisodeState);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_SetEpisodeState), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_complete")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "UnlockEpisode")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "UnlockEpisode")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_complete")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "UnlockEpisode")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "UnlockEpisode")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "UnlockEpisode")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "UnlockEpisode")]
	public static void SetState(Episode episode, EpisodeState state)
	{
	}

	[CallerCount(Count = 0)]
	public static VoicePersona GetVoicePersona(Episode episode)
	{
		return default(VoicePersona);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetDescriptionLocId(Episode episode)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	public static string GetNamedTitleLocId(Episode episode)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	public static string GetHeaderLocId(Episode episode)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	public static string EpisodeLockedDestcription(Episode episode)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static string GetLockedDescriptionFutureEpisode()
	{
		return null;
	}

	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	public static bool NextEpisodeIsUnlocked(Episode episode)
	{
		return default(bool);
	}

	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	public static bool HasCompletedEpisode(Episode episode)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "RefreshDetails")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	public static string GetEpisodeGenericNameLocId(Episode episode)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetEpisodeLargeTexturePath(Episode episode)
	{
		return null;
	}

	[CalledBy(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_complete")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "RefreshDetails")]
	public static Episode GetNextEpisode(Episode episode)
	{
		return default(Episode);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static Episode GetEpisodeFromInteger(int episode)
	{
		return default(Episode);
	}

	[CalledBy(Type = typeof(EpisodeManager), Member = "OnAchievementsChanged")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_unlock")]
	[CallerCount(Count = 2)]
	public static void UnlockAllToEpisode(Episode episode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[Calls(Type = typeof(EpisodeManager), Member = "UnlockAllToEpisode")]
	private static void OnAchievementsChanged()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public EpisodeManager()
	{
	}
}
