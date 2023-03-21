using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityXCECmd;

internal class CommandLineParser
{
	public Dictionary<string, string> Args;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	public CommandLineParser()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsUnknownMethods(Count = 3)]
	private bool HasArg(string arg, string[] args)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Console), Member = "WriteLine")]
	[CallsUnknownMethods(Count = 16)]
	public bool Parse(string[] args, string[] validArgs)
	{
		return default(bool);
	}
}
