using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class EventParamMappings
{
	public static Dictionary<iTweenEvent.TweenType, Dictionary<string, Type>> mappings;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 2617)]
	static EventParamMappings()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public EventParamMappings()
	{
	}
}