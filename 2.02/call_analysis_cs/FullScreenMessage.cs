using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class FullScreenMessage : MonoBehaviour
{
	private static HUDMessage.HUDMessageInfo m_FullScreenMessageInfo;

	private static float m_MessageLabelDisplayTimeSeconds;

	private static float m_MessageLabelElapsedDisplayTimeSeconds;

	private static float m_MessageLabelAlpha;

	private static float m_MessageLabelFadeTimeSeconds;

	private static bool m_BlackOutScreen;

	private static LocationRevealText m_LocationRevealText;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 24)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Action_PassTime), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_FullScreenMessage), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HUDMessage.HUDMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(FullScreenMessage), Member = "ShowText")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public static void AddMessage(string message, float numSeconds, bool blackOutScreen, bool fadeIn)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FullScreenMessage), Member = "ShowText")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void ShowMessage()
	{
	}

	[CalledBy(Type = typeof(FullScreenMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(FullScreenMessage), Member = "ShowMessage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(LocationRevealText), Member = "SetFontAndHide")]
	[Calls(Type = typeof(LocationRevealText), Member = "StartFade")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	private static void ShowText(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FullScreenMessage()
	{
	}
}
