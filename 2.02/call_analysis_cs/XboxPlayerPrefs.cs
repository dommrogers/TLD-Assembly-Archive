using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public static class XboxPlayerPrefs
{
	private static Dictionary<string, string> m_StringsDict;

	private static Dictionary<string, int> m_IntsDict;

	private static Dictionary<string, float> m_FloatsDict;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public static bool HasKey(string a_Key)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	public static void DeleteKey(string a_Key)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public static void DeleteAll()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void Save()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void SetString(string a_Key, string a_Value)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static string GetString(string a_Key)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static string GetString(string a_Key, string a_DefaultValue)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetInt(string a_Key, int a_Value)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static int GetInt(string a_Key)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static int GetInt(string a_Key, int a_DefaultValue)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetFloat(string a_Key, float a_Value)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static float GetFloat(string a_Key)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public static float GetFloat(string a_Key, float a_DefaultValue)
	{
		return default(float);
	}
}
