using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OpenURLOnClick : MonoBehaviour
{
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[Calls(Type = typeof(UILabel), Member = "GetUrlAtCharacterIndex")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public OpenURLOnClick()
	{
	}
}
