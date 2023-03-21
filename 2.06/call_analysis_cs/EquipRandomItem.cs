using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EquipRandomItem : MonoBehaviour
{
	public InvEquipment equipment;

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(InvEquipment), Member = "Equip")]
	[Calls(Type = typeof(NGUITools), Member = "RandomRange")]
	[Calls(Type = typeof(InvGameItem), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public EquipRandomItem()
	{
	}
}
