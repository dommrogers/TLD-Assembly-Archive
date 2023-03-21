using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InvAttachmentPoint : MonoBehaviour
{
	public InvBaseItem.Slot slot;

	private GameObject mPrefab;

	private GameObject mChild;

	[CalledBy(Type = typeof(InvEquipment), Member = "Replace")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public GameObject Attach(GameObject prefab)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public InvAttachmentPoint()
	{
	}
}
