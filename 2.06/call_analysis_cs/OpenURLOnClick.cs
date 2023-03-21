using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OpenURLOnClick : MonoBehaviour
{
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "GetUrlAtCharacterIndex")]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public OpenURLOnClick()
	{
	}
}
