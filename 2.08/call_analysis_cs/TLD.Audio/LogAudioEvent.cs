using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Logging;
using UnityEngine;

namespace TLD.Audio;

public class LogAudioEvent : MonoBehaviour
{
	private static readonly LogFilter s_LogFilter;

	private AkTriggerBase[] m_TriggersToLog;

	private readonly Dictionary<AkTriggerBase, AkTriggerBase.Trigger> m_RegisteredCallbacks;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void OnAudioEvent(AkEventCallbackMsg message)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 7)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public LogAudioEvent()
	{
	}
}
