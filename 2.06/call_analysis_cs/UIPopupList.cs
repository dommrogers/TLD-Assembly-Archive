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
			[CallerCount(Count = 44)]
			[DeduplicatedMethod]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
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

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIPopupList), Member = "GetHighlightPosition")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
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
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIPopupList), Member = "Close")]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 5)]
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
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return default(bool);
		}
	}

	public string value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(LanguageSelection), Member = "Refresh")]
		[Calls(Type = typeof(UIPopupList), Member = "TriggerCallbacks")]
		[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Select")]
		[CalledBy(Type = typeof(UIPopupList), Member = "set_selection")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Start")]
		set
		{
		}
	}

	public object data
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return default(bool);
		}
		[CalledBy(Type = typeof(UIPopupList), Member = "Close")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		set
		{
		}
	}

	private bool isValid
	{
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return default(bool);
		}
	}

	private int activeFontSize
	{
		[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIPopupList), Member = "AnimateScale")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		get
		{
			return default(int);
		}
	}

	private float activeFontScale
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UIPopupList), Member = "AnimateScale")]
		[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 2)]
		get
		{
			return default(float);
		}
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void AddItem(string text)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void AddItem(string text, object data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveItem(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveItemByData(object data)
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "OnLocalize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIPopupList), Member = "set_value")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[CallerCount(Count = 2)]
	protected void TriggerCallbacks()
	{
	}

	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFontStyle")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFontStyle")]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UIPopupList), Member = "set_value")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPopupList), Member = "TriggerCallbacks")]
	private void OnLocalize()
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "OnItemHover")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Select")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[Calls(Type = typeof(UIPopupList), Member = "GetHighlightPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Highlight(UILabel lbl, bool instant)
	{
	}

	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[CalledBy(Type = typeof(_003CUpdateTweenPosition_003Ed__79), Member = "MoveNext")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Highlight")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIAtlas), Member = "get_pixelSize")]
	private Vector3 GetHighlightPosition()
	{
		return default(Vector3);
	}

	[IteratorStateMachine(typeof(_003CUpdateTweenPosition_003Ed__79))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator UpdateTweenPosition()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPopupList), Member = "Highlight")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnItemHover(GameObject go, bool isOver)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnItemPress")]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[Calls(Type = typeof(UIPopupList), Member = "set_value")]
	[Calls(Type = typeof(UIPopupList), Member = "Highlight")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnKey")]
	private void Select(UILabel lbl, bool instant)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPopupList), Member = "Select")]
	[CallsUnknownMethods(Count = 1)]
	private void OnItemPress(GameObject go, bool isPressed)
	{
	}

	[Calls(Type = typeof(UIPopupList), Member = "Close")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnItemClick(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIPopupList), Member = "Close")]
	[Calls(Type = typeof(UIPopupList), Member = "Select")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 5)]
	private void OnKey(KeyCode key)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPopupList), Member = "Close")]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	private void OnSelect(bool isSelected)
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnKey")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnItemClick")]
	[CalledBy(Type = typeof(_003CCloseIfUnselected_003Ed__94), Member = "MoveNext")]
	[Calls(Type = typeof(TweenColor), Member = "Begin")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UIPopupList), Member = "set_handleEvents")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 4)]
	public void Close()
	{
	}

	[Calls(Type = typeof(TweenColor), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPopupList), Member = "Animate")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void AnimateColor(UIWidget widget)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[CallsUnknownMethods(Count = 4)]
	private void AnimatePosition(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIPopupList), Member = "get_activeFontScale")]
	[Calls(Type = typeof(TweenScale), Member = "Begin")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UIPopupList), Member = "get_activeFontSize")]
	private void AnimateScale(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIPopupList), Member = "AnimateColor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Animate(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPopupList), Member = "Show")]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPopupList), Member = "Show")]
	private void OnDoubleClick()
	{
	}

	[IteratorStateMachine(typeof(_003CCloseIfUnselected_003Ed__94))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator CloseIfUnselected()
	{
		return null;
	}

	[Calls(Type = typeof(UIPopupList), Member = "Highlight")]
	[Calls(Type = typeof(UIEventListener), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(NGUITools), Member = "AddWidgetCollider")]
	[Calls(Type = typeof(BoxCollider), Member = "get_center")]
	[Calls(Type = typeof(BoxCollider2D), Member = "set_size")]
	[Calls(Type = typeof(Vector2), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider2D), Member = "set_offset")]
	[Calls(Type = typeof(Vector2), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Max")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UILabel), Member = "set_alignment")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition_Injected")]
	[Calls(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_fontStyle")]
	[Calls(Type = typeof(BoxCollider), Member = "set_center")]
	[Calls(Type = typeof(UILabel), Member = "set_fontSize")]
	[Calls(Type = typeof(UIPopupList), Member = "get_activeFontSize")]
	[Calls(Type = typeof(UIPopupList), Member = "get_activeFontScale")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(BoxCollider), Member = "set_size")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallsUnknownMethods(Count = 126)]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnDoubleClick")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnClick")]
	[Calls(Type = typeof(UIPopupList), Member = "OnSelect")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition")]
	[Calls(Type = typeof(Vector3), Member = "op_Addition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[Calls(Type = typeof(Vector2), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector2), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition")]
	[Calls(Type = typeof(UIPopupList), Member = "AnimateScale")]
	[Calls(Type = typeof(UIPopupList), Member = "AnimateColor")]
	[Calls(Type = typeof(UIPopupList), Member = "Animate")]
	[Calls(Type = typeof(UIPopupList), Member = "Animate")]
	[Calls(Type = typeof(Camera), Member = "WorldToViewportPoint")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIAtlas), Member = "get_pixelSize")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UILabel), Member = "set_overflowMethod")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "AddSprite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UIPanel), Member = "set_clipOffset")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "SetObjectAndChildrenLayer")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UIPopupList), Member = "set_handleEvents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPopupList), Member = "get_isValid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 40)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition_Injected")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(NGUITools), Member = "CalculateNextDepth")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition_Injected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition_Injected")]
	[Calls(Type = typeof(Transform), Member = "set_localRotation_Injected")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition_Injected")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition_Injected")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Transform), Member = "set_localScale_Injected")]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint")]
	[Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint")]
	public void Show()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public UIPopupList()
	{
	}
}
