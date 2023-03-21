using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EquipItems : MonoBehaviour
{
	public int[] itemIDs;

	[Calls(Type = typeof(InvGameItem), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvDatabase), Member = "FindByID")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(InvEquipment), Member = "Equip")]
	[Calls(Type = typeof(NGUITools), Member = "RandomRange")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public EquipItems()
	{
	}
}
