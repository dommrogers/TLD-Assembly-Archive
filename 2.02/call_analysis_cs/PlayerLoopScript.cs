using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.LowLevel;

public class PlayerLoopScript
{
	public class EarlyUpdateTimer
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public EarlyUpdateTimer()
		{
		}
	}

	public class PostLateUpdateTimer
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public PostLateUpdateTimer()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static PlayerLoopSystem.UpdateFunction _003C_003E9__7_0;

		public static PlayerLoopSystem.UpdateFunction _003C_003E9__7_1;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Stopwatch), Member = "Start")]
		[Calls(Type = typeof(GameManager), Member = "EarlyUpdate")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal void _003CInit_003Eb__7_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Stopwatch), Member = "Stop")]
		[Calls(Type = typeof(Stopwatch), Member = "get_Elapsed")]
		[Calls(Type = typeof(Queue<>.Enumerator), Member = "MoveNext")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 18)]
		internal void _003CInit_003Eb__7_1()
		{
		}
	}

	private static Stopwatch s_Stopwatch;

	private static Queue<double> s_CPUTimeMsQueue;

	public static float s_CPU_loopTimeMs;

	public static float s_CPU_loopTimeAvgMs;

	public const uint MAX_FRAME_TIMINGS = 60u;

	[RuntimeInitializeOnLoadMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerLoop), Member = "InternalToPlayerLoopSystem")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(PlayerLoopScript), Member = "InsertSystem")]
	[Calls(Type = typeof(PlayerLoop), Member = "SetPlayerLoop")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private static void Init()
	{
	}

	[CalledBy(Type = typeof(PlayerLoopScript), Member = "Init")]
	[CalledBy(Type = typeof(PlayerLoopScript), Member = "InsertSystem")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerLoopScript), Member = "InsertSystem")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static bool InsertSystem(ref PlayerLoopSystem system, Type insertUnder, PlayerLoopSystem toInsert, bool insertAtStart = true)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "EarlyUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void EarlyUpdate_Internal()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void PostLateUpdate_Internal()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public PlayerLoopScript()
	{
	}
}
