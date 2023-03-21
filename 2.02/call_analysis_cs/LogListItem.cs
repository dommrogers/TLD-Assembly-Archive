using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LogListItem : MonoBehaviour
{
	public UILabel m_Label;

	public UISprite m_BG;

	public UISprite m_LeftLine;

	public UISprite m_RightLine;

	public UISprite m_NoteSprite;

	private bool m_IsDay;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetText(string itemText, bool isDay, bool hasNotes)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetHasNotes(bool hasNotes)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void SetSelected(bool selected)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LogListItem()
	{
	}
}
