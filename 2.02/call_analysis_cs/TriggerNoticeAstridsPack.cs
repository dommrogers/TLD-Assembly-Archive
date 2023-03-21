using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TriggerNoticeAstridsPack : MonoBehaviour
{
	private bool hasBeenPlayed;

	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TriggerNoticeAstridsPack()
	{
	}
}
