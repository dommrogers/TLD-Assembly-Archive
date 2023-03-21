using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
			[CallerCount(Count = 29)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
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

		[CallerCount(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIPopupList), Member = "GetHighlightPosition")]
		[CallsUnknownMethods(Count = 7)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
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
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
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
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIPopupList), Member = "Close")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public LegacyEvent onSelectionChange
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public bool isOpen
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[Calls(Type = typeof(UIPopupList), Member = "TriggerCallbacks")]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(LanguageSelection), Member = "Refresh")]
		set
		{
		}
	}

	public object data
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIPopupList), Member = "set_value")]
		set
		{
		}
	}

	private bool handleEvents
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Close")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		set
		{
		}
	}

	private bool isValid
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return default(bool);
		}
	}

	private int activeFontSize
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "AnimateScale")]
		[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UIPopupList), Member = "AnimateScale")]
		[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return default(float);
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void AddItem(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void AddItem(string text, object data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveItem(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveItemByData(object data)
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CalledBy(Type = typeof(UIPopupList), Member = "set_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnLocalize")]
	[CallerCount(Count = 3)]
	protected void TriggerCallbacks()
	{
	}

	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFontStyle")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFontStyle")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	private void OnValidate()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIPopupList), Member = "set_value")]
	[Calls(Type = typeof(UIPopupList), Member = "TriggerCallbacks")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPopupList), Member = "TriggerCallbacks")]
	private void OnLocalize()
	{
	}

	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(UIPopupList), Member = "GetHighlightPosition")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnItemHover")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Select")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Highlight(UILabel lbl, bool instant)
	{
	}

	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[Calls(Type = typeof(UIAtlas), Member = "get_pixelSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Highlight")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(_003CUpdateTweenPosition_003Ed__79), Member = "MoveNext")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	private Vector3 GetHighlightPosition()
	{
		return default(Vector3);
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator UpdateTweenPosition()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIPopupList), Member = "Highlight")]
	private void OnItemHover(GameObject go, bool isOver)
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "OnItemPress")]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[Calls(Type = typeof(UIPopupList), Member = "set_value")]
	[Calls(Type = typeof(UIPopupList), Member = "Highlight")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnKey")]
	private void Select(UILabel lbl, bool instant)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIPopupList), Member = "Select")]
	[CallsUnknownMethods(Count = 1)]
	private void OnItemPress(GameObject go, bool isPressed)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPopupList), Member = "Close")]
	private void OnItemClick(GameObject go)
	{
	}

	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPopupList), Member = "Close")]
	[Calls(Type = typeof(UIPopupList), Member = "Select")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	private void OnKey(KeyCode key)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(UIPopupList), Member = "Close")]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	private void OnSelect(bool isSelected)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(TweenColor), Member = "Begin")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnItemClick")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnKey")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnDisable")]
	[CalledBy(Type = typeof(_003CCloseIfUnselected_003Ed__94), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(UIPopupList), Member = "set_handleEvents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public void Close()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Animate")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
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

	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[Calls(Type = typeof(TweenScale), Member = "Begin")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UIPopupList), Member = "get_activeFontScale")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UIPopupList), Member = "get_activeFontSize")]
	[CallerCount(Count = 1)]
	private void AnimateScale(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIPopupList), Member = "AnimateColor")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	private void Animate(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPopupList), Member = "Show")]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPopupList), Member = "Show")]
	private void OnDoubleClick()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	private IEnumerator CloseIfUnselected()
	{
		return null;
	}

	[Calls(Type = typeof(UIEventListener), Member = "Get")]
	[Calls(Type = typeof(UIPopupList), Member = "Highlight")]
	[Calls(Type = typeof(Mathf), Member = "Max")]
	[Calls(Type = typeof(NGUITools), Member = "AddWidgetCollider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector2), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(BoxCollider), Member = "set_size")]
	[Calls(Type = typeof(BoxCollider), Member = "set_center")]
	[Calls(Type = typeof(BoxCollider), Member = "get_center")]
	[Calls(Type = typeof(BoxCollider2D), Member = "set_size")]
	[Calls(Type = typeof(Vector2), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider2D), Member = "set_offset")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UILabel), Member = "set_shouldBeProcessed")]
	[Calls(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UILabel), Member = "set_shouldBeProcessed")]
	[Calls(Type = typeof(UILabel), Member = "set_fontSize")]
	[Calls(Type = typeof(UILabel), Member = "set_shouldBeProcessed")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(UIPopupList), Member = "get_activeFontScale")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition_Injected")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallsUnknownMethods(Count = 177)]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnDoubleClick")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnClick")]
	[Calls(Type = typeof(UIPopupList), Member = "OnSelect")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition")]
	[Calls(Type = typeof(Vector3), Member = "op_Addition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(UIPopupList), Member = "get_activeFontSize")]
	[Calls(Type = typeof(Vector2), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector2), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition")]
	[Calls(Type = typeof(UIPopupList), Member = "AnimateScale")]
	[Calls(Type = typeof(UIPopupList), Member = "AnimateColor")]
	[Calls(Type = typeof(UIPopupList), Member = "Animate")]
	[Calls(Type = typeof(UIPopupList), Member = "Animate")]
	[Calls(Type = typeof(Camera), Member = "WorldToViewportPoint")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_overflowMethod")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIAtlas), Member = "get_pixelSize")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UICamera), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UIPanel), Member = "set_clipOffset")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "SetObjectAndChildrenLayer")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UIPopupList), Member = "set_handleEvents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPopupList), Member = "get_isValid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 35)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector2), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition_Injected")]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint")]
	[Calls(Type = typeof(NGUITools), Member = "AddSprite")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(NGUITools), Member = "CalculateNextDepth")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition_Injected")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition_Injected")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition_Injected")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Transform), Member = "set_localRotation_Injected")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Transform), Member = "set_localScale_Injected")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition_Injected")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	public void Show()
	{
	}

	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public UIPopupList()
	{
	}
}
