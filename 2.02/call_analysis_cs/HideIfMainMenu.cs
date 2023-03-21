using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HideIfMainMenu : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInParent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HideIfMainMenu()
	{
	}
}
