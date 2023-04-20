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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
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
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsUnknownMethods(Count = 1)]
	public string LookupEventName(uint eventID)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void MaybeConnectEventListener(PlayerVoice voice)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdateNonCriticalDelay")]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdatePlayback")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public override bool IsOverlayPanel()
	{
		return false;
	}

	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateNonCriticalDelay()
	{
	}

	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "Enable")]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "OnVoicePersonaChanged")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateGender()
	{
	}

	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "Enable")]
	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(uint), Member = "ToString")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdatePlayback()
	{
	}

	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "OnRequestEvent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGB")]
	[Calls(Type = typeof(uint), Member = "ToString")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private void UpdateQueue()
	{
	}

	[CalledBy(Type = typeof(DebugPanel_PlayerVoice), Member = "OnRequestEvent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(uint), Member = "ToString")]
	[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGB")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private void UpdateRecent()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint), Member = "ToString")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdateRecent")]
	[Calls(Type = typeof(DebugPanel_PlayerVoice), Member = "UpdateQueue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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
