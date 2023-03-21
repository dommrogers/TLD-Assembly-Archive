using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIButtonColor : UIWidgetContainer
{
	public enum State
	{
		Normal,
		Hover,
		Pressed,
		Disabled
	}

	public GameObject tweenTarget;

	public Color hover;

	public Color pressed;

	public Color disabledColor;

	public float duration;

	[NonSerialized]
	protected Color mStartingColor;

	[NonSerialized]
	protected Color mDefaultColor;

	[NonSerialized]
	protected bool mInitDone;

	[NonSerialized]
	protected UIWidget mWidget;

	[NonSerialized]
	protected State mState;

	public State state
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(State);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public Color defaultColor
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(Color);
		}
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual bool isEnabled
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 58)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 212)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CalledBy(Type = typeof(GridUI), Member = "RefreshGridItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnSortChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	public void ResetDefaultColor()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(UIButton), Member = "OnInit")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	protected virtual void OnInit()
	{
	}

	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	protected virtual void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	protected virtual void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	protected virtual void OnHover(bool isOver)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	protected virtual void OnPress(bool isPressed)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	protected virtual void OnDragOver()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	protected virtual void OnDragOut()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICamera), Member = "CountInputSources")]
	protected virtual void OnSelect(bool isSelected)
	{
	}

	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void SetState(State state, bool instant)
	{
	}

	[CalledBy(Type = typeof(CategoryButton), Member = "SetButtonColors")]
	[CalledBy(Type = typeof(GridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(GridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "SetButtonColors")]
	[CalledBy(Type = typeof(UIButtonColor), Member = "SetState")]
	[Calls(Type = typeof(TweenColor), Member = "Begin")]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "EnableActionButton")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "EnableActionButton")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateListItemColors")]
	[CalledBy(Type = typeof(GenericScrollbarSpawner), Member = "AssignValuesToSpawnedObject")]
	[CalledBy(Type = typeof(GenericScrollbarSpawner), Member = "AssignValuesToSpawnedObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	public void UpdateColor(bool instant)
	{
	}

	[CallerCount(Count = 0)]
	public UIButtonColor()
	{
	}
}
