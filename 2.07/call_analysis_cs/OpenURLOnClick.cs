using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OpenURLOnClick : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "GetUrlAtCharacterIndex")]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public OpenURLOnClick()
	{
	}
}
