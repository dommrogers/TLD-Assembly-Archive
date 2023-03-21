using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MeshSwapItem : MonoBehaviour
{
	public GameObject m_MeshObjUnopened;

	public GameObject m_MeshObjOpened;

	public GameObject m_MeshObjCookingReady;

	private GearItem m_GearItem;

	private bool m_InCookingReadyState;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(MeshSwapItem), Member = "EnableMesh")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetCookingReady(bool isCookingReady)
	{
	}

	[CalledBy(Type = typeof(MeshSwapItem), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void EnableMesh(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private bool IsOpened()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MeshSwapItem()
	{
	}
}
