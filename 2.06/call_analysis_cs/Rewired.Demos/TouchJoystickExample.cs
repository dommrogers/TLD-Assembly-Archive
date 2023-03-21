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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TouchJoystickExample), Member = "StoreOrigValues")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TouchJoystickExample), Member = "Restart")]
	[Calls(Type = typeof(TouchJoystickExample), Member = "StoreOrigValues")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Update()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(TouchJoystickExample), Member = "Update")]
	[CalledBy(Type = typeof(TouchJoystickExample), Member = "UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp")]
	[CallsUnknownMethods(Count = 3)]
	private void Restart()
	{
	}

	[CalledBy(Type = typeof(TouchJoystickExample), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(TouchJoystickExample), Member = "Start")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchJoystickExample), Member = "Restart")]
	private void UnityEngine_002EEventSystems_002EIPointerUpHandler_002EOnPointerUp(PointerEventData eventData)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private void UnityEngine_002EEventSystems_002EIDragHandler_002EOnDrag(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static bool IsMousePointerId(int id)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public TouchJoystickExample()
	{
	}
}
