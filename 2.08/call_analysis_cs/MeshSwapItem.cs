using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MeshSwapItem : MonoBehaviour
{
	public GameObject m_MeshObjUnopened;

	public GameObject m_MeshObjOpened;

	public GameObject m_MeshObjCookingReady;

	private GearItem m_GearItem;

	private bool m_InCookingReadyState;

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MeshSwapItem), Member = "EnableMesh")]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public void SetCookingReady(bool isCookingReady)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(MeshSwapItem), Member = "Awake")]
	private void EnableMesh(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private bool IsOpened()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MeshSwapItem()
	{
	}
}
