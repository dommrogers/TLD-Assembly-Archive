using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TriggerNoticeAstridsPack : MonoBehaviour
{
	private bool hasBeenPlayed;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallerCount(Count = 0)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public TriggerNoticeAstridsPack()
	{
	}
}
