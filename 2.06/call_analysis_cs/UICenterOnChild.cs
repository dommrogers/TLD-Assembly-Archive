using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UICenterOnChild : MonoBehaviour
{
	public delegate void OnCenterCallback(GameObject centeredObject);

	public float springStrength;

	public float nextPageThreshold;

	public SpringPanel.OnFinished onFinished;

	public OnCenterCallback onCenter;

	private UIScrollView mScrollView;

	private GameObject mCenteredObject;

	public GameObject centeredObject
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICenterOnChild), Member = "Recenter")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UICenterOnChild), Member = "Recenter")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void OnDragFinished()
	{
	}

	[CallerCount(Count = 0)]
	private void OnValidate()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UICenterOnChild), Member = "CenterOn")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UICenterOnChild), Member = "Start")]
	[CalledBy(Type = typeof(UICenterOnChild), Member = "OnEnable")]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[ContextMenu("Execute")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIScrollView), Member = "Press")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
	public void Recenter()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CalledBy(Type = typeof(UICenterOnChild), Member = "CenterOn")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(SpringPanel), Member = "Begin")]
	[CalledBy(Type = typeof(UICenterOnChild), Member = "Recenter")]
	private void CenterOn(Transform target, Vector3 panelCenter)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UICenterOnChild), Member = "CenterOn")]
	[CalledBy(Type = typeof(UICenterOnClick), Member = "OnClick")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void CenterOn(Transform target)
	{
	}

	[CallerCount(Count = 0)]
	public UICenterOnChild()
	{
	}
}
