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

		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		public void Clear()
		{
		}

		[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = ".cctor")]
		[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = ".cctor")]
		[CallerCount(Count = 2)]
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
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	public static string GetDebugText()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseTracker), Member = "MaybeStartOrStop")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	public static void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LoopTracker), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	public static void Add(GameObject go, AK.Wwise.Event eventReference, float radius, bool stopWhenDisabled, bool position)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmbientTracker), Member = ".ctor")]
	public static void AddAmbient(GameObject go, AK.Wwise.Event akEvent, MultiPositionTypeLabel multiposition, float radius, bool stopWhenDisabled)
	{
	}

	[Calls(Type = typeof(LoopTracker), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void AddVoice(GameObject go, string eventID, float radius, bool stopWhenDisabled, bool position)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayAmbientSimple), Member = "OnDestroy")]
	[CalledBy(Type = typeof(PlayAudioSimple), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 4)]
	public static void Remove(GameObject go, AK.Wwise.Event akEvent)
	{
	}
}
