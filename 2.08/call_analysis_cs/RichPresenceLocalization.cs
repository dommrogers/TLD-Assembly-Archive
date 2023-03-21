using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RichPresenceLocalization : MonoBehaviour
{
	public RichPresenceLocInfo[] RichPresenceLocKeys;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public RichPresenceLocalization()
	{
	}
}
