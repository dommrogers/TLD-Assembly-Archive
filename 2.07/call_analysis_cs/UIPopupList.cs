using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIPopupList : UIWidgetContainer
{
	public enum Position
	{
		Auto,
		Above,
		Below
	}

	public enum OpenOn
	{
		ClickOrTap,
		RightClick,
		DoubleClick,
		Manual
	}

	public delegate void LegacyEvent(string val);

	private sealed class _003CUpdateTweenPosition_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPopupList _003C_003E4__this;

		private TweenPosition _003Ctp_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(Count = 28)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 28)]
			[DeduplicatedMethod]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CUpdateTweenPosition_003Ed__79(int _003C_003E1__state)
		{
		}

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(UIPopupList), Member = "GetHighlightPosition")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CCloseIfUnselected_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPopupList _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 28)]
			[DeduplicatedMethod]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CCloseIfUnselected_003Ed__94(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIPopupList), Member = "Close")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public static UIPopupList current;

	private const float animSpeed = 0.15f;

	public Vector2 popupWindowSize;

	public UIAtlas atlas;

	public UIFont bitmapFont;

	public Font trueTypeFont;

	public int fontSize;

	public FontStyle fontStyle;

	public string backgroundSprite;

	public string highlightSprite;

	public Position position;

	public NGUIText.Alignment alignment;

	public List<string> items;

	public List<object> itemData;

	public Vector2 padding;

	public Color textColor;

	public Color backgroundColor;

	public Color highlightColor;

	public bool isAnimated;

	public bool isLocalized;

	public OpenOn openOn;

	public List<EventDelegate> onChange;

	private string mSelectedItem;

	private UIPanel mPanel;

	private GameObject mChild;

	private UISprite mBackground;

	private UISprite mHighlight;

	private UILabel mHighlightedLabel;

	private List<UILabel> mLabelList;

	private float mBgBorder;

	[NonSerialized]
	private GameObject mSelection;

	private GameObject eventReceiver;

	private string functionName;

	private float textScale;

	private UIFont font;

	private UILabel textLabel;

	private LegacyEvent mLegacyEvent;

	private bool mUseDynamicFont;

	private bool mTweening;

	public UnityEngine.Object ambigiousFont
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public LegacyEvent onSelectionChange
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public bool isOpen
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public string value
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Select")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Start")]
		[CalledBy(Type = typeof(UIPopupList), Member = "set_selection")]
		[CalledBy(Type = typeof(LanguageSelection), Member = "Refresh")]
		[Calls(Type = typeof(UIPopupList), Member = "TriggerCallbacks")]
		[CallerCount(Count = 5)]
		set
		{
		}
	}

	public object data
	{
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string selection
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UIPopupList), Member = "set_value")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	private bool handleEvents
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Close")]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	private bool isValid
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	private int activeFontSize
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "AnimateScale")]
		[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		get
		{
			return default(int);
		}
	}

	private float activeFontScale
	{
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(UIPopupList), Member = "AnimateScale")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
		get
		{
			return default(float);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Clear()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void AddItem(string text)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void AddItem(string text, object data)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void RemoveItem(string text)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void RemoveItemByData(object data)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnLocalize")]
	[CalledBy(Type = typeof(UIPopupList), Member = "set_value")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void TriggerCallbacks()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFontStyle")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[CallsUnknownMethods(Count = 5)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFontStyle")]
	private void OnValidate()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UIPopupList), Member = "set_value")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPopupList), Member = "TriggerCallbacks")]
	private void OnLocalize()
	{
	}

	[Calls(Type = typeof(UIPopupList), Member = "GetHighlightPosition")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnItemHover")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Select")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[CallerCount(Count = 3)]
	private void Highlight(UILabel lbl, bool instant)
	{
	}

	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CalledBy(Type = typeof(_003CUpdateTweenPosition_003Ed__79), Member = "MoveNext")]
	[Calls(Type = typeof(UIAtlas), Member = "get_pixelSize")]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIPopupList), Member = "Highlight")]
	[CallsUnknownMethods(Count = 2)]
	private Vector3 GetHighlightPosition()
	{
		return default(Vector3);
	}

	[IteratorStateMachine(typeof(_003CUpdateTweenPosition_003Ed__79))]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private IEnumerator UpdateTweenPosition()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPopupList), Member = "Highlight")]
	[CallsUnknownMethods(Count = 1)]
	private void OnItemHover(GameObject go, bool isOver)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnItemPress")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnKey")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UIPopupList), Member = "set_value")]
	[Calls(Type = typeof(UIPopupList), Member = "Highlight")]
	private void Select(UILabel lbl, bool instant)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPopupList), Member = "Select")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnItemPress(GameObject go, bool isPressed)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPopupList), Member = "Close")]
	private void OnItemClick(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UIPopupList), Member = "Select")]
	[Calls(Type = typeof(UIPopupList), Member = "Close")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	private void OnKey(KeyCode key)
	{
	}

	[Calls(Type = typeof(UIPopupList), Member = "Close")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnDisable()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnSelect(bool isSelected)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnDisable")]
	[Calls(Type = typeof(UIPopupList), Member = "set_handleEvents")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnKey")]
	[CalledBy(Type = typeof(_003CCloseIfUnselected_003Ed__94), Member = "MoveNext")]
	[Calls(Type = typeof(TweenColor), Member = "Begin")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnItemClick")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 6)]
	public void Close()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPopupList), Member = "Animate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TweenColor), Member = "Begin")]
	private void AnimateColor(UIWidget widget)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	private void AnimatePosition(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[Calls(Type = typeof(TweenScale), Member = "Begin")]
	[Calls(Type = typeof(UIPopupList), Member = "get_activeFontScale")]
	[Calls(Type = typeof(UIPopupList), Member = "get_activeFontSize")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallsUnknownMethods(Count = 5)]
	private void AnimateScale(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[Calls(Type = typeof(UIPopupList), Member = "AnimateColor")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallerCount(Count = 2)]
	private void Animate(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPopupList), Member = "Show")]
	private void OnClick()
	{
	}

	[Calls(Type = typeof(UIPopupList), Member = "Show")]
	[CallerCount(Count = 0)]
	private void OnDoubleClick()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[IteratorStateMachine(typeof(_003CCloseIfUnselected_003Ed__94))]
	private IEnumerator CloseIfUnselected()
	{
		return null;
	}

	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(UIPopupList), Member = "Highlight")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UIEventListener), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[Calls(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[Calls(Type = typeof(NGUITools), Member = "AddWidgetCollider")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[Calls(Type = typeof(UIPopupList), Member = "get_activeFontSize")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[Calls(Type = typeof(UIPopupList), Member = "get_activeFontScale")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnDoubleClick")]
	[Calls(Type = typeof(BoxCollider2D), Member = "set_size")]
	[CallsUnknownMethods(Count = 48)]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnClick")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UIPopupList), Member = "Close")]
	[Calls(Type = typeof(UIPopupList), Member = "AnimateColor")]
	[Calls(Type = typeof(UIPopupList), Member = "Animate")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UIPopupList), Member = "Animate")]
	[Calls(Type = typeof(Camera), Member = "WorldToViewportPoint")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIAtlas), Member = "get_pixelSize")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(BoxCollider), Member = "set_size")]
	[Calls(Type = typeof(BoxCollider), Member = "set_center")]
	[Calls(Type = typeof(BoxCollider), Member = "get_center")]
	[Calls(Type = typeof(Collider2D), Member = "set_offset")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIPopupList), Member = "AnimateScale")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UIPanel), Member = "set_clipOffset")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(Utils), Member = "SetObjectAndChildrenLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UIPopupList), Member = "set_handleEvents")]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 47)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UIRect), Member = "get_anchorCamera")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(NGUITools), Member = "CalculateNextDepth")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_localScale")]
	[Calls(Type = typeof(Transform), Member = "set_localRotation")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public void Show()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public UIPopupList()
	{
	}
}
