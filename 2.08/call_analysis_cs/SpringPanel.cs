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

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPanel), Member = "set_clipOffset")]
	protected virtual void AdvanceTowardsPosition()
	{
	}

	[CalledBy(Type = typeof(UICenterOnChild), Member = "CenterOn")]
	[CalledBy(Type = typeof(UIScrollView), Member = "RestrictWithinBounds")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UICenterOnClick), Member = "OnClick")]
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
