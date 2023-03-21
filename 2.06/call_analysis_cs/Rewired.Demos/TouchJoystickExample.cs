using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos;

public class TouchJoystickExample : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
{
	public bool allowMouseControl;

	public int radius;

	private Vector2 origAnchoredPosition;

	private Vector3 origWorldPosition;

	private Vector2 origScreenResolution;

	private ScreenOrientation origScreenOrientation;

	[NonSerialized]
	private bool hasFinger;

	[NonSerialized]
	private int lastFingerId;

	private Vector2 _003Cposition_003Ek__BackingField;

	public Vector2 position
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector2);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchJoystickExample), Member = "StoreOrigValues")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchJoystickExample), Member = "Restart")]
	[Calls(Type = typeof(TouchJoystickExample), Member = "StoreOrigValues")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(TouchJoystickExample), Member = "Update")]
	[CalledBy(Type = typeof(TouchJoystickExample), Member = "UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Restart()
	{
	}

	[CalledBy(Type = typeof(TouchJoystickExample), Member = "Start")]
	[CalledBy(Type = typeof(TouchJoystickExample), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void StoreOrigValues()
	{
	}

	[CallerCount(Count = 0)]
	private void UpdateValue(Vector3 value)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void UnityEngine_002EEventSystems_002EIPointerDownHandler_002EOnPointerDown(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchJoystickExample), Member = "Restart")]
	[CallsUnknownMethods(Count = 1)]
	private void UnityEngine_002EEventSystems_002EIPointerUpHandler_002EOnPointerUp(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UnityEngine_002EEventSystems_002EIDragHandler_002EOnDrag(PointerEventData eventData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static bool IsMousePointerId(int id)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public TouchJoystickExample()
	{
	}
}
