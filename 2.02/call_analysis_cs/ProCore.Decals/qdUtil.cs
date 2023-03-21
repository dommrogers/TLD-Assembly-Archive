using System;
using System.Collections.Generic;
using System.Globalization;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		internal int _003CSortDecalsUsingView_003Eb__2_1(Decal a, Decal b)
		{
			return default(int);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 15)]
	public static GameObject[] FindDecalsWithTexture(Texture2D img)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(qd_Decal), Member = "SetUVRect")]
	[CallerCount(Count = 0)]
	public static void RefreshSceneDecals(DecalGroup dg)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CallsUnknownMethods(Count = 18)]
	public static void SortDecalsUsingView(ref List<Decal> decals, DecalView decalView)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public static bool Contains(this Dictionary<int, List<int>> dic, int key, int val)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 27)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	public static void Add(this Dictionary<int, List<int>> dic, int key, int val)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 29)]
	public static string ToFormattedString(this Dictionary<int, List<int>> dic)
	{
		return null;
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public static string ToFormattedString<T>(this T[] t, string _delimiter)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	public static string ToFormattedString<T>(this List<T> t, string _delimiter)
	{
		return null;
	}
}
