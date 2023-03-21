using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos;

public sealed class UIPointer : UIBehaviour
{
	private bool _hideHardwarePointer;

	private bool _autoSort;

	private Canvas _canvas;

	public bool autoSort
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPointer), Member = "GetDependencies")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPointer), Member = "GetDependencies")]
	protected override void OnTransformParentChanged()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPointer), Member = "GetDependencies")]
	protected override void OnCanvasGroupChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Canvas), Member = "get_worldCamera")]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 12)]
	public void OnScreenPositionChanged(Vector2 screenPosition)
	{
	}

	[CalledBy(Type = typeof(UIPointer), Member = "Awake")]
	[CalledBy(Type = typeof(UIPointer), Member = "OnTransformParentChanged")]
	[CalledBy(Type = typeof(UIPointer), Member = "OnCanvasGroupChanged")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void GetDependencies()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UIPointer()
	{
	}
}
