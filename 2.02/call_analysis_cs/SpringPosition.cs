using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SpringPosition : MonoBehaviour
{
	public delegate void OnFinished();

	public static SpringPosition current;

	public Vector3 target;

	public float strength;

	public bool worldSpace;

	public bool ignoreTimeScale;

	public bool updateScrollView;

	public OnFinished onFinished;

	private GameObject eventReceiver;

	public string callWhenFinished;

	private Transform mTrans;

	private float mThreshold;

	private UIScrollView mSv;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(SpringPosition), Member = "NotifyListeners")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SpringPosition), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	private void NotifyListeners()
	{
	}

	[CalledBy(Type = typeof(UIGrid), Member = "ResetPosition")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	public static SpringPosition Begin(GameObject go, Vector3 pos, float strength)
	{
		return null;
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public SpringPosition()
	{
	}
}
