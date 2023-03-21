using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DisableNotificationFlagIcon : MonoBehaviour
{
	private static readonly int IsDestroyed;

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	public void Disable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public DisableNotificationFlagIcon()
	{
	}
}
