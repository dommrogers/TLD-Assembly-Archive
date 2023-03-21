using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DebugPanel_WolfHowlController : Panel_Base
{
	private enum HowlEventType
	{
		Failure,
		SuccessLead,
		SuccessResponce
	}

	private struct HowlEvent
	{
		public int m_HowlID;

		public float m_NextTime;

		public TimeSpan m_Timestamp;

		public HowlEventType m_Type;

		public string m_WolfName;

		[CallAnalysisFailed]
		[CalledBy(Type = typeof(DebugPanel_WolfHowlController), Member = "RefreshEventList")]
		[CallerCount(Count = 1)]
		public override string ToString()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGB")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 21)]
		private string FailureToString()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGB")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 21)]
		private string SuccessToString()
		{
			return null;
		}
	}

	public UILabel m_EventListLabel;

	public UILabel m_TimerLabel;

	public UILabel m_WolfListLabel;

	private const int MAX_HOWL_EVENTS = 10;

	private List<HowlEvent> m_HowlEvents;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool IsOverlayPanel()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void NotifyHowlStarted(int howlID, BaseAi howler, bool isLead)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void NotifyHowlFailed(int howlID, float timer)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void AddEvent(HowlEvent howl)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(HowlEvent), Member = "ToString")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	private void RefreshEventList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public DebugPanel_WolfHowlController()
	{
	}
}
