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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MeshSwapItem), Member = "EnableMesh")]
	private void Awake()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	public void SetCookingReady(bool isCookingReady)
	{
	}

	[CalledBy(Type = typeof(MeshSwapItem), Member = "Awake")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void EnableMesh(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsOpened()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public MeshSwapItem()
	{
	}
}
