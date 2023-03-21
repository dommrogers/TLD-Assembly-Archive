using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public sealed class vp_DecalManager
{
	public static readonly vp_DecalManager instance;

	private static List<GameObject> m_Decals;

	private static float m_MaxDecals;

	private static float m_FadedDecals;

	private static float m_NonFadedDecals;

	private static float m_FadeAmount;

	public static float MaxDecals
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[Calls(Type = typeof(vp_DecalManager), Member = "Refresh")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public static float FadedDecals
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(float);
		}
		[Calls(Type = typeof(vp_DecalManager), Member = "Refresh")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		set
		{
		}
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_DecalManager), Member = "Refresh")]
	static vp_DecalManager()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private vp_DecalManager()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void Add(GameObject decal)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private static void FadeAndRemove()
	{
	}

	[CalledBy(Type = typeof(vp_DecalManager), Member = ".cctor")]
	[CalledBy(Type = typeof(vp_DecalManager), Member = "set_FadedDecals")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_DecalManager), Member = "set_MaxDecals")]
	private static void Refresh()
	{
	}

	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private static void DebugOutput()
	{
	}
}
