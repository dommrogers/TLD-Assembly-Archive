using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EquipRandomItem : MonoBehaviour
{
	public InvEquipment equipment;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(Type = typeof(InvGameItem), Member = ".ctor")]
	[Calls(Type = typeof(NGUITools), Member = "RandomRange")]
	[Calls(Type = typeof(InvEquipment), Member = "Equip")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public EquipRandomItem()
	{
	}
}
