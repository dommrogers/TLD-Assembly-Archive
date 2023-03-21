using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
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
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			set
			{
			}
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void Reset()
		{
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(FullScreenMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(HUDMessage), Member = "CreateMessageInfo")]
		public HUDMessageInfo()
		{
		}
	}

	private static PriorityQueue<HUDMessageInfo> m_HUDMessageQueue;

	private static Stack<HUDMessageInfo> s_HUDMessageCache;

	private static float m_MessageLabelElapsedDisplayTimeSeconds;

	private static float m_MessageLabelAlpha;

	private static float m_MessageLabelFadeTimeSeconds;

	private static HUDMessageInfo m_CurrentMessage;

	private const int HIGH_PRIORITY = 1;

	private const int LOW_PRIORITY = 3;

	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(HUDMessage), Member = "UpdateAlphaValue")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(HUDMessage), Member = "UpdateAlphaValue")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(HUDMessage), Member = "CacheMessageInfo")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(HUDMessage), Member = "ShowMessageAtBottomOfScreen")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(HUDMessage), Member = "ShowMessageAtBottomOfScreen")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(HUDMessage), Member = "Update")]
	[CalledBy(Type = typeof(HUDMessage), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private static void UpdateAlphaValue()
	{
	}

	[CallerCount(Count = 152)]
	[Calls(Type = typeof(HUDMessage), Member = "CreateMessageInfo")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	[CallsUnknownMethods(Count = 1)]
	public static void AddMessage(string message, bool highPriority = false, bool ignoreOverlayActive = false)
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DisplayErrorMessage")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[CalledBy(Type = typeof(GearItem), Member = "BreakOnUse")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeIn")]
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
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[CalledBy(Type = typeof(HUDMessage), Member = "PutMessageBackToQueue")]
	[CalledBy(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(Action_ShowHUDMessage), Member = "OnExecute")]
	[Calls(Type = typeof(HUDMessage), Member = "CacheMessageInfo")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(HUDMessage), Member = "Update")]
	private static void AddMessageToQueue(HUDMessageInfo newHudMessage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	private static void PutMessageBackToQueue(HUDMessageInfo message)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Action_ShowHUDMessage), Member = "OnExecute")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[CalledBy(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HUDMessageInfo), Member = ".ctor")]
	private static HUDMessageInfo CreateMessageInfo()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(HUDMessage), Member = "Update")]
	[CalledBy(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	[CallsUnknownMethods(Count = 8)]
	private static void CacheMessageInfo(HUDMessageInfo messageInfo)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private static void ShowMessage(HUDMessageInfo message)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(HUDMessage), Member = "Update")]
	[CalledBy(Type = typeof(HUDMessage), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShowMessageAtBottomOfScreen()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HUDMessage()
	{
	}
}
