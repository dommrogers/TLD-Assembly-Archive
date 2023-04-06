using Cpp2ILInjected.CallAnalysis;

public static class GearNames
{
	public const string PREFIX = "gear_";

	[CalledBy(Type = typeof(ConsoleManager), Member = "StoreAutoCompleteGearNames")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetPrefixedName(string gearName)
	{
		return null;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "StoreAutoCompleteGearNames")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetBaseName(string gearName)
	{
		return null;
	}
}
