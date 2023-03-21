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
			return 0f;
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
			return 0f;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(vp_DecalManager), Member = "Refresh")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_DecalManager), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
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

	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private static void FadeAndRemove()
	{
	}

	[CalledBy(Type = typeof(vp_DecalManager), Member = "set_MaxDecals")]
	[CalledBy(Type = typeof(vp_DecalManager), Member = "set_FadedDecals")]
	[CalledBy(Type = typeof(vp_DecalManager), Member = ".cctor")]
	[CallerCount(Count = 3)]
	private static void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 35)]
	private static void DebugOutput()
	{
	}
}
