using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PrefabTopLevel : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PrefabTopLevel()
	{
	}
}
