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

	[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
	[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
	[CalledBy(Type = typeof(Task), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CalledBy(Type = typeof(Node), Member = "get_name")]
	[Calls(Type = typeof(Regex), Member = "Replace")]
	[Calls(Type = typeof(StringUtils), Member = "CapitalizeFirst")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	public static string SplitCamelCase(this string s)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CalledBy(Type = typeof(StringUtils), Member = "SplitCamelCase")]
	[CallsUnknownMethods(Count = 3)]
	public static string CapitalizeFirst(this string s)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	public static string CapLength(this string s, int max)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	public static string GetCapitals(this string s)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	public static string GetAlphabetLetter(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Regex), Member = ".ctor")]
	[Calls(Type = typeof(Regex), Member = "Run")]
	[Calls(Type = typeof(GroupCollection), Member = "GetGroup")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	public static string GetStringWithin(this string input, string from, string to)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
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
	[CalledBy(Type = typeof(BBParameter), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 6)]
	public static string ToStringAdvanced(this object o)
	{
		return null;
	}
}
