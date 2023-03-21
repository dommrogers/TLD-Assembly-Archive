using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class Feat : MonoBehaviour
{
	public FeatType m_FeatType;

	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedDescription;

	public LocalizedString m_LocalizedShortDescription;

	public LocalizedString m_LocalizedBonusDescription;

	public string m_BadgeIcon;

	public string m_BadgeLockedIcon;

	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	protected bool m_KickerPending;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "AddFeatToList")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "AddFeatToList")]
	public BadgeInfo CreateBadgeInfo()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetDescription()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public virtual string GetShortDescription()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual string GetBonusDescription()
	{
		return null;
	}

	[CallerCount(Count = 25)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsUnlockedAndEnabled()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public virtual bool IsUnlocked()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual float GetNormalizedProgress()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void SetNormalizedProgress(float normalizedValue)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	protected bool TryToDisplayKicker()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ResearchItem), Member = "Read")]
	[CalledBy(Type = typeof(SnareItem), Member = "SpawnDeadRabbitOnSnare")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(Feat_ColdFusion), Member = "IncrementHours")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateTimeStats")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateTimeStats")]
	[CalledBy(Type = typeof(Fire), Member = "FireStateSet")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(Feat_StraightToHeart), Member = "IncrementItemConsumed")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CalledBy(Type = typeof(Feat_FreeRunner), Member = "IncrementMeters")]
	[CalledBy(Type = typeof(Feat_FireMaster), Member = "IncrementFiresStarted")]
	[CalledBy(Type = typeof(Feat_ExpertTrapper), Member = "IncrementRabbitSnaredCount")]
	[CalledBy(Type = typeof(Feat_EfficientMachine), Member = "IncrementElapsedHours")]
	[CalledBy(Type = typeof(Feat_BookSmarts), Member = "IncrementHours")]
	[CalledBy(Type = typeof(Feat_BlizzardWalker), Member = "IncrementHours")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(Feat_SnowWalker), Member = "IncrementMeters")]
	protected bool ShouldBlockIncrement()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SnareItem), Member = "SpawnDeadRabbitOnSnare")]
	[CalledBy(Type = typeof(Fire), Member = "FireStateSet")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(Feat_StraightToHeart), Member = "IncrementItemConsumed")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateTimeStats")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateTimeStats")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(Feat_SnowWalker), Member = "IncrementMeters")]
	[CalledBy(Type = typeof(ResearchItem), Member = "Read")]
	[CalledBy(Type = typeof(Feat_FireMaster), Member = "IncrementFiresStarted")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CalledBy(Type = typeof(Feat_BlizzardWalker), Member = "IncrementHours")]
	[CalledBy(Type = typeof(Feat_BookSmarts), Member = "IncrementHours")]
	[CalledBy(Type = typeof(Feat_FreeRunner), Member = "IncrementMeters")]
	[CalledBy(Type = typeof(Feat_EfficientMachine), Member = "IncrementElapsedHours")]
	[CalledBy(Type = typeof(Feat_ExpertTrapper), Member = "IncrementRabbitSnaredCount")]
	[CalledBy(Type = typeof(Feat_ColdFusion), Member = "IncrementHours")]
	protected void HandleOnFeatUnlocked()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Feat()
	{
	}
}
