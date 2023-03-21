using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RichPresenceLocalization : MonoBehaviour
{
	public RichPresenceLocInfo[] RichPresenceLocKeys;

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public RichPresenceLocalization()
	{
	}
}
