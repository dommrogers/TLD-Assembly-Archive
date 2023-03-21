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
	[CallsDeduplicatedMethods(Count = 3)]
	private void Start()
	{
	}

	[Calls(Type = typeof(SpringPosition), Member = "NotifyListeners")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SpringPosition), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void NotifyListeners()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[CalledBy(Type = typeof(UIGrid), Member = "ResetPosition")]
	[CalledBy(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public static SpringPosition Begin(GameObject go, Vector3 pos, float strength)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SpringPosition()
	{
	}
}
