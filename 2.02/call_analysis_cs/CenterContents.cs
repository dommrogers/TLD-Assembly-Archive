using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CenterContents : MonoBehaviour
{
	public Transform targetRoot;

	public int padLeft;

	public int padRight;

	public int padBottom;

	public int padTop;

	private bool mStarted;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CenterContents), Member = "LateUpdate")]
	private void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(CenterContents), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(NGUITools), Member = "IsChild")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	public void LateUpdate()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CenterContents()
	{
	}
}
