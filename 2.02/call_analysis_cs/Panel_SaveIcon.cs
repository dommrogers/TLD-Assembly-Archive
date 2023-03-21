using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panel_SaveIcon : Panel_Base
{
	public UISprite m_Sprite_IsSaving;

	public UILabel m_Label_Saving;

	private float m_TimeToShowSaveSprite;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsUnknownMethods(Count = 5)]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void Update()
	{
	}

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_save")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	public void StartSaveIconAnimation()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsIconVisible()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool IsOverlayPanel()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Panel_SaveIcon()
	{
	}
}
