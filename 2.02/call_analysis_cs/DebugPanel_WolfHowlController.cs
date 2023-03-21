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
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(DebugPanel_WolfHowlController), Member = "RefreshEventList")]
		public override string ToString()
		{
			return null;
		}

		[CallsUnknownMethods(Count = 21)]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGB")]
		private string FailureToString()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGB")]
		[Calls(Type = typeof(string), Member = "Format")]
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

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool IsOverlayPanel()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void NotifyHowlStarted(int howlID, BaseAi howler, bool isLead)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Conditional(/*Could not decode attribute arguments.*/)]
	public static void NotifyHowlFailed(int howlID, float timer)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void AddEvent(HowlEvent howl)
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(HowlEvent), Member = "ToString")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	private void RefreshEventList()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public DebugPanel_WolfHowlController()
	{
	}
}
