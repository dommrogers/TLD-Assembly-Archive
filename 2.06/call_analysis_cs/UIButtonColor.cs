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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(State);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 59)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 226)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnSortChange")]
	[CalledBy(Type = typeof(GridUI), Member = "RefreshGridItem")]
	public void ResetDefaultColor()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Start()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIButton), Member = "OnInit")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(Light), Member = "get_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	protected virtual void OnInit()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	protected virtual void OnEnable()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	protected virtual void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	protected virtual void OnHover(bool isOver)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	protected virtual void OnPress(bool isPressed)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	protected virtual void OnDragOver()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	protected virtual void OnDragOut()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UICamera), Member = "CountInputSources")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected virtual void OnSelect(bool isSelected)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	public virtual void SetState(State state, bool instant)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "EnableActionButton")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "EnableActionButton")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateListItemColors")]
	[CalledBy(Type = typeof(GenericScrollbarSpawner), Member = "AssignValuesToSpawnedObject")]
	[CalledBy(Type = typeof(GenericScrollbarSpawner), Member = "AssignValuesToSpawnedObject")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "SetButtonColors")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(GridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(GridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(CategoryButton), Member = "SetButtonColors")]
	[CalledBy(Type = typeof(UIButtonColor), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TweenColor), Member = "Begin")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	public void UpdateColor(bool instant)
	{
	}

	[CallerCount(Count = 0)]
	public UIButtonColor()
	{
	}
}
