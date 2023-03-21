using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EquipItems : MonoBehaviour
{
	public int[] itemIDs;

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InvGameItem), Member = ".ctor")]
	[Calls(Type = typeof(NGUITools), Member = "RandomRange")]
	[Calls(Type = typeof(InvEquipment), Member = "Equip")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(InvDatabase), Member = "FindByID")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void Start()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public EquipItems()
	{
	}
}
