using Cpp2ILInjected.CallAnalysis;
using SpecialEvents;
using UnityEngine;

public class FeatNotify : MonoBehaviour
{
	public float m_FeatUnlockDisplayTimeSeconds;

	public float m_FadeTimeSeconds;

	public string m_FeatUnlockAudio;

	private float m_FeatUnlockedElapsedDisplayTimeSeconds;

	private float m_FeatUnlockedAlpha;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(FeatNotify), Member = "UpdateFeatUnlockedAlpha")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(Feat), Member = "TryToDisplayKicker")]
	[CalledBy(Type = typeof(BadgeUIInfo), Member = "UnlockBadge")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Mark4DONCurrentDayComplete")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "EatingComplete")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "CheckSaveSlotForMissedBadges")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(Utils), Member = "GetBadgeIcon")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 22)]
	public void ShowFeatUnlockedKicker(string textureName, string footer)
	{
	}

	[CalledBy(Type = typeof(FeatNotify), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateFeatUnlockedAlpha()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private bool ShouldHideFeatUnlockedIcon()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FeatNotify()
	{
	}
}
