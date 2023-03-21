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
		[CallerCount(Count = 6)]
		public EarlyUpdateTimer()
		{
		}
	}

	public class PostLateUpdateTimer
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(GameManager), Member = "EarlyUpdate")]
		[CallerCount(Count = 0)]
		internal void _003CInit_003Eb__7_0()
		{
		}

		[CallsUnknownMethods(Count = 26)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 5)]
		[Calls(Type = typeof(Stopwatch), Member = "Stop")]
		[Calls(Type = typeof(Stopwatch), Member = "get_Elapsed")]
		internal void _003CInit_003Eb__7_1()
		{
		}
	}

	private static Stopwatch s_Stopwatch;

	private static Queue<double> s_CPUTimeMsQueue;

	public static float s_CPU_loopTimeMs;

	public static float s_CPU_loopTimeAvgMs;

	public const uint MAX_FRAME_TIMINGS = 60u;

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(PlayerLoopScript), Member = "InsertSystem")]
	[Calls(Type = typeof(PlayerLoop), Member = "SetPlayerLoop")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(PlayerLoopScript), Member = "InsertSystem")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(PlayerLoop), Member = "InternalToPlayerLoopSystem")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerLoopScript), Member = "InsertSystem")]
	[CalledBy(Type = typeof(PlayerLoopScript), Member = "Init")]
	[CalledBy(Type = typeof(PlayerLoopScript), Member = "Init")]
	[Calls(Type = typeof(PlayerLoopScript), Member = "InsertSystem")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	private static bool InsertSystem(ref PlayerLoopSystem system, Type insertUnder, PlayerLoopSystem toInsert, bool insertAtStart = true)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "EarlyUpdate")]
	private static void EarlyUpdate_Internal()
	{
	}

	[CallerCount(Count = 0)]
	private static void PostLateUpdate_Internal()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PlayerLoopScript()
	{
	}
}
