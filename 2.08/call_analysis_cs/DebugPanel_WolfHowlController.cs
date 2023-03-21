using System;
using System.Collections.Generic;
using System.Diagnostics;
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
		[CallerCount(Count = 0)]
		public override string ToString()
		{
			return null;
		}

		[CallsUnknownMethods(Count = 21)]
		[CalledBy(Type = typeof(DebugPanel_WolfHowlController), Member = "RefreshEventList")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGB")]
		[CallerCount(Count = 1)]
		private string FailureToString()
		{
			return null;
		}

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGB")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CalledBy(Type = typeof(DebugPanel_WolfHowlController), Member = "RefreshEventList")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public override bool IsOverlayPanel()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Update()
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void NotifyHowlStarted(int howlID, BaseAi howler, bool isLead)
	{
	}

	[CallerCount(Count = 6)]
	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	public static void NotifyHowlFailed(int howlID, float timer)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void AddEvent(HowlEvent howl)
	{
	}

	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HowlEvent), Member = "FailureToString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(HowlEvent), Member = "SuccessToString")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshEventList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public DebugPanel_WolfHowlController()
	{
	}
}
