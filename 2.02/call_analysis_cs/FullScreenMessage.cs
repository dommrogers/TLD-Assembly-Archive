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

	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private void Update()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(HUDMessage.HUDMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(FullScreenMessage), Member = "ShowText")]
	[CalledBy(Type = typeof(Action_PassTime), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_FullScreenMessage), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 11)]
	public static void AddMessage(string message, float numSeconds, bool blackOutScreen, bool fadeIn)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(FullScreenMessage), Member = "ShowText")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void ShowMessage()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(LocationRevealText), Member = "SetFontAndHide")]
	[Calls(Type = typeof(LocationRevealText), Member = "StartFade")]
	[CalledBy(Type = typeof(FullScreenMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(FullScreenMessage), Member = "ShowMessage")]
	[CallsUnknownMethods(Count = 12)]
	private static void ShowText(string text)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FullScreenMessage()
	{
	}
}
