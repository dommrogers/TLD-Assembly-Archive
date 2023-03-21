using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EquipRandomItem : MonoBehaviour
{
	public InvEquipment equipment;

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(InvEquipment), Member = "Equip")]
	[Calls(Type = typeof(NGUITools), Member = "RandomRange")]
	[Calls(Type = typeof(InvGameItem), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public EquipRandomItem()
	{
	}
}
