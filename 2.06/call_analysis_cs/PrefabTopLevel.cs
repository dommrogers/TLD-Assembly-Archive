using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PrefabTopLevel : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public PrefabTopLevel()
	{
	}
}
