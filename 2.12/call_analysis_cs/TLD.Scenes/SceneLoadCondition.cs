using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Scenes;

public class SceneLoadCondition : ScriptableObject
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public SceneLoadCondition()
	{
	}
}
