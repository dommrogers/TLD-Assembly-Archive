using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BoxSectorStructure : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BoxSectorStructure()
	{
	}
}
