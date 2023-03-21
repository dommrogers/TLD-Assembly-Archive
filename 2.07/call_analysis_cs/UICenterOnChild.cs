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
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UICenterOnChild), Member = "Recenter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnDisable()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnDragFinished()
	{
	}

	[CallerCount(Count = 0)]
	private void OnValidate()
	{
	}

	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UICenterOnChild), Member = "CenterOn")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIScrollView), Member = "Press")]
	[CalledBy(Type = typeof(UICenterOnChild), Member = "OnEnable")]
	[CalledBy(Type = typeof(UICenterOnChild), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[ContextMenu("Execute")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	public void Recenter()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UICenterOnChild), Member = "CenterOn")]
	[CalledBy(Type = typeof(UICenterOnChild), Member = "Recenter")]
	[Calls(Type = typeof(SpringPanel), Member = "Begin")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	private void CenterOn(Transform target, Vector3 panelCenter)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UICenterOnClick), Member = "OnClick")]
	[Calls(Type = typeof(UICenterOnChild), Member = "CenterOn")]
	[CallerCount(Count = 1)]
	public void CenterOn(Transform target)
	{
	}

	[CallerCount(Count = 0)]
	public UICenterOnChild()
	{
	}
}
