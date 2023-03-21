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

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(SpringPosition), Member = "NotifyListeners")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CalledBy(Type = typeof(SpringPosition), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void NotifyListeners()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[CalledBy(Type = typeof(UIGrid), Member = "ResetPosition")]
	[CalledBy(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static SpringPosition Begin(GameObject go, Vector3 pos, float strength)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SpringPosition()
	{
	}
}
