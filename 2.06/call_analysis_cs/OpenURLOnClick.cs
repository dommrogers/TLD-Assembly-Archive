using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OpenURLOnClick : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[Calls(Type = typeof(UILabel), Member = "GetUrlAtCharacterIndex")]
	[CallsUnknownMethods(Count = 2)]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public OpenURLOnClick()
	{
	}
}
