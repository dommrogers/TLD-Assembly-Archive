using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace ParadoxNotion;

public static class StringUtils
{
	private const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

	private static readonly char[] CHAR_EMPTY_ARRAY;

	private static Dictionary<string, string> splitCaseCache;

	[CalledBy(Type = typeof(Node), Member = "get_name")]
	[CalledBy(Type = typeof(Task), Member = "get_name")]
	[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Regex), Member = "Replace")]
	[Calls(Type = typeof(StringUtils), Member = "CapitalizeFirst")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string SplitCamelCase(this string s)
	{
		return null;
	}

	[CalledBy(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CalledBy(Type = typeof(StringUtils), Member = "SplitCamelCase")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "First")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	public static string CapitalizeFirst(this string s)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string CapLength(this string s, int max)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(char), Member = "IsUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetCapitals(this string s)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetAlphabetLetter(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Regex), Member = ".ctor")]
	[Calls(Type = typeof(Regex), Member = "Run")]
	[Calls(Type = typeof(GroupCollection), Member = "GetGroup")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static string GetStringWithin(this string input, string from, string to)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsUnknownMethods(Count = 3)]
	public static float ScoreSearchMatch(string input, string leafName, string categoryName = "")
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	public static bool SearchMatch(string input, string leafName, string categoryName = "")
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string ReplaceWithin(this string text, char startChar, char endChar, Func<string, string> Process)
	{
		return null;
	}

	[CalledBy(Type = typeof(BBParameter), Member = "ToString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTIsDefined")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	public static string ToStringAdvanced(this object o)
	{
		return null;
	}
}
