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

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 26)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[Calls(Type = typeof(UIPanel), Member = "set_clipOffset")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	protected virtual void AdvanceTowardsPosition()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIScrollView), Member = "RestrictWithinBounds")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(UICenterOnChild), Member = "CenterOn")]
	[CalledBy(Type = typeof(UICenterOnClick), Member = "OnClick")]
	public static SpringPanel Begin(GameObject go, Vector3 pos, float strength)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallerCount(Count = 0)]
	public SpringPanel()
	{
	}
}
