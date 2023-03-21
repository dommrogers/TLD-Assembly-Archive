using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NowhereToHide_BanishmentArea : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public NowhereToHide_BanishmentArea()
	{
	}
}
