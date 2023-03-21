using System;
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
			[CallerCount(Count = 0)]
			get
			{
				return default(int);
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

		[CalledBy(Type = typeof(HUDMessage), Member = "CreateMessageInfo")]
		[CalledBy(Type = typeof(FullScreenMessage), Member = "AddMessage")]
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
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(HUDMessage), Member = "CacheMessageInfo")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private static void UpdateAlphaValue(Panel_HUD hud)
	{
	}

	[CallerCount(Count = 150)]
	[Calls(Type = typeof(HUDMessage), Member = "CreateMessageInfo")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	[CallsUnknownMethods(Count = 1)]
	public static void AddMessage(string message, bool highPriority = false, bool ignoreOverlayActive = false)
	{
	}

	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeIn")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	[CalledBy(Type = typeof(GearItem), Member = "BreakOnUse")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(HUDMessage), Member = "CreateMessageInfo")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(GearItem), Member = "DisplayDegradedHUDMessage")]
	public static void AddMessage(string message, float numSeconds, bool highPriority = false, bool ignoreOverlayActive = false)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void AddMessageFadeIn(string message, float numSeconds, bool highPriority = false)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Action_ShowHUDMessage), Member = "OnExecute")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CalledBy(Type = typeof(HUDMessage), Member = "PutMessageBackToQueue")]
	[CalledBy(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(HUDMessage), Member = "CacheMessageInfo")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(HUDMessage), Member = "Update")]
	private static void AddMessageToQueue(HUDMessageInfo newHudMessage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	private static void PutMessageBackToQueue(HUDMessageInfo message)
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookWaterPicker")]
	[CalledBy(Type = typeof(Action_ShowHUDMessage), Member = "OnExecute")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	[CalledBy(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(HUDMessageInfo), Member = ".ctor")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "ShowCookFoodPicker")]
	private static HUDMessageInfo CreateMessageInfo()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(HUDMessage), Member = "Update")]
	[CalledBy(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	[CallsUnknownMethods(Count = 2)]
	private static void CacheMessageInfo(HUDMessageInfo messageInfo)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private static void ShowMessage(Panel_HUD hud, HUDMessageInfo message)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool ShowMessageAtBottomOfScreen()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HUDMessage()
	{
	}
}
