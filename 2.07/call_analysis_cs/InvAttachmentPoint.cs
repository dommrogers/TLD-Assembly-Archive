using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InvAttachmentPoint : MonoBehaviour
{
	public InvBaseItem.Slot slot;

	private GameObject mPrefab;

	private GameObject mChild;

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(InvEquipment), Member = "Replace")]
	[CalledBy(Type = typeof(InvEquipment), Member = "Replace")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 7)]
	public GameObject Attach(GameObject prefab)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InvAttachmentPoint()
	{
	}
}
