using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TriggerNoticeAstridsPack : MonoBehaviour
{
	private bool hasBeenPlayed;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TriggerNoticeAstridsPack()
	{
	}
}
