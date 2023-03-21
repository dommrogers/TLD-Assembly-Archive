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

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdateGender")]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdatePlayback")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string LookupEventName(uint eventID)
	{
		return null;
	}

	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool IsOverlayPanel()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateNonCriticalDelay()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "Enable")]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "OnVoicePersonaChanged")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateGender()
	{
	}

	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "Enable")]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	private void UpdatePlayback()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "OnRequestEvent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGB")]
	private void UpdateQueue()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "OnRequestEvent")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGB")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void UpdateRecent()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdateRecent")]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdateQueue")]
	[CallsUnknownMethods(Count = 4)]
	private void OnRequestEvent(Request request, PlayerVoice.Reason reason)
	{
	}

	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdateGender")]
	[CallerCount(Count = 0)]
	private void OnVoicePersonaChanged(VoicePersona persona)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	public DebugPanel_PlayerVoice()
	{
	}
}
