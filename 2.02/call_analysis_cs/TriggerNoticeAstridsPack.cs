using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TriggerNoticeAstridsPack : MonoBehaviour
{
	private bool hasBeenPlayed;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TriggerNoticeAstridsPack()
	{
	}
}
