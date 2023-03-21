using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DragDropContainer : MonoBehaviour
{
	public UISprite m_HoverSprite;

	public float m_HoverScale;

	public float m_HoverFadeTime;

	public EventDelegate m_Action;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void DroppedItem(DragDropItem droppedItem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(DragDropContainer), Member = "SetSpriteScale")]
	[CallsUnknownMethods(Count = 1)]
	protected void OnDragOver(GameObject draggedObject)
	{
	}

	[Calls(Type = typeof(DragDropContainer), Member = "SetSpriteScale")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	protected void OnDragOut(GameObject draggedObject)
	{
	}

	[CalledBy(Type = typeof(DragDropContainer), Member = "OnDragOut")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CalledBy(Type = typeof(DragDropContainer), Member = "OnDragOver")]
	[CallsUnknownMethods(Count = 9)]
	protected void SetSpriteScale(float newScale)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DragDropContainer()
	{
	}
}
