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
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "AddFeatToList")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "AddFeatToList")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	public BadgeInfo CreateBadgeInfo()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetDescription()
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual string GetShortDescription()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual bool IsUnlocked()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual float GetNormalizedProgress()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void SetNormalizedProgress(float normalizedValue)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CallsUnknownMethods(Count = 2)]
	protected bool TryToDisplayKicker()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateTimeStats")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateTimeStats")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(SnareItem), Member = "SpawnDeadRabbitOnSnare")]
	[CalledBy(Type = typeof(ResearchItem), Member = "Read")]
	[CalledBy(Type = typeof(Fire), Member = "FireStateSet")]
	[CalledBy(Type = typeof(Feat_StraightToHeart), Member = "IncrementItemConsumed")]
	[CalledBy(Type = typeof(Feat_SnowWalker), Member = "IncrementMeters")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(Feat_FireMaster), Member = "IncrementFiresStarted")]
	[CalledBy(Type = typeof(Feat_FreeRunner), Member = "IncrementMeters")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CalledBy(Type = typeof(Feat_BlizzardWalker), Member = "IncrementHours")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(Feat_ColdFusion), Member = "IncrementHours")]
	[CalledBy(Type = typeof(Feat_EfficientMachine), Member = "IncrementElapsedHours")]
	[CalledBy(Type = typeof(Feat_ExpertTrapper), Member = "IncrementRabbitSnaredCount")]
	[CalledBy(Type = typeof(Feat_BookSmarts), Member = "IncrementHours")]
	protected bool ShouldBlockIncrement()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateTimeStats")]
	[CalledBy(Type = typeof(Feat_StraightToHeart), Member = "IncrementItemConsumed")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateTimeStats")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(SnareItem), Member = "SpawnDeadRabbitOnSnare")]
	[CalledBy(Type = typeof(ResearchItem), Member = "Read")]
	[CalledBy(Type = typeof(Fire), Member = "FireStateSet")]
	[CalledBy(Type = typeof(Feat_SnowWalker), Member = "IncrementMeters")]
	[CalledBy(Type = typeof(Feat_EfficientMachine), Member = "IncrementElapsedHours")]
	[CalledBy(Type = typeof(Feat_FireMaster), Member = "IncrementFiresStarted")]
	[CalledBy(Type = typeof(Feat_ExpertTrapper), Member = "IncrementRabbitSnaredCount")]
	[CalledBy(Type = typeof(Feat_ColdFusion), Member = "IncrementHours")]
	[CalledBy(Type = typeof(Feat_BookSmarts), Member = "IncrementHours")]
	[CalledBy(Type = typeof(Feat_BlizzardWalker), Member = "IncrementHours")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(Feat_FreeRunner), Member = "IncrementMeters")]
	protected void HandleOnFeatUnlocked()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Feat()
	{
	}
}
