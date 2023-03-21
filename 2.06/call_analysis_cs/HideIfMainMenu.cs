using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HideIfMainMenu : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public HideIfMainMenu()
	{
	}
}
