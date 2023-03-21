using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EquipRandomItem : MonoBehaviour
{
	public InvEquipment equipment;

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(Type = typeof(NGUITools), Member = "RandomRange")]
	[Calls(Type = typeof(InvEquipment), Member = "Equip")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvGameItem), Member = ".ctor")]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public EquipRandomItem()
	{
	}
}
