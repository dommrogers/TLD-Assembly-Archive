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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 5)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
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
