using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Cooking;
using TLD.Gear;

public class GlobalSaveGameFormat
{
	public int m_Version;

	public string m_GameManagerSerialized;

	public string m_HudManagerSerialized;

	public string m_TimeOfDay_Serialized;

	public string m_Wind_Serialized;

	public string m_Weather_Serialized;

	public string m_WeatherTransition_Serialized;

	public string m_Condition_Serialized;

	public string m_Encumber_Serialized;

	public string m_Hunger_Serialized;

	public string m_Thirst_Serialized;

	public string m_Fatigue_Serialized;

	public string m_Freezing_Serialized;

	public string m_Willpower_Serialized;

	public string m_Inventory_Serialized;

	public string m_SandboxManagerSerialized;

	public string m_StoryManagerSerialized;

	public string m_PlayerManagerSerialized;

	public string m_PlayerClimbRopeSerialized;

	public string m_PlayerSkillsSerialized;

	public string m_PlayerGameStatsSerialized;

	public string m_HypothermiaSerialized;

	public string m_WellFedSerialized;

	public string m_FrostbiteSerialized;

	public string m_FoodPoisoningSerialized;

	public string m_DysenterySerialized;

	public string m_SprainPainSerialized;

	public string m_SprainedAnkleSerialized;

	public string m_SprainedWristSerialized;

	public string m_SprainedWristMajorSerialized;

	public string m_SprainsSerialized;

	public string m_BurnsSerialized;

	public string m_BurnsElectricSerialized;

	public string m_BloodLossSerialized;

	public string m_BrokenRibSerialized;

	public string m_InfectionSerialized;

	public string m_InfectionRiskSerialized;

	public string m_LogSerialized;

	public string m_RestSerialized;

	public string m_FlyOverSerialized;

	public string m_AchievementManagerSerialized;

	public string m_ExperienceModeManagerSerialized;

	public string m_AuroraManagerSerialized;

	public string m_PlayerMovementSerialized;

	public string m_PlayerStruggleSerialized;

	public string m_PanelStatsSerialized;

	public string m_EmergencyStimSerialized;

	public string m_EnergyBoostSerialized;

	public string m_HeadacheSerialized;

	public string m_MusicEventManagerSerialized;

	public string m_ChimneyDataSerialized;

	public string m_CabinFeverSerialized;

	public string m_IntestinalParasitesSerialized;

	public string m_SnowPatchManagerSerialized;

	public string m_PlayerAnimationSerialized;

	public string m_SkillsManagerSerialized;

	public string m_LockCompanionsSerialized;

	public string m_FeatsEnabledSerialized;

	public string m_TrustManagerSerialized;

	public string m_MapDataSerialized;

	public string m_BearHuntSerialized;

	public string m_BearHuntReduxSerialized;

	public string m_KnowledgeManagerSerialized;

	public string m_UnlockedBlueprintsSerialized;

	public string m_CollectionManagerSerialized;

	public string m_AuroraScreenManagerSerialized;

	public string m_StoryMissionDataSerialized;

	public bool m_CurrentEpisodeComplete;

	public string m_PhoneManagerSerialized;

	public string m_MissionObjectiveTableSerialized;

	public string m_BigCarrySystemSerialized;

	public string m_NPCGlobalSerialized;

	public string m_PackManagerGlobalSerialized;

	public string m_RockCacheInfoSerialized;

	public string m_SprayPaintPanelInfoSerialized;

	public string m_InvisibleEntityInfoSerialized;

	public string m_ToxicFogManagerSerialized;

	public string m_FearSerialized;

	public string m_AnxietySerialized;

	public string m_SuffocatingSerialized;

	public string m_HighResolutionTimerSerialized;

	public string m_SceneManagerSerialized;

	public string m_NotificationFlagSerialized;

	public string m_InsomniaSerialized;

	public string m_TransmitterSerialized;

	public string m_BeachcombingManagerSerialized;

	public string m_TrackableItemSerialized;

	public RecipeBookGameState m_RecipeBookState;

	public List<FoodMaxStatBuffEffect> m_FoodMaxStatBuffEffects;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public GlobalSaveGameFormat()
	{
	}
}
