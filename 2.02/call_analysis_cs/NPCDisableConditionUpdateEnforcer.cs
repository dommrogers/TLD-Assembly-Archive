using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPCDisableConditionUpdateEnforcer : MonoBehaviour
{
	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "IsCarryingBody")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public NPCDisableConditionUpdateEnforcer()
	{
	}
}
