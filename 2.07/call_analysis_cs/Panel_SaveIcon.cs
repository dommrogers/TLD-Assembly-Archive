using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.UI;
using UnityEngine;

public class Panel_SaveIcon : Panel_AutoReferenced
{
	public UISprite m_Sprite_IsSaving;

	public UILabel m_Label_Saving;

	private float m_TimeToShowSaveSprite;

	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_save")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	public void StartSaveIconAnimation()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public bool IsIconVisible()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public override bool IsOverlayPanel()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Panel_SaveIcon()
	{
	}
}
