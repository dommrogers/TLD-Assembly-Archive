using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RichPresenceLocalization : MonoBehaviour
{
	public RichPresenceLocInfo[] RichPresenceLocKeys;

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RichPresenceLocalization()
	{
	}
}
