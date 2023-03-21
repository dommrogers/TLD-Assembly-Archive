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
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[Calls(Type = typeof(vp_DecalManager), Member = "Refresh")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public static float FadedDecals
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[Calls(Type = typeof(vp_DecalManager), Member = "Refresh")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_DecalManager), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	static vp_DecalManager()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private vp_DecalManager()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Add(GameObject decal)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	private static void FadeAndRemove()
	{
	}

	[CalledBy(Type = typeof(vp_DecalManager), Member = "set_FadedDecals")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(vp_DecalManager), Member = "set_MaxDecals")]
	[CalledBy(Type = typeof(vp_DecalManager), Member = ".cctor")]
	private static void Refresh()
	{
	}

	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 34)]
	private static void DebugOutput()
	{
	}
}
