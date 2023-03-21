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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(vp_DecalManager), Member = "Refresh")]
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(vp_DecalManager), Member = "Refresh")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(vp_DecalManager), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	static vp_DecalManager()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private vp_DecalManager()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void Add(GameObject decal)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	private static void FadeAndRemove()
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(vp_DecalManager), Member = ".cctor")]
	[CalledBy(Type = typeof(vp_DecalManager), Member = "set_FadedDecals")]
	[CalledBy(Type = typeof(vp_DecalManager), Member = "set_MaxDecals")]
	private static void Refresh()
	{
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static void DebugOutput()
	{
	}
}
