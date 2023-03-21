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
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[CalledBy(Type = typeof(UILocalize), Member = "set_value")]
		[CalledBy(Type = typeof(TextInputField), Member = "SetText")]
		[CalledBy(Type = typeof(TextInputField), Member = "Select")]
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
			return default(bool);
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
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ChatInput), Member = "OnSubmit")]
		[CalledBy(Type = typeof(UIInput), Member = "Start")]
		[CalledBy(Type = typeof(UIInput), Member = "Start")]
		[CalledBy(Type = typeof(UIInput), Member = "LoadValue")]
		[Calls(Type = typeof(UIInput), Member = "ExecuteOnChange")]
		[CalledBy(Type = typeof(UIInput), Member = "set_text")]
		[CalledBy(Type = typeof(TextInputField), Member = "Update")]
		[CalledBy(Type = typeof(TextInputField), Member = "Update")]
		[CalledBy(Type = typeof(TextInputField), Member = "Update")]
		[CalledBy(Type = typeof(TextInputField), Member = "SetText")]
		[CalledBy(Type = typeof(TextInputField), Member = "OnSteamKeyboardCallback")]
		[CalledBy(Type = typeof(TextInputField), Member = "ConsoleKeyboardCallback")]
		[CalledBy(Type = typeof(TextInputField), Member = "Update")]
		[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[CalledBy(Type = typeof(TextInputField), Member = "UpdateInputString")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(UIInput), Member = "Validate")]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
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
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIInput), Member = "set_isSelected")]
		set
		{
		}
	}

	public bool isSelected
	{
		[CallerCount(Count = 26)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
		[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
		[CalledBy(Type = typeof(UIInput), Member = "set_selected")]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		set
		{
		}
	}

	public int cursorPosition
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public int selectionStart
	{
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
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
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "ToString")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CalledBy(Type = typeof(UIInput), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIInput), Member = "Validate")]
	public string Validate(string val)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	private void Start()
	{
	}

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsUnknownMethods(Count = 2)]
	protected void Init()
	{
	}

	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected void SaveToPlayerPrefs(string val)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UIInput), Member = "OnDeselectEvent")]
	[Calls(Type = typeof(UIInput), Member = "OnSelectEvent")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected virtual void OnSelect(bool isSelected)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CalledBy(Type = typeof(UIInput), Member = "OnSelect")]
	[CallsUnknownMethods(Count = 1)]
	protected void OnSelectEvent()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIInput), Member = "OnSelect")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIInput), Member = "RestoreLabelPivot")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnDeselectEvent()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Input), Member = "set_imeCompositionMode")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[Calls(Type = typeof(Input), Member = "set_compositionCursorPos")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Input), Member = "get_inputString")]
	[Calls(Type = typeof(Input), Member = "get_inputString")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "Submit")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "ExecuteOnChange")]
	protected virtual void Update()
	{
	}

	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	protected void DoBackspace()
	{
	}

	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(TextEditor), Member = ".ctor")]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(TextEditor), Member = "Paste")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(NGUITools), Member = "set_clipboard")]
	[Calls(Type = typeof(NGUITools), Member = "set_clipboard")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UIInput), Member = "DoBackspace")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	public virtual bool ProcessEvent(Event ev)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	protected virtual void Insert(string text)
	{
	}

	[Calls(Type = typeof(string), Member = "Substring")]
	[CallerCount(Count = 0)]
	protected string GetLeftText()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Substring")]
	[CallerCount(Count = 0)]
	protected string GetRightText()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Substring")]
	[CallerCount(Count = 0)]
	protected string GetSelection()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CalledBy(Type = typeof(UIInput), Member = "OnPress")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UICamera), Member = "get_currentRay")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIInput), Member = "OnDrag")]
	protected int GetCharUnderMouse()
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIInput), Member = "GetCharUnderMouse")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	protected virtual void OnPress(bool isPressed)
	{
	}

	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIInput), Member = "GetCharUnderMouse")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	protected virtual void OnDrag(Vector2 delta)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "Destroy")]
	protected virtual void Cleanup()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CalledBy(Type = typeof(UIInput), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Submit()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(UIInput), Member = "RestoreLabelPivot")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(UIInput), Member = "RestoreLabelPivot")]
	[Calls(Type = typeof(UIInput), Member = "SetPivotToLeft")]
	[Calls(Type = typeof(UIInput), Member = "SetPivotToLeft")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "SetAnchor")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UILabel), Member = "PrintOverlay")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivot")]
	[Calls(Type = typeof(UILabel), Member = "PrintOverlay")]
	[Calls(Type = typeof(UIRect), Member = "SetAnchor")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(UILabel), Member = "CalculateOffsetToFit")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIFont), Member = "get_bmFont")]
	[Calls(Type = typeof(BMFont), Member = "GetGlyph")]
	[Calls(Type = typeof(UIFont), Member = "get_bmFont")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "CalculateOffsetToFit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void UpdateLabel()
	{
	}

	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivot")]
	[CallerCount(Count = 2)]
	protected void SetPivotToLeft()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivot")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	protected void SetPivotToRight()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[CalledBy(Type = typeof(UIInput), Member = "OnDeselectEvent")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	protected void RestoreLabelPivot()
	{
	}

	[CalledBy(Type = typeof(UIInput), Member = "Validate")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	protected char Validate(string text, int pos, char ch)
	{
		return default(char);
	}

	[CalledBy(Type = typeof(UIInput), Member = "Update")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIInput), Member = "set_value")]
	protected void ExecuteOnChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	public void RemoveFocus()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SaveValue()
	{
	}

	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void LoadValue()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public UIInput()
	{
	}
}
