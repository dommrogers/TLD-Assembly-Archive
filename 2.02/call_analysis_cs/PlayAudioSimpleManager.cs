using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using AK.Wwise;
using Audio.SimpleAudio;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class PlayAudioSimpleManager
{
	private class Counters
	{
		public float activeLoops;

		public float akGameObjs;

		public float[] activeGroups;

		public float[] emitterGroups;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 15)]
		public void Add(BaseTracker tracker)
		{
		}

		[CallsUnknownMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void Clear()
		{
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = ".cctor")]
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

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private static void SwapCounters()
	{
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static string GetDebugText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BaseTracker), Member = "MaybeStartOrStop")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public static void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CallerCount(Count = 1)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(LoopTracker), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayAudioSimple), Member = "Start")]
	public static void Add(GameObject go, string eventID, float radius, bool stopWhenDisabled, bool position)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(BaseTracker), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayAmbientSimple), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void AddAmbient(GameObject go, AK.Wwise.Event akEvent, MultiPositionTypeLabel multiposition, float radius, bool stopWhenDisabled)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayVoiceSimple), Member = "Start")]
	[Calls(Type = typeof(LoopTracker), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static void AddVoice(GameObject go, string eventID, float radius, bool stopWhenDisabled, bool position)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayAmbientSimple), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	public static void Remove(GameObject go, AK.Wwise.Event akEvent)
	{
	}
}
