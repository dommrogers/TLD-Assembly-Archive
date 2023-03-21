using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SpringPanel : MonoBehaviour
{
	public delegate void OnFinished();

	public static SpringPanel current;

	public Vector3 target;

	public float strength;

	public OnFinished onFinished;

	private UIPanel mPanel;

	private Transform mTrans;

	private UIScrollView mDrag;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[Calls(Type = typeof(UIPanel), Member = "set_clipOffset")]
	[CallsDeduplicatedMethods(Count = 7)]
	protected virtual void AdvanceTowardsPosition()
	{
	}

	[CalledBy(Type = typeof(UICenterOnChild), Member = "CenterOn")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIScrollView), Member = "RestrictWithinBounds")]
	[CalledBy(Type = typeof(UICenterOnClick), Member = "OnClick")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	public static SpringPanel Begin(GameObject go, Vector3 pos, float strength)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SpringPanel()
	{
	}
}
