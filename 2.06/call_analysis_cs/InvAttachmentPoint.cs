using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InvAttachmentPoint : MonoBehaviour
{
	public InvBaseItem.Slot slot;

	private GameObject mPrefab;

	private GameObject mChild;

	[CalledBy(Type = typeof(InvEquipment), Member = "Replace")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public GameObject Attach(GameObject prefab)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public InvAttachmentPoint()
	{
	}
}
