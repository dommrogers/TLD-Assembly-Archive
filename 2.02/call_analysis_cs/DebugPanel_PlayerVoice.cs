using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using Voice;

public class DebugPanel_PlayerVoice : Panel_Base
{
	private struct CompletedRequest
	{
		public uint m_EventID;

		public string m_EventName;

		public PlayerVoice.Reason m_Reason;

		public TimeSpan m_Timestamp;
	}

	public UILabel m_Gender;

	public UILabel m_NonCriticalDelay;

	public UILabel m_PlaybackTime;

	public UILabel m_PlayingLine;

	public UILabel m_Queue;

	public UILabel m_Recent;

	private Dictionary<uint, string> m_AudioEventNameLookup;

	private const int MAX_COMPLETED_REQUEST = 10;

	private List<CompletedRequest> m_CompletedRequests;

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdatePlayback")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdateGender")]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public string LookupEventName(uint eventID)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 17)]
	public void MaybeConnectEventListener(PlayerVoice voice)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdateNonCriticalDelay")]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdatePlayback")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool IsOverlayPanel()
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_time")]
	private void UpdateNonCriticalDelay()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "OnVoicePersonaChanged")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateGender()
	{
	}

	[Calls(Type = typeof(System.Number), Member = "FormatUInt32")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "Enable")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "Update")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Number), Member = "FormatUInt32")]
	private void UpdatePlayback()
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "OnRequestEvent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(System.Number), Member = "FormatUInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGB")]
	private void UpdateQueue()
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "OnRequestEvent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGB")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatUInt32")]
	private void UpdateRecent()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdateQueue")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdateRecent")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatUInt32")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnRequestEvent(Request request, PlayerVoice.Reason reason)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdateGender")]
	private void OnVoicePersonaChanged(VoicePersona persona)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 18)]
	public DebugPanel_PlayerVoice()
	{
	}
}
