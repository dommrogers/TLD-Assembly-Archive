using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DragDropContainer : MonoBehaviour
{
	public UISprite m_HoverSprite;

	public float m_HoverScale;

	public float m_HoverFadeTime;

	public EventDelegate m_Action;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 1)]
	public void DroppedItem(DragDropItem droppedItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(DragDropContainer), Member = "SetSpriteScale")]
	[CallsUnknownMethods(Count = 1)]
	protected void OnDragOver(GameObject draggedObject)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(DragDropContainer), Member = "SetSpriteScale")]
	[CallsUnknownMethods(Count = 1)]
	protected void OnDragOut(GameObject draggedObject)
	{
	}

	[CalledBy(Type = typeof(DragDropContainer), Member = "OnDragOver")]
	[CalledBy(Type = typeof(DragDropContainer), Member = "OnDragOut")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	protected void SetSpriteScale(float newScale)
	{
	}

	[CallerCount(Count = 0)]
	public DragDropContainer()
	{
	}
}
