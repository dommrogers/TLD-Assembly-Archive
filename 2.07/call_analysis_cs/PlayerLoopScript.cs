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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameManager), Member = "EarlyUpdate")]
		internal void _003CInit_003Eb__7_0()
		{
		}

		[Calls(Type = typeof(Stopwatch), Member = "get_Elapsed")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(Stopwatch), Member = "Stop")]
		[CallsUnknownMethods(Count = 7)]
		internal void _003CInit_003Eb__7_1()
		{
		}
	}

	private static Stopwatch s_Stopwatch;

	private static Queue<double> s_CPUTimeMsQueue;

	public static float s_CPU_loopTimeMs;

	public static float s_CPU_loopTimeAvgMs;

	public const uint MAX_FRAME_TIMINGS = 60u;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerLoop), Member = "SetPlayerLoop")]
	[Calls(Type = typeof(PlayerLoopScript), Member = "InsertSystem")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(PlayerLoopScript), Member = "InsertSystem")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(PlayerLoop), Member = "InternalToPlayerLoopSystem")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[RuntimeInitializeOnLoadMethod]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static void Init()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerLoopScript), Member = "InsertSystem")]
	[CalledBy(Type = typeof(PlayerLoopScript), Member = "Init")]
	[Calls(Type = typeof(PlayerLoopScript), Member = "InsertSystem")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PlayerLoopScript), Member = "Init")]
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
