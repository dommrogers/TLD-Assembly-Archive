using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.UI.Generics;
using UnityEngine;

public class HUDMessage : MonoBehaviour
{
	public class HUDMessageInfo : IPrioritizable
	{
		public string m_Text;

		public float m_DisplayTime;

		public float m_StartAlpha;

		public int m_Instances;

		public bool m_IgnoreOverlayActive;

		private int _003Cm_Priority_003Ek__BackingField;

		public int m_Priority
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		[CallerCount(Count = 0)]
		public void Reset()
		{
		}

		[CalledBy(Type = typeof(FullScreenMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(HUDMessage), Member = "CreateMessageInfo")]
		[CallerCount(Count = 2)]
		public HUDMessageInfo()
		{
		}
	}

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_FeedFire> m_FeedFire;

	private static PriorityQueue<HUDMessageInfo> m_HUDMessageQueue;

	private static Stack<HUDMessageInfo> s_HUDMessageCache;

	private static float m_MessageLabelElapsedDisplayTimeSeconds;

	private static float m_MessageLabelAlpha;

	private static float m_MessageLabelFadeTimeSeconds;

	private static HUDMessageInfo m_CurrentMessage;

	private const int HIGH_PRIORITY = 1;

	private const int LOW_PRIORITY = 3;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(PriorityQueue<>), Member = "get_Count")]
	[Calls(Type = typeof(PriorityQueue<>), Member = "Peek")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(PriorityQueue<>), Member = "Dequeue")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(HUDMessage), Member = "CacheMessageInfo")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void UpdateAlphaValue(Panel_HUD hud)
	{
	}

	[CallerCount(Count = 149)]
	[Calls(Type = typeof(HUDMessage), Member = "CreateMessageInfo")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	[CallsUnknownMethods(Count = 1)]
	public static void AddMessage(string message, bool highPriority = false, bool ignoreOverlayActive = false)
	{
	}

	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(GearItem), Member = "DisplayDegradedHUDMessage")]
	[CalledBy(Type = typeof(GearItem), Member = "BreakOnUse")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeIn")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(HUDMessage), Member = "CreateMessageInfo")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	[CallsUnknownMethods(Count = 1)]
	public static void AddMessage(string message, float numSeconds, bool highPriority = false, bool ignoreOverlayActive = false)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void AddMessageFadeIn(string message, float numSeconds, bool highPriority = false)
	{
	}

	[CalledBy(Type = typeof(HUDMessage), Member = "Update")]
	[CalledBy(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(HUDMessage), Member = "PutMessageBackToQueue")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[CalledBy(Type = typeof(Action_ShowHUDMessage), Member = "OnExecute")]
	[CallerCount(Count = 7)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(PriorityQueue<>.Enumerator), Member = ".ctor")]
	[Calls(Type = typeof(PriorityQueue<>), Member = "Enqueue")]
	[Calls(Type = typeof(HUDMessage), Member = "CacheMessageInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	private static void AddMessageToQueue(HUDMessageInfo newHudMessage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	private static void PutMessageBackToQueue(HUDMessageInfo message)
	{
	}

	[CalledBy(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[CalledBy(Type = typeof(Action_ShowHUDMessage), Member = "OnExecute")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Stack<>), Member = "Pop")]
	[Calls(Type = typeof(HUDMessageInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	private static HUDMessageInfo CreateMessageInfo()
	{
		return null;
	}

	[CalledBy(Type = typeof(HUDMessage), Member = "Update")]
	[CalledBy(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Stack<>), Member = "Push")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static void CacheMessageInfo(HUDMessageInfo messageInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private static void ShowMessage(Panel_HUD hud, HUDMessageInfo message)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool ShowMessageAtBottomOfScreen()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public HUDMessage()
	{
	}
}
