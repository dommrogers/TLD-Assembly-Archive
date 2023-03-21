using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HideIfMainMenu : MonoBehaviour
{
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HideIfMainMenu()
	{
	}
}
