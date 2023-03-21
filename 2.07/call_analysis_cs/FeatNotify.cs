using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class FeatNotify : MonoBehaviour
{
	public float m_FeatUnlockDisplayTimeSeconds;

	public float m_FadeTimeSeconds;

	public string m_FeatUnlockAudio;

	private PanelReference<Panel_HUD> m_HUD;

	private float m_FeatUnlockedElapsedDisplayTimeSeconds;

	private float m_FeatUnlockedAlpha;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void Start()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(FeatNotify), Member = "UpdateFeatUnlockedAlpha")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(Feat), Member = "Update")]
	[CalledBy(Type = typeof(Feat), Member = "TryToDisplayKicker")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(BadgeUIInfo), Member = "UnlockBadge")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 3)]
	public void ShowFeatUnlockedKicker(string textureName, string footer)
	{
	}

	[CalledBy(Type = typeof(FeatNotify), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	private void UpdateFeatUnlockedAlpha(Panel_HUD hud)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldHideFeatUnlockedIcon()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public FeatNotify()
	{
	}
}
