using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIInput : MonoBehaviour
{
	public enum InputType
	{
		Standard,
		AutoCorrect,
		Password
	}

	public enum Validation
	{
		None,
		Integer,
		Float,
		Alphanumeric,
		Username,
		Name
	}

	public enum KeyboardType
	{
		Default,
		ASCIICapable,
		NumbersAndPunctuation,
		URL,
		NumberPad,
		PhonePad,
		NamePhonePad,
		EmailAddress
	}

	public enum OnReturnKey
	{
		Default,
		Submit,
		NewLine
	}

	public delegate char OnValidate(string text, int charIndex, char addedChar);

	public static UIInput current;

	public static UIInput selection;

	public UILabel label;

	public InputType inputType;

	public OnReturnKey onReturnKey;

	public KeyboardType keyboardType;

	public bool hideInput;

	[NonSerialized]
	public bool selectAllTextOnFocus;

	public Validation validation;

	public int characterLimit;

	public string savedAs;

	private GameObject selectOnTab;

	public Color activeTextColor;

	public Color caretColor;

	public Color selectionColor;

	public List<EventDelegate> onSubmit;

	public List<EventDelegate> onChange;

	public OnValidate onValidate;

	protected string mValue;

	[NonSerialized]
	protected string mDefaultText;

	[NonSerialized]
	protected Color mDefaultColor;

	[NonSerialized]
	protected float mPosition;

	[NonSerialized]
	protected bool mDoInit;

	[NonSerialized]
	protected UIWidget.Pivot mPivot;

	[NonSerialized]
	protected bool mLoadSavedValue;

	protected static int mDrawStart;

	protected static string mLastIME;

	[NonSerialized]
	protected int mSelectionStart;

	[NonSerialized]
	protected int mSelectionEnd;

	[NonSerialized]
	protected UITexture mHighlight;

	[NonSerialized]
	protected UITexture mCaret;

	[NonSerialized]
	protected Texture2D mBlankTex;

	[NonSerialized]
	protected float mNextBlink;

	[NonSerialized]
	protected float mLastAlpha;

	[NonSerialized]
	protected string mCached;

	[NonSerialized]
	protected int mSelectMe;

	[NonSerialized]
	private UIInputOnGUI mOnGUI;

	public string defaultText
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UILocalize), Member = "set_value")]
		[CalledBy(Type = typeof(TextInputField), Member = "SetText")]
		[CalledBy(Type = typeof(TextInputField), Member = "Select")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
		set
		{
		}
	}

	public bool inputShouldBeHidden
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public string text
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIInput), Member = "set_value")]
		set
		{
		}
	}

	public string value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ChatInput), Member = "OnSubmit")]
		[CalledBy(Type = typeof(UIInput), Member = "set_text")]
		[CalledBy(Type = typeof(UIInput), Member = "Start")]
		[CalledBy(Type = typeof(UIInput), Member = "LoadValue")]
		[CalledBy(Type = typeof(TextInputField), Member = "Update")]
		[CalledBy(Type = typeof(TextInputField), Member = "SetText")]
		[CalledBy(Type = typeof(TextInputField), Member = "OnSteamKeyboardCallback")]
		[CalledBy(Type = typeof(TextInputField), Member = "ConsoleKeyboardCallback")]
		[CalledBy(Type = typeof(TextInputField), Member = "UpdateInputString")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[Calls(Type = typeof(UIInput), Member = "Validate")]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
		[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
		[Calls(Type = typeof(UIInput), Member = "ExecuteOnChange")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public bool selected
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIInput), Member = "set_isSelected")]
		set
		{
		}
	}

	public bool isSelected
	{
		[CalledBy(Type = typeof(ChatInput), Member = "OnSubmit")]
		[CalledBy(Type = typeof(UIInput), Member = "set_value")]
		[CalledBy(Type = typeof(UIInput), Member = "get_selected")]
		[CalledBy(Type = typeof(UIInput), Member = "set_isSelected")]
		[CalledBy(Type = typeof(UIInput), Member = "get_cursorPosition")]
		[CalledBy(Type = typeof(UIInput), Member = "set_cursorPosition")]
		[CalledBy(Type = typeof(UIInput), Member = "get_selectionStart")]
		[CalledBy(Type = typeof(UIInput), Member = "set_selectionStart")]
		[CalledBy(Type = typeof(UIInput), Member = "get_selectionEnd")]
		[CalledBy(Type = typeof(UIInput), Member = "set_selectionEnd")]
		[CalledBy(Type = typeof(UIInput), Member = "Update")]
		[CalledBy(Type = typeof(UIInput), Member = "OnPress")]
		[CalledBy(Type = typeof(UIInput), Member = "OnDrag")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "RemoveFocus")]
		[CalledBy(Type = typeof(TextInputField), Member = "Update")]
		[CalledBy(Type = typeof(TextInputField), Member = "GetCursorLocation")]
		[CalledBy(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
		[CalledBy(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
		[CallerCount(Count = 26)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
		[CalledBy(Type = typeof(UIInput), Member = "set_selected")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public int cursorPosition
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
		set
		{
		}
	}

	public int selectionStart
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
		set
		{
		}
	}

	public int selectionEnd
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
		set
		{
		}
	}

	public UITexture caret
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(UIInput), Member = "set_value")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(UIInput), Member = "Validate")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "ToString")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public string Validate(string val)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(ChatInput), Member = "OnSubmit")]
	[CalledBy(Type = typeof(UIInput), Member = "get_defaultText")]
	[CalledBy(Type = typeof(UIInput), Member = "set_defaultText")]
	[CalledBy(Type = typeof(UIInput), Member = "get_text")]
	[CalledBy(Type = typeof(UIInput), Member = "get_value")]
	[CalledBy(Type = typeof(UIInput), Member = "set_value")]
	[CalledBy(Type = typeof(UIInput), Member = "get_cursorPosition")]
	[CalledBy(Type = typeof(UIInput), Member = "get_selectionStart")]
	[CalledBy(Type = typeof(UIInput), Member = "get_selectionEnd")]
	[CalledBy(Type = typeof(UIInput), Member = "OnSelectEvent")]
	[CalledBy(Type = typeof(UIInput), Member = "OnDeselectEvent")]
	[CalledBy(Type = typeof(UIInput), Member = "Update")]
	[CalledBy(Type = typeof(UIInput), Member = "Submit")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CalledBy(Type = typeof(TextInputField), Member = "Update")]
	[CalledBy(Type = typeof(TextInputField), Member = "GetText")]
	[CalledBy(Type = typeof(TextInputField), Member = "GetCursorLocation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected void Init()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void SaveToPlayerPrefs(string val)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UIInput), Member = "OnDeselectEvent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(UIInput), Member = "OnSelectEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void OnSelect(bool isSelected)
	{
	}

	[CalledBy(Type = typeof(UIInput), Member = "OnSelect")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void OnSelectEvent()
	{
	}

	[CalledBy(Type = typeof(UIInput), Member = "OnSelect")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIInput), Member = "RestoreLabelPivot")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected void OnDeselectEvent()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Input), Member = "set_imeCompositionMode")]
	[Calls(Type = typeof(Input), Member = "set_compositionCursorPos")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Input), Member = "get_inputString")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UIInput), Member = "ExecuteOnChange")]
	[Calls(Type = typeof(UIInput), Member = "Submit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 15)]
	protected virtual void Update()
	{
	}

	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[CalledBy(Type = typeof(UIInput), Member = "Insert")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void DoBackspace()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(TextEditor), Member = ".ctor")]
	[Calls(Type = typeof(TextEditor), Member = "Paste")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(NGUITools), Member = "set_clipboard")]
	[Calls(Type = typeof(UIInput), Member = "DoBackspace")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	public virtual bool ProcessEvent(Event ev)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UIInput), Member = "Validate")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UIInput), Member = "DoBackspace")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIInput), Member = "ExecuteOnChange")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Insert(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring")]
	protected string GetLeftText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring")]
	protected string GetRightText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring")]
	protected string GetSelection()
	{
		return null;
	}

	[CalledBy(Type = typeof(UIInput), Member = "OnPress")]
	[CalledBy(Type = typeof(UIInput), Member = "OnDrag")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UICamera), Member = "get_currentRay")]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected int GetCharUnderMouse()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "GetCharUnderMouse")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void OnPress(bool isPressed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIInput), Member = "GetCharUnderMouse")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void OnDrag(Vector2 delta)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void Cleanup()
	{
	}

	[CalledBy(Type = typeof(UIInput), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Submit()
	{
	}

	[CalledBy(Type = typeof(UIInput), Member = "set_defaultText")]
	[CalledBy(Type = typeof(UIInput), Member = "set_value")]
	[CalledBy(Type = typeof(UIInput), Member = "set_cursorPosition")]
	[CalledBy(Type = typeof(UIInput), Member = "set_selectionStart")]
	[CalledBy(Type = typeof(UIInput), Member = "set_selectionEnd")]
	[CalledBy(Type = typeof(UIInput), Member = "Init")]
	[CalledBy(Type = typeof(UIInput), Member = "OnDeselectEvent")]
	[CalledBy(Type = typeof(UIInput), Member = "Update")]
	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[CalledBy(Type = typeof(UIInput), Member = "Insert")]
	[CalledBy(Type = typeof(UIInput), Member = "OnPress")]
	[CalledBy(Type = typeof(UIInput), Member = "OnDrag")]
	[CalledBy(Type = typeof(TextInputField), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIFont), Member = "get_bmFont")]
	[Calls(Type = typeof(BMFont), Member = "GetGlyph")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(UILabel), Member = "CalculateOffsetToFit")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivot")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UIInput), Member = "SetPivotToLeft")]
	[Calls(Type = typeof(UIInput), Member = "RestoreLabelPivot")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(NGUITools), Member = "AddWidget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "SetAnchor")]
	[Calls(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 8)]
	public void UpdateLabel()
	{
	}

	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivot")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[CallsUnknownMethods(Count = 1)]
	protected void SetPivotToLeft()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivot")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[CallsUnknownMethods(Count = 1)]
	protected void SetPivotToRight()
	{
	}

	[CalledBy(Type = typeof(UIInput), Member = "OnDeselectEvent")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[CallsUnknownMethods(Count = 1)]
	protected void RestoreLabelPivot()
	{
	}

	[CalledBy(Type = typeof(UIInput), Member = "Validate")]
	[CalledBy(Type = typeof(UIInput), Member = "Insert")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected char Validate(string text, int pos, char ch)
	{
		return '\0';
	}

	[CalledBy(Type = typeof(UIInput), Member = "set_value")]
	[CalledBy(Type = typeof(UIInput), Member = "Update")]
	[CalledBy(Type = typeof(UIInput), Member = "Insert")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	protected void ExecuteOnChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	public void RemoveFocus()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SaveValue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void LoadValue()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public UIInput()
	{
	}
}
