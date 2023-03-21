using Cpp2ILInjected.CallAnalysis;

public static class GearNames
{
	public const string PREFIX = "gear_";

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "StoreAutoCompleteGearNames")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetPrefixedName(string gearName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "StoreAutoCompleteGearNames")]
	public static string GetBaseName(string gearName)
	{
		return null;
	}
}
