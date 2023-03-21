using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DisableNotificationFlagIcon : MonoBehaviour
{
	private static readonly int IsDestroyed;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 6)]
	public void Disable()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DisableNotificationFlagIcon()
	{
	}
}
