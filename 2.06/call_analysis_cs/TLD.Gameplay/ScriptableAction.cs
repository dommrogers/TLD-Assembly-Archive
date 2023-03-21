using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay;

public abstract class ScriptableAction : ScriptableObject
{
	public abstract void ExecuteAction();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	protected ScriptableAction()
	{
	}
}
