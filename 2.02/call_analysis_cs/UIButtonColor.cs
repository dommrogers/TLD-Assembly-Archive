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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public Color defaultColor
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(Color);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		set
		{
		}
	}

	public virtual bool isEnabled
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 164)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 230)]
		set
		{
		}
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnSortChange")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[CalledBy(Type = typeof(GridUI), Member = "RefreshGridItem")]
	[CallerCount(Count = 4)]
	public void ResetDefaultColor()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Light), Member = "get_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[CalledBy(Type = typeof(UIButton), Member = "OnInit")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying")]
	[CallerCount(Count = 1)]
	protected virtual void OnInit()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	protected virtual void OnEnable()
	{
	}

	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	protected virtual void OnDisable()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	protected virtual void OnHover(bool isOver)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	protected virtual void OnPress(bool isPressed)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	protected virtual void OnDragOver()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	protected virtual void OnDragOut()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UICamera), Member = "CountInputSources")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
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

	[CalledBy(Type = typeof(GridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(GenericScrollbarSpawner), Member = "AssignValuesToSpawnedObject")]
	[CalledBy(Type = typeof(GridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "SetButtonColors")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "EnableActionButton")]
	[CalledBy(Type = typeof(UIButtonColor), Member = "SetState")]
	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	[CalledBy(Type = typeof(CategoryButton), Member = "SetButtonColors")]
	[Calls(Type = typeof(TweenColor), Member = "Begin")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "EnableActionButton")]
	[CalledBy(Type = typeof(GenericScrollbarSpawner), Member = "AssignValuesToSpawnedObject")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateListItemColors")]
	public void UpdateColor(bool instant)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UIButtonColor()
	{
	}
}
