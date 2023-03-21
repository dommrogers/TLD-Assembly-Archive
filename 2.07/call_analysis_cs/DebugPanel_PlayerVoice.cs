using System;
using System.Collections.Generic;
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	public string LookupEventName(uint eventID)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 7)]
	public void MaybeConnectEventListener(PlayerVoice voice)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdateNonCriticalDelay")]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdatePlayback")]
	private void Update()
	{
	}

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public override bool IsOverlayPanel()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	private void UpdateNonCriticalDelay()
	{
	}

	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "OnVoicePersonaChanged")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	private void UpdateGender()
	{
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "Update")]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "Enable")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	private void UpdatePlayback()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "OnRequestEvent")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGB")]
	private void UpdateQueue()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "OnRequestEvent")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGB")]
	private void UpdateRecent()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdateQueue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdateRecent")]
	private void OnRequestEvent(Request request, PlayerVoice.Reason reason)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdateGender")]
	private void OnVoicePersonaChanged(VoicePersona persona)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public DebugPanel_PlayerVoice()
	{
	}
}
