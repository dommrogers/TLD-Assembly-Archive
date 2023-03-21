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
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UIPointer), Member = "GetDependencies")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle")]
	[Calls(Type = typeof(Canvas), Member = "get_worldCamera")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public void OnScreenPositionChanged(Vector2 screenPosition)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(UIPointer), Member = "Awake")]
	[CalledBy(Type = typeof(UIPointer), Member = "OnTransformParentChanged")]
	[CalledBy(Type = typeof(UIPointer), Member = "OnCanvasGroupChanged")]
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
