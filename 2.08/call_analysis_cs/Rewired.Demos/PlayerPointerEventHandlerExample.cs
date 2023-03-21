using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using Rewired.Integration.UnityUI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.Demos;

public sealed class PlayerPointerEventHandlerExample : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler, IPointerClickHandler, IScrollHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public Text text;

	private const int logLength = 10;

	private List<string> log;

	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerEnter")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerExit")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerUp")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerDown")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerClick")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnScroll")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnBeginDrag")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnDrag")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnEndDrag")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Log(string o)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 28)]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 28)]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 37)]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 37)]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 37)]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 28)]
	public void OnScroll(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 37)]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 37)]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 37)]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	private static string GetSourceName(PlayerPointerEventData playerEventData)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public PlayerPointerEventHandlerExample()
	{
	}
}
