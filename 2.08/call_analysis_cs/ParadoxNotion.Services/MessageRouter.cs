using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ParadoxNotion.Services;

public class MessageRouter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler, IDragHandler, IEventSystemHandler, IPointerClickHandler, IDeselectHandler, IScrollHandler, IUpdateSelectedHandler, ISubmitHandler, IPointerDownHandler, ISelectHandler, IMoveHandler
{
	public class MessageData
	{
		private GameObject _003Creceiver_003Ek__BackingField;

		private object _003Csender_003Ek__BackingField;

		public GameObject receiver
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 80)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 279)]
			private set
			{
			}
		}

		public object sender
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 79)]
			private set
			{
			}
		}

		[CallerCount(Count = 263)]
		[DeduplicatedMethod]
		public MessageData(GameObject receiver, object sender)
		{
		}
	}

	public class MessageData<T> : MessageData
	{
		private T _003Cvalue_003Ek__BackingField;

		public T value
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return (T)null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			private set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		public MessageData(T value, GameObject receiver, object sender)
			: base(null, null)
		{
		}
	}

	private const BindingFlags METHOD_FLAGS = (BindingFlags)54;

	private Dictionary<string, List<object>> listeners;

	private object _animator;

	private Animator animator
	{
		[CalledBy(Type = typeof(MessageRouter), Member = "OnAnimatorMove")]
		[CalledBy(Type = typeof(MessageRouter), Member = "OnAnimatorMove")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDrop(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnScroll(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnUpdateSelected(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnSelect(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDeselect(BaseEventData eventData)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnMove(AxisEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnSubmit(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimatorIK(int layerIndex)
	{
	}

	[Calls(Type = typeof(MessageRouter), Member = "get_animator")]
	[Calls(Type = typeof(MessageRouter), Member = "get_animator")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnAnimatorMove()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnBecameInvisible()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnBecameVisible()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnCollisionExit(Collision collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnCollisionStay(Collision collisionInfo)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnCollisionEnter2D(Collision2D collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnCollisionExit2D(Collision2D collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnCollisionStay2D(Collision2D collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerStay(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerExit2D(Collider2D other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerStay2D(Collider2D other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnMouseDown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnMouseDrag()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnMouseEnter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnMouseExit()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnMouseOver()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnMouseUp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnParticleCollision(GameObject other)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnTransformChildrenChanged()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnTransformParentChanged()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Task), Member = "RegisterEvents")]
	[CalledBy(Type = typeof(Node), Member = "RegisterEvents")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	public void Register(object target, string[] messages)
	{
	}

	[Calls(Type = typeof(MessageRouter), Member = "Internal_RegisterCallback")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void RegisterCallback(string message, Action callback)
	{
	}

	[Calls(Type = typeof(MessageRouter), Member = "Internal_RegisterCallback")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void RegisterCallback<T>(string message, Action<T> callback)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(MessageRouter), Member = "RegisterCallback")]
	[CalledBy(Type = typeof(MessageRouter), Member = "RegisterCallback")]
	[CallsUnknownMethods(Count = 2)]
	private void Internal_RegisterCallback(string message, Delegate callback)
	{
	}

	[CalledBy(Type = typeof(Node), Member = "UnregisterAllEvents")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(Node), Member = "UnregisterAllEvents")]
	[CalledBy(Type = typeof(Task), Member = "UnRegisterAllEvents")]
	[CallsUnknownMethods(Count = 15)]
	public void UnRegister(object target)
	{
	}

	[CalledBy(Type = typeof(Node), Member = "UnRegisterEvents")]
	[CalledBy(Type = typeof(Node), Member = "UnRegisterEvents")]
	[CalledBy(Type = typeof(Task), Member = "UnRegisterEvents")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public void UnRegister(object target, string[] messages)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool Dispatch(string message, object sender = null)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	public bool Dispatch<T>(string message, T arg, object sender = null)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public MessageRouter()
	{
	}
}
