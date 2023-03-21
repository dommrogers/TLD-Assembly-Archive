using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Cloud.UserReporting.Plugin.SimpleJson;

public class JsonArray : List<object>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public JsonArray()
	{
		((List<T>)(object)this)._002Ector();
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public JsonArray(int capacity)
	{
		((List<T>)(object)this)._002Ector();
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public override string ToString()
	{
		return null;
	}
}
