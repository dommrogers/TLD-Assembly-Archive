using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public static class GearNames
{
	public static string[] m_Names;

	private static Dictionary<string, string[]> m_NamesWithComponents;

	public const string PREFIX = "gear_";

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CallsUnknownMethods(Count = 8)]
	public static List<string> GetComponentsWithNames()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_gear_add_type")]
	[CallsUnknownMethods(Count = 1)]
	public static string[] GetWithComponent(string componentName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "StoreAutoCompleteGearNames")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "AddCustomGearName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_gear_add")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	public static string GetPrefixedName(string gearName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_gear_add")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "AddCustomGearName")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "StoreAutoCompleteGearNames")]
	public static string GetBaseName(string gearName)
	{
		return null;
	}
}
