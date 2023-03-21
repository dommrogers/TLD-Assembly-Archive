using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NowhereToHide_BanishmentArea : MonoBehaviour
{
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NowhereToHide_BanishmentArea()
	{
	}
}
