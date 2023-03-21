using System;
using System.Collections.Generic;
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
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
	[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
	[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
	[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CalledBy(Type = typeof(Task), Member = "get_name")]
	[Calls(Type = typeof(Regex), Member = "Replace")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StringUtils), Member = "CapitalizeFirst")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "IndexOf")]
	public static string SplitCamelCase(this string s)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(StringUtils), Member = "SplitCamelCase")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
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

	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	public static string GetCapitals(this string s)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetAlphabetLetter(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(GroupCollection), Member = "GetGroup")]
	[Calls(Type = typeof(Regex), Member = "Run")]
	[Calls(Type = typeof(Regex), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	public static string GetStringWithin(this string input, string from, string to)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static float ScoreSearchMatch(string input, string leafName, string categoryName = "")
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static bool SearchMatch(string input, string leafName, string categoryName = "")
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring")]
	public static string ReplaceWithin(this string text, char startChar, char endChar, Func<string, string> Process)
	{
		return null;
	}

	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[CalledBy(Type = typeof(BBParameter), Member = "ToString")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	public static string ToStringAdvanced(this object o)
	{
		return null;
	}
}
