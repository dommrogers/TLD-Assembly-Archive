using System;
using Cpp2ILInjected.CallAnalysis;

namespace DataPlatform;

public class Events
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendAchievementUnlocked(string UserId, ref Guid PlayerSessionId, int AchievementId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendBearAttackSurvived(string UserId, ref Guid PlayerSessionId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendBlizzardSurvived(string UserId, ref Guid PlayerSessionId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendConsecutiveNightSurvived_Sandbox(string UserId, ref Guid PlayerSessionId, int NightSurvived)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendCurrentArea(string UserId, ref Guid PlayerSessionId, string AreaName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendDeltaDaysSurvived_Sandbox(string UserId, ref Guid PlayerSessionId, int DeltaDays)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendDeltaDistanceTravelled(string UserId, ref Guid PlayerSessionId, float DeltaDistance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendEnemyDefeated(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, ref Guid RoundId, int PlayerRoleId, int PlayerWeaponId, int EnemyRoleId, int KillTypeId, float LocationX, float LocationY, float LocationZ, int EnemyWeaponId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendFullyHarvestedDeer_Sandbox(string UserId, ref Guid PlayerSessionId, int NumDeers)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendGameProgress(string UserId, ref Guid PlayerSessionId, float CompletionPercent)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendItemAcquired(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, int ItemId, int AcquisitionMethodId, float LocationX, float LocationY, float LocationZ)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendItemUsed(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, int ItemId, float LocationX, float LocationY, float LocationZ)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendMediaUsage(string AppSessionId, string AppSessionStartDateTime, uint UserIdType, string UserId, string SubscriptionTierType, string SubscriptionTier, string MediaType, string ProviderId, string ProviderMediaId, string ProviderMediaInstanceId, ref Guid BingId, ulong MediaLengthMs, uint MediaControlAction, float PlaybackSpeed, ulong MediaPositionMs, ulong PlaybackDurationMs, string AcquisitionType, string AcquisitionContext, string AcquisitionContextType, string AcquisitionContextId, int PlaybackIsStream, int PlaybackIsTethered, string MarketplaceLocation, string ContentLocale, float TimeZoneOffset, uint ScreenState)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendMultiplayerRoundEnd(string UserId, ref Guid RoundId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int MatchTypeId, int DifficultyLevelId, float TimeInSeconds, int ExitStatusId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendMultiplayerRoundStart(string UserId, ref Guid RoundId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int MatchTypeId, int DifficultyLevelId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendNumDaysSurvived_Sandbox(string UserId, ref Guid PlayerSessionId, int NumDaysSurvived)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendNumDaysSurvivedOffLand_Sandbox(string UserId, ref Guid PlayerSessionId, int NumDaysSurvived)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendNumDaysSurvivedWithoutGunFired_Sandbox(string UserId, ref Guid PlayerSessionId, int NumDaysSurvived)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendNumDaysSurvivedWithoutKill_Sandbox(string UserId, ref Guid PlayerSessionId, int NumDaysSurvived)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendObjectiveEnd(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, int ObjectiveId, int ExitStatusId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendObjectiveStart(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, int ObjectiveId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendPageAction(string UserId, ref Guid PlayerSessionId, int ActionTypeId, int ActionInputMethodId, string Page, string TemplateId, string DestinationPage, string Content)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendPageView(string UserId, ref Guid PlayerSessionId, string Page, string RefererPage, int PageTypeId, string PageTags, string TemplateId, string Content)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendPlayerDefeated(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, ref Guid RoundId, int PlayerRoleId, int PlayerWeaponId, int EnemyRoleId, int EnemyWeaponId, float LocationX, float LocationY, float LocationZ)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendPlayerSessionEnd(string UserId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, int ExitStatusId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendPlayerSessionPause(string UserId, ref Guid PlayerSessionId, string MultiplayerCorrelationId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendPlayerSessionResume(string UserId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendPlayerSessionStart(string UserId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendPlayerSpawned(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, ref Guid RoundId, int PlayerRoleId, float LocationX, float LocationY, float LocationZ)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendPuzzleSolved(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, float TimeInSeconds)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendSectionEnd(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId, int ExitStatusId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendSectionStart(string UserId, int SectionId, ref Guid PlayerSessionId, string MultiplayerCorrelationId, int GameplayModeId, int DifficultyLevelId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendViewOffer(string UserId, ref Guid PlayerSessionId, ref Guid OfferGuid, ref Guid ProductGuid)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendWildlifeBowHit(string UserId, ref Guid PlayerSessionId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendWildlifeRifleHit(string UserId, ref Guid PlayerSessionId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendWolfKill(string UserId, ref Guid PlayerSessionId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void SendWorldExploredUpdate(string UserId, ref Guid PlayerSessionId, float WorldExplorerPercent)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Events()
	{
	}
}
