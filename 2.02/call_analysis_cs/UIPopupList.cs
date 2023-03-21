using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
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
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[Calls(Type = typeof(UIPopupList), Member = "GetHighlightPosition")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
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
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
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
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIPopupList), Member = "Close")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
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
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
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
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
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
		[CalledBy(Type = typeof(LanguageSelection), Member = "Refresh")]
		[CalledBy(Type = typeof(UIPopupList), Member = "set_selection")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Start")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Select")]
		[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(UIPopupList), Member = "TriggerCallbacks")]
		set
		{
		}
	}

	public object data
	{
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	public string selection
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return false;
		}
		[CalledBy(Type = typeof(UIPopupList), Member = "Close")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	private bool isValid
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	private int activeFontSize
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "AnimateScale")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	private float activeFontScale
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "AnimateScale")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AddItem(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AddItem(string text, object data)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveItem(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveItemByData(object data)
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "set_value")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Start")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnLocalize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected void TriggerCallbacks()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFontStyle")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFontStyle")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UIPopupList), Member = "TriggerCallbacks")]
	[Calls(Type = typeof(UIPopupList), Member = "set_value")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPopupList), Member = "TriggerCallbacks")]
	private void OnLocalize()
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "OnItemHover")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Select")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[Calls(Type = typeof(UIPopupList), Member = "GetHighlightPosition")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void Highlight(UILabel lbl, bool instant)
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "Highlight")]
	[CalledBy(Type = typeof(_003CUpdateTweenPosition_003Ed__79), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[Calls(Type = typeof(UIAtlas), Member = "get_pixelSize")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private Vector3 GetHighlightPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator UpdateTweenPosition()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UIPopupList), Member = "Highlight")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnItemHover(GameObject go, bool isOver)
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "OnItemPress")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnKey")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIPopupList), Member = "Highlight")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UIPopupList), Member = "set_value")]
	[Calls(Type = typeof(Component), Member = "GetComponents")]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void Select(UILabel lbl, bool instant)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UIPopupList), Member = "Select")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPopupList), Member = "Close")]
	[Calls(Type = typeof(UIPopupList), Member = "Select")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private void OnKey(KeyCode key)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPopupList), Member = "Close")]
	private void OnDisable()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallerCount(Count = 1)]
	private void OnSelect(bool isSelected)
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "OnItemClick")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnKey")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnDisable")]
	[CalledBy(Type = typeof(_003CCloseIfUnselected_003Ed__94), Member = "MoveNext")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UIPopupList), Member = "set_handleEvents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(TweenColor), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 16)]
	public void Close()
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "Animate")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(TweenColor), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void AnimateColor(UIWidget widget)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void AnimatePosition(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIPopupList), Member = "get_activeFontSize")]
	[Calls(Type = typeof(UIPopupList), Member = "get_activeFontScale")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(TweenScale), Member = "Begin")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void AnimateScale(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIPopupList), Member = "AnimateColor")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Animate(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPopupList), Member = "Show")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPopupList), Member = "Show")]
	private void OnDoubleClick()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator CloseIfUnselected()
	{
		return null;
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "OnClick")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnDoubleClick")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIPopupList), Member = "get_isValid")]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[Calls(Type = typeof(UIPopupList), Member = "set_handleEvents")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(Utils), Member = "SetObjectAndChildrenLayer")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(UIPanel), Member = "set_clipOffset")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(Vector2), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint")]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition_Injected")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Transform), Member = "set_localRotation_Injected")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Transform), Member = "set_localScale_Injected")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(NGUITools), Member = "CalculateNextDepth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUITools), Member = "AddSprite")]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[Calls(Type = typeof(UIPopupList), Member = "get_activeFontSize")]
	[Calls(Type = typeof(UIPopupList), Member = "get_activeFontScale")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "get_Item")]
	[Calls(Type = typeof(NGUITools), Member = "AddWidget")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[Calls(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[Calls(Type = typeof(UILabel), Member = "set_fontSize")]
	[Calls(Type = typeof(UILabel), Member = "set_shouldBeProcessed")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UIEventListener), Member = "Get")]
	[Calls(Type = typeof(UIPopupList), Member = "Highlight")]
	[Calls(Type = typeof(Mathf), Member = "Max")]
	[Calls(Type = typeof(NGUITools), Member = "AddWidgetCollider")]
	[Calls(Type = typeof(Vector2), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider2D), Member = "set_offset")]
	[Calls(Type = typeof(BoxCollider2D), Member = "set_size")]
	[Calls(Type = typeof(BoxCollider), Member = "get_center")]
	[Calls(Type = typeof(BoxCollider), Member = "set_center")]
	[Calls(Type = typeof(BoxCollider), Member = "set_size")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_overflowMethod")]
	[Calls(Type = typeof(UIAtlas), Member = "get_pixelSize")]
	[Calls(Type = typeof(UICamera), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[Calls(Type = typeof(Camera), Member = "WorldToViewportPoint")]
	[Calls(Type = typeof(UIPopupList), Member = "Animate")]
	[Calls(Type = typeof(UIPopupList), Member = "AnimateColor")]
	[Calls(Type = typeof(UIPopupList), Member = "AnimateScale")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Vector3), Member = "op_Addition")]
	[Calls(Type = typeof(UIPopupList), Member = "OnSelect")]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallsUnknownMethods(Count = 169)]
	public void Show()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 28)]
	public UIPopupList()
	{
	}
}
