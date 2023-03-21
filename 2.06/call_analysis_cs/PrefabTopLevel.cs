using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PrefabTopLevel : MonoBehaviour
{
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public PrefabTopLevel()
	{
	}
}
