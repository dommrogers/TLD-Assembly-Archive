using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EquipItems : MonoBehaviour
{
	public int[] itemIDs;

	[Calls(Type = typeof(InvGameItem), Member = ".ctor")]
	[Calls(Type = typeof(NGUITools), Member = "RandomRange")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(InvEquipment), Member = "Equip")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(InvDatabase), Member = "FindByID")]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public EquipItems()
	{
	}
}
