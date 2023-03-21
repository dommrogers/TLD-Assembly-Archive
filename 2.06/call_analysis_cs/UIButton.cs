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
		[CallsDeduplicatedMethods(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return default(bool);
		}
		[CallsDeduplicatedMethods(Count = 10)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Collider), Member = "set_enabled")]
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		set
		{
		}
	}

	public string normalSprite
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "OnSortChange")]
		[CalledBy(Type = typeof(Panel_Crafting.HighlightButton), Member = "SetHighlighted")]
		[CalledBy(Type = typeof(Panel_Crafting.HighlightButton), Member = "SetHighlighted")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "OnSortChange")]
		[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
		[CalledBy(Type = typeof(Panel_Inventory), Member = "OnSortChange")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
		[CalledBy(Type = typeof(UILocalize), Member = "set_value")]
		[Calls(Type = typeof(UIButton), Member = "SetSprite")]
		[Calls(Type = typeof(UIButton), Member = "SetSprite")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
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
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIButton), Member = "SetSprite")]
		[Calls(Type = typeof(UIButton), Member = "SetSprite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIButtonColor), Member = "OnInit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	protected override void OnInit()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[CallerCount(Count = 0)]
	protected override void OnEnable()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	protected override void OnDragOver()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	protected override void OnDragOut()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	protected virtual void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public override void SetState(State state, bool immediate)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(UIButton), Member = "set_normalSprite")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIButton), Member = "set_normalSprite")]
	protected void SetSprite(string sp)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIButton), Member = "set_normalSprite2D")]
	[CalledBy(Type = typeof(UIButton), Member = "set_normalSprite2D")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UI2DSprite), Member = "set_sprite2D")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void SetSprite(Sprite sp)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	public UIButton()
	{
	}
}
