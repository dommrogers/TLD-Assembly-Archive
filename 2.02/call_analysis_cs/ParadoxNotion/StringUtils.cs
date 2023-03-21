using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using UnityEngine;

namespace ParadoxNotion;

public static class StringUtils
{
	private const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

	private static readonly char[] CHAR_EMPTY_ARRAY;

	private static Dictionary<string, string> splitCaseCache;

	[CalledBy(Type = typeof(Node), Member = "get_name")]
	[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
	[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
	[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
	[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
	[CalledBy(Type = typeof(Task), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Regex), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(StringUtils), Member = "CapitalizeFirst")]
	public static string SplitCamelCase(this string s)
	{
		return null;
	}

	[CalledBy(Type = typeof(StringUtils), Member = "SplitCamelCase")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallerCount(Count = 3)]
	public static string CapitalizeFirst(this string s)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string CapLength(this string s, int max)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static string GetCapitals(this string s)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetAlphabetLetter(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GroupCollection), Member = "get_Item")]
	[Calls(Type = typeof(Regex), Member = "Match")]
	[Calls(Type = typeof(Regex), Member = ".ctor")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	public static string GetStringWithin(this string input, string from, string to)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	public static float ScoreSearchMatch(string input, string leafName, string categoryName = "")
	{
		return default(float);
	}

	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static bool SearchMatch(string input, string leafName, string categoryName = "")
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Statement), Member = "BlackboardReplace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	public static string ReplaceWithin(this string text, char startChar, char endChar, Func<string, string> Process)
	{
		return null;
	}

	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[CalledBy(Type = typeof(BBParameter), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	public static string ToStringAdvanced(this object o)
	{
		return null;
	}
}
