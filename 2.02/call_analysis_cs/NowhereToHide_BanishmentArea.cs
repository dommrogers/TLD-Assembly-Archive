using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NowhereToHide_BanishmentArea : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NowhereToHide_BanishmentArea()
	{
	}
}
