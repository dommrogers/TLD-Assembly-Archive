using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ProCore.Decals;

public static class qdUtil
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Decal> _003C_003E9__2_0;

		public static Comparison<Decal> _003C_003E9__2_1;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CSortDecalsUsingView_003Eb__2_0(Decal a, Decal b)
		{
			return default(int);
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CSortDecalsUsingView_003Eb__2_1(Decal a, Decal b)
		{
			return default(int);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[CallsUnknownMethods(Count = 4)]
	public static GameObject[] FindDecalsWithTexture(Texture2D img)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(qd_Decal), Member = "SetUVRect")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public static void RefreshSceneDecals(DecalGroup dg)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void SortDecalsUsingView(ref List<Decal> decals, DecalView decalView)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static bool Contains(this Dictionary<int, List<int>> dic, int key, int val)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static void Add(this Dictionary<int, List<int>> dic, int key, int val)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 25)]
	public static string ToFormattedString(this Dictionary<int, List<int>> dic)
	{
		return null;
	}

	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static string ToFormattedString<T>(this T[] t, string _delimiter)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string ToFormattedString<T>(this List<T> t, string _delimiter)
	{
		return null;
	}
}
