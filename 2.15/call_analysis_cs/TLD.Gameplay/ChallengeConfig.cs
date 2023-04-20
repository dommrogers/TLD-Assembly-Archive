using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.SaveState;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Gameplay;

public class ChallengeConfig : SandboxBaseConfig
{
	public enum BestTimeStyle
	{
		LowerIsBetter,
		HigherIsBetter
	}

	private StartGearData m_StartGearOverride;

	private AssetReferenceTexture2D m_ChallengeTexture;

	private LocalizedString m_Header;

	private LocalizedString m_StartDescription;

	private LocalizedString m_Instructions;

	private LocalizedString m_Bullets;

	public int m_Difficulty;

	private AssetReferenceTexture2D m_BadgeIcon;

	private BadgeInfoType m_UnlockedBadge;

	public bool m_IsTimed;

	public SceneWeatherOverrideData m_SceneWeatherOverrideData;

	private ChallengeLockCondition[] m_LockConditions;

	private ScriptableAction[] m_EndChallengeActions;

	private AlternateElapsedTimeSource m_AlternateElapsedTimeSource;

	private BestTimeStyle m_BestTimeStyle;

	public override StartGearData StartGear
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public BadgeInfoType UnlockedBadge
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(BadgeInfoType);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetLockedCondition")]
	public bool IsLocked()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetChallengeTextureAsync")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "UpdateUISelection")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetLockedCondition")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AssetReferenceTexture2D GetChallengeTexture()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetLockedCondition")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public string GetSpriteName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetLockedCondition")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetHeaderText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetLockedCondition")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetStartDescriptionText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetLockedCondition")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetInstructionText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetBulletText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AssetReferenceTexture2D GetBadgeIcon()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BestTimeStyle GetBestTimeStyle()
	{
		return default(BestTimeStyle);
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "UpdateProfileAfterChallengeComplete")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetElapsedTimeInHours")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public float MaybeUpdateBestTime()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeUnlockChallengeBadge()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "SetTimeSurvivedLabel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "GetElapsedTimeInHours")]
	[CalledBy(Type = typeof(ChallengeConfig), Member = "MaybeUpdateBestTime")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public float GetElapsedTimeInHours()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameModeConfig), Member = "DestroyMissionServicesManager")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void EndGame()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "ChallengeIsLocked")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "UpdateUISelection")]
	[CalledBy(Type = typeof(ChallengeConfig), Member = "IsLocked")]
	[CalledBy(Type = typeof(ChallengeConfig), Member = "GetChallengeTexture")]
	[CalledBy(Type = typeof(ChallengeConfig), Member = "GetSpriteName")]
	[CalledBy(Type = typeof(ChallengeConfig), Member = "GetHeaderText")]
	[CalledBy(Type = typeof(ChallengeConfig), Member = "GetStartDescriptionText")]
	[CalledBy(Type = typeof(ChallengeConfig), Member = "GetInstructionText")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private ChallengeLockCondition GetLockedCondition()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SandboxBaseConfig), Member = ".ctor")]
	public ChallengeConfig()
	{
	}
}
