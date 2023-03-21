using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PrefabTopLevel : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PrefabTopLevel()
	{
	}
}
