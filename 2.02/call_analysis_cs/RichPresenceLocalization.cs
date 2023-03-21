using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RichPresenceLocalization : MonoBehaviour
{
	public RichPresenceLocInfo[] RichPresenceLocKeys;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
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
