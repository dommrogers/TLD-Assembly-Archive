using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PrefabTopLevel : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PrefabTopLevel()
	{
	}
}
