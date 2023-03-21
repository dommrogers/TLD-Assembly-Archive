using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.UI.Generics;
using UnityEngine;

public class FullScreenMessage : MonoBehaviour
{
	private PanelReference<Panel_HUD> m_HUD;

	private static HUDMessage.HUDMessageInfo m_FullScreenMessageInfo;

	private static float m_MessageLabelDisplayTimeSeconds;

	private static float m_MessageLabelElapsedDisplayTimeSeconds;

	private static float m_MessageLabelAlpha;

	private static float m_MessageLabelFadeTimeSeconds;

	private static bool m_BlackOutScreen;

	private static LocationRevealText m_LocationRevealText;

	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_PassTime), Member = "OnExecute")]
	[Calls(Type = typeof(FullScreenMessage), Member = "ShowText")]
	[CalledBy(Type = typeof(Action_FullScreenMessage), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HUDMessage.HUDMessageInfo), Member = ".ctor")]
	public static void AddMessage(string message, float numSeconds, bool blackOutScreen, bool fadeIn)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(FullScreenMessage), Member = "ShowText")]
	[CallsUnknownMethods(Count = 1)]
	private static void ShowMessage()
	{
	}

	[CalledBy(Type = typeof(FullScreenMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(FullScreenMessage), Member = "ShowMessage")]
	[Calls(Type = typeof(LocationRevealText), Member = "StartFade")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(LocationRevealText), Member = "SetFontAndHide")]
	private static void ShowText(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FullScreenMessage()
	{
	}
}
