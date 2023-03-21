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
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Collider), Member = "set_enabled")]
		[CallsDeduplicatedMethods(Count = 10)]
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
		[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
		[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshBackpackDisplay")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "OnSortChange")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "OnSortChange")]
		[CalledBy(Type = typeof(Panel_Crafting.HighlightButton), Member = "SetHighlighted")]
		[CalledBy(Type = typeof(Panel_Crafting.HighlightButton), Member = "SetHighlighted")]
		[CalledBy(Type = typeof(UILocalize), Member = "set_value")]
		[Calls(Type = typeof(UIButton), Member = "SetSprite")]
		[Calls(Type = typeof(UIButton), Member = "SetSprite")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 10)]
		set
		{
		}
	}

	public Sprite normalSprite2D
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIButton), Member = "SetSprite")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIButton), Member = "SetSprite")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIButtonColor), Member = "OnInit")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnInit()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	protected override void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	protected override void OnDragOver()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	protected override void OnDragOut()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public override void SetState(State state, bool immediate)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIButton), Member = "set_normalSprite")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIButton), Member = "set_normalSprite")]
	protected void SetSprite(string sp)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UI2DSprite), Member = "set_sprite2D")]
	[CalledBy(Type = typeof(UIButton), Member = "set_normalSprite2D")]
	[CalledBy(Type = typeof(UIButton), Member = "set_normalSprite2D")]
	[CallsUnknownMethods(Count = 1)]
	protected void SetSprite(Sprite sp)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public UIButton()
	{
	}
}
