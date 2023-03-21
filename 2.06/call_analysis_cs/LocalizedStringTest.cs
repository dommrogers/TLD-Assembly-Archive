using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LocalizedStringTest : MonoBehaviour
{
	public string test_one;

	public LocalizedString test_two;

	public string test_three;

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public LocalizedStringTest()
	{
	}
}
