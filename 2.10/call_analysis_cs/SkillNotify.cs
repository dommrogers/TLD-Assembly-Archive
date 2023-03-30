using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.UI.Generics;
using UnityEngine;

public class SkillNotify : MonoBehaviour
{
	public float m_FadeTimeSeconds;

	public float m_SkillIncreaseDisplayTimeSeconds;

	public float m_SkillLevelUpDisplayTimeSeconds;

	public string m_SkillLevelUpAudio;

	public float m_SkillLevelUpDelaySeconds;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_PauseMenu> m_PauseMenu;

	private float m_SkillIncreaseElapsedDisplayTimeSeconds;

	private float m_SkillIncreaseAlpha;

	private float m_SkillLevelUpElapsedDisplayTimeSeconds;

	private float m_SkillLevelUpAlpha;

	private float m_SkillLevelUpDisplayTimeGate;

	private bool m_SkillLevelUpPending;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(SkillNotify), Member = "ShouldHideSkillLevelUpIcon")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(SkillNotify), Member = "UpdateSkillIncreaseAlpha")]
	[Calls(Type = typeof(SkillNotify), Member = "UpdateSkillLevelUpAlpha")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CalledBy(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CalledBy(Type = typeof(Action_SetSkillPoints), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void MaybeShowPointIncrease(string spriteName)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	[CalledBy(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CalledBy(Type = typeof(Action_SetSkillPoints), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetSkillLevel), Member = "OnExecute")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void MaybeShowLevelUp(string spriteName, string header, string footer, int tier)
	{
	}

	[CalledBy(Type = typeof(SkillNotify), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateSkillIncreaseAlpha(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(SkillNotify), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateSkillLevelUpAlpha(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(SkillNotify), Member = "Update")]
	[CalledBy(Type = typeof(SkillNotify), Member = "TryToDisplaySkillLevelUp")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldHideSkillLevelUpIcon()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldHideSkillIncreaseIcon()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkillNotify), Member = "ShouldHideSkillLevelUpIcon")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool TryToDisplaySkillLevelUp(Panel_HUD hud)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SkillNotify()
	{
	}
}
