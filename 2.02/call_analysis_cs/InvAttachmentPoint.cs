using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InvAttachmentPoint : MonoBehaviour
{
	public InvBaseItem.Slot slot;

	private GameObject mPrefab;

	private GameObject mChild;

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(InvEquipment), Member = "Replace")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	public GameObject Attach(GameObject prefab)
	{
		return null;
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InvAttachmentPoint()
	{
	}
}
