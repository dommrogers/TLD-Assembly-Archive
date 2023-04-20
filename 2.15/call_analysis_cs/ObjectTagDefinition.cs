using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectTagDefinition : ScriptableObject
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public ObjectTagDefinition()
	{
	}
}
