using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BoxSectorStructure : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public BoxSectorStructure()
	{
	}
}
