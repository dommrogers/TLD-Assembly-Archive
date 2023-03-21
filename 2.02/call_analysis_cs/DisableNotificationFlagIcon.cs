using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DisableNotificationFlagIcon : MonoBehaviour
{
	private static readonly int IsDestroyed;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 9)]
	public void Disable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DisableNotificationFlagIcon()
	{
	}
}
