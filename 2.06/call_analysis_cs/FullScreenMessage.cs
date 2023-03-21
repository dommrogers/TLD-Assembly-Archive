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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Action_PassTime), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_FullScreenMessage), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HUDMessage.HUDMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(FullScreenMessage), Member = "ShowText")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static void AddMessage(string message, float numSeconds, bool blackOutScreen, bool fadeIn)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FullScreenMessage), Member = "ShowText")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void ShowMessage()
	{
	}

	[CalledBy(Type = typeof(FullScreenMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(FullScreenMessage), Member = "ShowMessage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(LocationRevealText), Member = "SetFontAndHide")]
	[Calls(Type = typeof(LocationRevealText), Member = "StartFade")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void ShowText(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FullScreenMessage()
	{
	}
}
