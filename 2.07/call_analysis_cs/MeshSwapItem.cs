using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MeshSwapItem : MonoBehaviour
{
	public GameObject m_MeshObjUnopened;

	public GameObject m_MeshObjOpened;

	public GameObject m_MeshObjCookingReady;

	private GearItem m_GearItem;

	private bool m_InCookingReadyState;

	[Calls(Type = typeof(MeshSwapItem), Member = "EnableMesh")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public void SetCookingReady(bool isCookingReady)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(MeshSwapItem), Member = "Awake")]
	[CallsUnknownMethods(Count = 1)]
	private void EnableMesh(GameObject go)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private bool IsOpened()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MeshSwapItem()
	{
	}
}
