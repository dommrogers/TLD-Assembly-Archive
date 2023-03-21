using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HideIfMainMenu : MonoBehaviour
{
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public HideIfMainMenu()
	{
	}
}
