using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityXCECmd;

internal class CommandLineParser
{
	public Dictionary<string, string> Args;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public CommandLineParser()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsUnknownMethods(Count = 2)]
	private bool HasArg(string arg, string[] args)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(Console), Member = "WriteLine")]
	[CallsUnknownMethods(Count = 4)]
	public bool Parse(string[] args, string[] validArgs)
	{
		return false;
	}
}
