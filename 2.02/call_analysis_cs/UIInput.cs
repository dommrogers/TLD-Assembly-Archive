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
		[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(TextInputField), Member = "Select")]
		[CalledBy(Type = typeof(TextInputField), Member = "SetText")]
		[CalledBy(Type = typeof(UILocalize), Member = "set_value")]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[CallerCount(Count = 3)]
		set
		{
		}
	}

	public bool inputShouldBeHidden
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return default(bool);
		}
	}

	public string text
	{
		[DeduplicatedMethod]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[CallerCount(Count = 0)]
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
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CalledBy(Type = typeof(UIInput), Member = "LoadValue")]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[CalledBy(Type = typeof(UIInput), Member = "Start")]
		[CalledBy(Type = typeof(UIInput), Member = "set_text")]
		[CalledBy(Type = typeof(ChatInput), Member = "OnSubmit")]
		[Calls(Type = typeof(UIInput), Member = "ExecuteOnChange")]
		[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
		[Calls(Type = typeof(UIInput), Member = "SaveToPlayerPrefs")]
		[Calls(Type = typeof(UIInput), Member = "Validate")]
		[CalledBy(Type = typeof(TextInputField), Member = "OnSteamKeyboardCallback")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 11)]
		[CalledBy(Type = typeof(TextInputField), Member = "Update")]
		[CalledBy(Type = typeof(TextInputField), Member = "Update")]
		[CalledBy(Type = typeof(TextInputField), Member = "Update")]
		[CalledBy(Type = typeof(TextInputField), Member = "SetText")]
		[CalledBy(Type = typeof(TextInputField), Member = "ConsoleKeyboardCallback")]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[CalledBy(Type = typeof(TextInputField), Member = "Update")]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		get
		{
			return default(bool);
		}
		[CalledBy(Type = typeof(UIInput), Member = "set_selected")]
		[CalledBy(Type = typeof(ChatInput), Member = "OnSubmit")]
		[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIInput), Member = "RemoveFocus")]
		set
		{
		}
	}

	public int cursorPosition
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		get
		{
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		set
		{
		}
	}

	public int selectionStart
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		[Calls(Type = typeof(UIInput), Member = "Init")]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
		set
		{
		}
	}

	public int selectionEnd
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
		[DeduplicatedMethod]
		[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
		[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
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

	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UIInput), Member = "Validate")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(UIInput), Member = "set_value")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(StringBuilder), Member = "ToString")]
	public string Validate(string val)
	{
		return null;
	}

	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "Replace")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 27)]
	protected void Init()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CalledBy(Type = typeof(UIInput), Member = "set_value")]
	[CalledBy(Type = typeof(UIInput), Member = "Submit")]
	[CalledBy(Type = typeof(UIInput), Member = "SaveValue")]
	protected void SaveToPlayerPrefs(string val)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected virtual void OnSelect(bool isSelected)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	protected void OnSelectEvent()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "RestoreLabelPivot")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	protected void OnDeselectEvent()
	{
	}

	[Calls(Type = typeof(Input), Member = "get_inputString")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Input), Member = "set_imeCompositionMode")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIInput), Member = "ExecuteOnChange")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIInput), Member = "Submit")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Input), Member = "get_inputString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	protected virtual void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIInput), Member = "Insert")]
	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	protected void DoBackspace()
	{
	}

	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(NGUITools), Member = "get_clipboard")]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UIInput), Member = "GetSelection")]
	[Calls(Type = typeof(NGUITools), Member = "set_clipboard")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UIInput), Member = "DoBackspace")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UIInput), Member = "GetSelection")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(NGUITools), Member = "set_clipboard")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[Calls(Type = typeof(Event), Member = "Use")]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(Event), Member = "Use")]
	public virtual bool ProcessEvent(Event ev)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UIInput), Member = "Validate")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UIInput), Member = "Validate")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UIInput), Member = "DoBackspace")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIInput), Member = "ExecuteOnChange")]
	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	protected virtual void Insert(string text)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected string GetLeftText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected string GetRightText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	protected string GetSelection()
	{
		return null;
	}

	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CalledBy(Type = typeof(UIInput), Member = "OnDrag")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UICamera), Member = "get_currentRay")]
	[Calls(Type = typeof(Plane), Member = ".ctor")]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	[Calls(Type = typeof(Ray), Member = "GetPoint")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(UIInput), Member = "OnPress")]
	protected int GetCharUnderMouse()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIInput), Member = "GetCharUnderMouse")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	protected virtual void OnPress(bool isPressed)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIInput), Member = "GetCharUnderMouse")]
	protected virtual void OnDrag(Vector2 delta)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	protected virtual void Cleanup()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIInput), Member = "SaveToPlayerPrefs")]
	[CalledBy(Type = typeof(UIInput), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	public void Submit()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[Calls(Type = typeof(UIInput), Member = "RestoreLabelPivot")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivot")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UIInput), Member = "SetPivotToLeft")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIInput), Member = "SetPivotToLeft")]
	[Calls(Type = typeof(UIInput), Member = "RestoreLabelPivot")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(UIRect), Member = "SetAnchor")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(UIRect), Member = "SetAnchor")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UILabel), Member = "CalculateOffsetToFit")]
	[Calls(Type = typeof(UILabel), Member = "PrintOverlay")]
	[Calls(Type = typeof(UILabel), Member = "CalculateOffsetToFit")]
	[CallsUnknownMethods(Count = 72)]
	[Calls(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CallerCount(Count = 23)]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIFont), Member = "get_bmFont")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UIFont), Member = "get_bmFont")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BMFont), Member = "GetGlyph")]
	[Calls(Type = typeof(string), Member = "Substring")]
	public void UpdateLabel()
	{
	}

	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivot")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	protected void SetPivotToLeft()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivot")]
	[CallsUnknownMethods(Count = 1)]
	protected void SetPivotToRight()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CalledBy(Type = typeof(UIInput), Member = "OnDeselectEvent")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	protected void RestoreLabelPivot()
	{
	}

	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(UIInput), Member = "Validate")]
	[CalledBy(Type = typeof(UIInput), Member = "Insert")]
	[CalledBy(Type = typeof(UIInput), Member = "Insert")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	protected char Validate(string text, int pos, char ch)
	{
		return default(char);
	}

	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[CalledBy(Type = typeof(UIInput), Member = "set_value")]
	[CalledBy(Type = typeof(UIInput), Member = "Update")]
	[CalledBy(Type = typeof(UIInput), Member = "Insert")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	protected void ExecuteOnChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIInput), Member = "set_isSelected")]
	public void RemoveFocus()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIInput), Member = "SaveToPlayerPrefs")]
	public void SaveValue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void LoadValue()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	[CallerCount(Count = 0)]
	public UIInput()
	{
	}
}
