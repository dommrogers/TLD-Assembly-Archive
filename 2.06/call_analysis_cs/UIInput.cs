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
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[CallerCount(Count = 0)]
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
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return default(bool);
		}
	}

	public string text
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UIInput), Member = "set_value")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string value
	{
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ChatInput), Member = "OnSubmit")]
		[CalledBy(Type = typeof(UIInput), Member = "set_text")]
		[CalledBy(Type = typeof(UIInput), Member = "Start")]
		[CalledBy(Type = typeof(UIInput), Member = "Start")]
		[CalledBy(Type = typeof(UIInput), Member = "LoadValue")]
		[CalledBy(Type = typeof(TextInputField), Member = "Update")]
		[CalledBy(Type = typeof(TextInputField), Member = "Update")]
		[CalledBy(Type = typeof(TextInputField), Member = "Update")]
		[CalledBy(Type = typeof(TextInputField), Member = "SetText")]
		[CalledBy(Type = typeof(TextInputField), Member = "UpdateInputString")]
		[Calls(Type = typeof(UIInput), Member = "ExecuteOnChange")]
		[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
		[Calls(Type = typeof(UIInput), Member = "SaveToPlayerPrefs")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(UIInput), Member = "Validate")]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		set
		{
		}
	}

	public bool selected
	{
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[Calls(Type = typeof(UIInput), Member = "set_isSelected")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool isSelected
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 26)]
		get
		{
			return default(bool);
		}
		[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIInput), Member = "set_selected")]
		[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
		set
		{
		}
	}

	public int cursorPosition
	{
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[DeduplicatedMethod]
		[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
		set
		{
		}
	}

	public int selectionStart
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
		set
		{
		}
	}

	public int selectionEnd
	{
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		get
		{
			return default(int);
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

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(StringBuilder), Member = "ToString")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UIInput), Member = "Validate")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(UIInput), Member = "set_value")]
	[CallsUnknownMethods(Count = 6)]
	public string Validate(string val)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	protected void Init()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UIInput), Member = "SaveValue")]
	[CalledBy(Type = typeof(UIInput), Member = "Submit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CalledBy(Type = typeof(UIInput), Member = "set_value")]
	protected void SaveToPlayerPrefs(string val)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIInput), Member = "OnDeselectEvent")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	protected virtual void OnSelect(bool isSelected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnSelectEvent()
	{
	}

	[CalledBy(Type = typeof(UIInput), Member = "OnSelect")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIInput), Member = "RestoreLabelPivot")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnDeselectEvent()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Input), Member = "set_imeCompositionMode")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Input), Member = "get_inputString")]
	[Calls(Type = typeof(Input), Member = "get_inputString")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIInput), Member = "ExecuteOnChange")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIInput), Member = "Submit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	protected virtual void Update()
	{
	}

	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void DoBackspace()
	{
	}

	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(TextEditor), Member = ".ctor")]
	[Calls(Type = typeof(UIInput), Member = "GetSelection")]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UIInput), Member = "DoBackspace")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(NGUITools), Member = "set_clipboard")]
	[Calls(Type = typeof(TextEditor), Member = "Paste")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(NGUITools), Member = "set_clipboard")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UIInput), Member = "GetSelection")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(Event), Member = "Use")]
	public virtual bool ProcessEvent(Event ev)
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected virtual void Insert(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 1)]
	protected string GetLeftText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	protected string GetRightText()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[CallerCount(Count = 2)]
	protected string GetSelection()
	{
		return null;
	}

	[CalledBy(Type = typeof(UIInput), Member = "OnPress")]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[Calls(Type = typeof(UICamera), Member = "get_currentRay")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(UIInput), Member = "OnDrag")]
	[CallsUnknownMethods(Count = 3)]
	protected int GetCharUnderMouse()
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIInput), Member = "GetCharUnderMouse")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	protected virtual void OnPress(bool isPressed)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIInput), Member = "GetCharUnderMouse")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected virtual void OnDrag(Vector2 delta)
	{
	}

	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "Destroy")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected virtual void Cleanup()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CalledBy(Type = typeof(UIInput), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIInput), Member = "SaveToPlayerPrefs")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	public void Submit()
	{
	}

	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(UIInput), Member = "SetPivotToLeft")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[Calls(Type = typeof(UIInput), Member = "RestoreLabelPivot")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(UIInput), Member = "RestoreLabelPivot")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UIFont), Member = "get_bmFont")]
	[Calls(Type = typeof(UIRect), Member = "SetAnchor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UIInput), Member = "SetPivotToLeft")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "SetAnchor")]
	[Calls(Type = typeof(UILabel), Member = "PrintOverlay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[CallerCount(Count = 22)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivot")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIFont), Member = "get_bmFont")]
	[Calls(Type = typeof(BMFont), Member = "GetGlyph")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "CalculateOffsetToFit")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(UILabel), Member = "CalculateOffsetToFit")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	public void UpdateLabel()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivot")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[CallerCount(Count = 2)]
	protected void SetPivotToLeft()
	{
	}

	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivot")]
	protected void SetPivotToRight()
	{
	}

	[CalledBy(Type = typeof(UIInput), Member = "OnDeselectEvent")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	protected void RestoreLabelPivot()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CalledBy(Type = typeof(UIInput), Member = "Validate")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	protected char Validate(string text, int pos, char ch)
	{
		return default(char);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(UIInput), Member = "Update")]
	[CalledBy(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[CallerCount(Count = 2)]
	protected void ExecuteOnChange()
	{
	}

	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[CallerCount(Count = 0)]
	public void RemoveFocus()
	{
	}

	[Calls(Type = typeof(UIInput), Member = "SaveToPlayerPrefs")]
	[CallerCount(Count = 0)]
	public void SaveValue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void LoadValue()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 0)]
	public UIInput()
	{
	}
}
