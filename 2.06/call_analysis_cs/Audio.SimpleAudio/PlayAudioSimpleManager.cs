using System;
using System.Collections.Generic;
using System.Text;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Audio.SimpleAudio;

public static class PlayAudioSimpleManager
{
	private class Counters
	{
		public float activeLoops;

		public float akGameObjs;

		public float[] activeGroups;

		public float[] emitterGroups;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		public void Add(BaseTracker tracker)
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public void Clear()
		{
		}

		[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = ".cctor")]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = ".cctor")]
		public Counters()
		{
		}
	}

	public static bool s_Debug;

	private static List<BaseTracker> m_Trackers;

	private static int m_CurrentIndex;

	private static int m_NumProcessPerFrame;

	private static bool m_FirstUpdate;

	private static int s_MaxStartOrStopPerFrame;

	private static readonly int NUM_BUCKETS;

	private static float[] m_BucketRanges;

	private static Counters m_CurrentCounters;

	private static Counters m_NextCounters;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private static void SwapCounters()
	{
	}

	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	public static string GetDebugText()
	{
		return null;
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseTracker), Member = "MaybeStartOrStop")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 5)]
	public static void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseTracker), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(PlayAudioSimple), Member = "Start")]
	[CallsUnknownMethods(Count = 7)]
	public static void Add(GameObject go, AK.Wwise.Event eventReference, float radius, bool stopWhenDisabled, bool position)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayAmbientSimple), Member = "Start")]
	[Calls(Type = typeof(AmbientTracker), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static void AddAmbient(GameObject go, AK.Wwise.Event akEvent, MultiPositionTypeLabel multiposition, float radius, bool stopWhenDisabled)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseTracker), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(PlayVoiceSimple), Member = "Start")]
	[CallsUnknownMethods(Count = 7)]
	public static void AddVoice(GameObject go, string eventID, float radius, bool stopWhenDisabled, bool position)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayAmbientSimple), Member = "OnDestroy")]
	[CalledBy(Type = typeof(PlayAudioSimple), Member = "OnDestroy")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static void Remove(GameObject go, AK.Wwise.Event akEvent)
	{
	}
}
