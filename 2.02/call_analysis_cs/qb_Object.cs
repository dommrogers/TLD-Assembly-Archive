using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class qb_Object : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public qb_Object()
	{
	}
}
