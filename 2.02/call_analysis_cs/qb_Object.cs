using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class qb_Object : MonoBehaviour
{
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public qb_Object()
	{
	}
}
