using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UITextList : MonoBehaviour
{
	public enum Style
	{
		Text,
		Chat
	}

	protected class Paragraph
	{
		public string text;

		public string[] lines;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public Paragraph()
		{
		}
	}

	public UILabel textLabel;

	public UIProgressBar scrollBar;

	public Style style;

	public int paragraphHistory;

	protected char[] mSeparator;

	protected BetterList<Paragraph> mParagraphs;

	protected float mScroll;

	protected int mTotalLines;

	protected int mLastWidth;

	protected int mLastHeight;

	public bool isValid
	{
		[CalledBy(Type = typeof(UITextList), Member = "get_scrollHeight")]
		[CalledBy(Type = typeof(UITextList), Member = "Update")]
		[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
		[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
		[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
		[CalledBy(Type = typeof(UITextList), Member = "UpdateVisibleText")]
		[Calls(Type = typeof(UILabel), Member = "get_ambigiousFont")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UITextList), Member = "set_scrollValue")]
		[CallerCount(Count = 7)]
		get
		{
			return default(bool);
		}
	}

	public float scrollValue
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[CalledBy(Type = typeof(UITextList), Member = "OnDrag")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UITextList), Member = "OnScroll")]
		[CalledBy(Type = typeof(UITextList), Member = "Start")]
		[Calls(Type = typeof(UITextList), Member = "UpdateVisibleText")]
		[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UITextList), Member = "get_isValid")]
		set
		{
		}
	}

	protected float lineHeight
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
		[CalledBy(Type = typeof(UITextList), Member = "get_scrollHeight")]
		[CalledBy(Type = typeof(UITextList), Member = "OnScroll")]
		[CalledBy(Type = typeof(UITextList), Member = "OnDrag")]
		[CalledBy(Type = typeof(UITextList), Member = "UpdateVisibleText")]
		[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
		get
		{
			return default(float);
		}
	}

	protected int scrollHeight
	{
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UITextList), Member = "get_isValid")]
		[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
		[CalledBy(Type = typeof(UITextList), Member = "OnScroll")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UITextList), Member = "OnDrag")]
		get
		{
			return default(int);
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UITextList), Member = "UpdateVisibleText")]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UITextList), Member = "set_scrollValue")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextList), Member = "get_isValid")]
	[Calls(Type = typeof(UITextList), Member = "Rebuild")]
	private void Update()
	{
	}

	[Calls(Type = typeof(UITextList), Member = "set_scrollValue")]
	[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
	[Calls(Type = typeof(UITextList), Member = "get_scrollHeight")]
	[CallerCount(Count = 0)]
	public void OnScroll(float val)
	{
	}

	[Calls(Type = typeof(UITextList), Member = "set_scrollValue")]
	[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
	[Calls(Type = typeof(UITextList), Member = "get_scrollHeight")]
	[CallerCount(Count = 0)]
	public void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextList), Member = "UpdateVisibleText")]
	[CallsUnknownMethods(Count = 2)]
	private void OnScrollBar()
	{
	}

	[CalledBy(Type = typeof(ChatInput), Member = "Start")]
	[CalledBy(Type = typeof(ChatInput), Member = "OnSubmit")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UITextList), Member = "Rebuild")]
	[CallerCount(Count = 2)]
	public void Add(string text)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected void Add(string text, bool updateVisible)
	{
	}

	[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
	[Calls(Type = typeof(UITextList), Member = "get_isValid")]
	[Calls(Type = typeof(UIScrollBar), Member = "set_barSize")]
	[CalledBy(Type = typeof(UITextList), Member = "Add")]
	[CalledBy(Type = typeof(UITextList), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
	[Calls(Type = typeof(UITextList), Member = "get_isValid")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UITextList), Member = "get_isValid")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	protected void Rebuild()
	{
	}

	[CalledBy(Type = typeof(UITextList), Member = "Clear")]
	[CalledBy(Type = typeof(UITextList), Member = "set_scrollValue")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
	[Calls(Type = typeof(UITextList), Member = "get_isValid")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UITextList), Member = "OnScrollBar")]
	[CallerCount(Count = 3)]
	protected void UpdateVisibleText()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public UITextList()
	{
	}
}
