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

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void OnAudioEvent(AkEventCallbackMsg message)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 5)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 8)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public LogAudioEvent()
	{
	}
}
