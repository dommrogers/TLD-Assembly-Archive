using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIButton : UIButtonColor
{
	public static UIButton current;

	public bool dragHighlight;

	public string hoverSprite;

	public string pressedSprite;

	public string disabledSprite;

	public Sprite hoverSprite2D;

	public Sprite pressedSprite2D;

	public Sprite disabledSprite2D;

	public bool pixelSnap;

	public List<EventDelegate> onClick;

	[NonSerialized]
	private UISprite mSprite;

	[NonSerialized]
	private UI2DSprite mSprite2D;

	[NonSerialized]
	private string mNormalSprite;

	[NonSerialized]
	private Sprite mNormalSprite2D;

	public override bool isEnabled
	{
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[Calls(Type = typeof(Collider), Member = "set_enabled")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 12)]
		set
		{
		}
	}

	public string normalSprite
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(UIButton), Member = "SetSprite")]
		[Calls(Type = typeof(UIButton), Member = "SetSprite")]
		[CalledBy(Type = typeof(UILocalize), Member = "set_value")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "OnSortChange")]
		[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
		[CalledBy(Type = typeof(Panel_Crafting.HighlightButton), Member = "SetHighlighted")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshBackpackDisplay")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "OnSortChange")]
		[CalledBy(Type = typeof(Panel_Crafting.HighlightButton), Member = "SetHighlighted")]
		[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
		set
		{
		}
	}

	public Sprite normalSprite2D
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIButton), Member = "SetSprite")]
		[Calls(Type = typeof(UIButton), Member = "SetSprite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIButtonColor), Member = "OnInit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnInit()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	protected override void OnDragOver()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	protected override void OnDragOut()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public override void SetState(State state, bool immediate)
	{
	}

	[CalledBy(Type = typeof(UIButton), Member = "set_normalSprite")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIButton), Member = "set_normalSprite")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	protected void SetSprite(string sp)
	{
	}

	[CalledBy(Type = typeof(UIButton), Member = "set_normalSprite2D")]
	[CalledBy(Type = typeof(UIButton), Member = "set_normalSprite2D")]
	[Calls(Type = typeof(UI2DSprite), Member = "set_sprite2D")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected void SetSprite(Sprite sp)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	public UIButton()
	{
	}
}
