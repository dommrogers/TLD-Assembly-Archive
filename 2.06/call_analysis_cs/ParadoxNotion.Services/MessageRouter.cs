using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ParadoxNotion.Services;

public class MessageRouter : MonoBehaviour, IPointerDownHandler, IPointerExitHandler, IDragHandler, IPointerEnterHandler, IEventSystemHandler, IPointerClickHandler, IMoveHandler, IScrollHandler, IPointerUpHandler, ISubmitHandler, IUpdateSelectedHandler, IDeselectHandler, ISelectHandler
{
	public class MessageData
	{
		private GameObject _003Creceiver_003Ek__BackingField;

		private object _003Csender_003Ek__BackingField;

		public GameObject receiver
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 98)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 265)]
			private set
			{
			}
		}

		public object sender
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
			[CallerCount(Count = 85)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 224)]
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
			[CallerCount(Count = 1)]
			get
			{
				return (T)null;
			}
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set
			{
			}
		}

		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(MessageRouter), Member = "OnAnimatorMove")]
		[CalledBy(Type = typeof(MessageRouter), Member = "OnAnimatorMove")]
		[CallsUnknownMethods(Count = 6)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(MessageRouter), Member = "get_animator")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "get_animator")]
	private void OnAnimatorMove()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnCollisionExit(Collision collisionInfo)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnCollisionStay(Collision collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnTriggerStay(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Task), Member = "RegisterEvents")]
	[CalledBy(Type = typeof(Node), Member = "RegisterEvents")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	public void Register(object target, string[] messages)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Internal_RegisterCallback")]
	public void RegisterCallback(string message, Action callback)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(MessageRouter), Member = "Internal_RegisterCallback")]
	public void RegisterCallback<T>(string message, Action<T> callback)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(MessageRouter), Member = "RegisterCallback")]
	[CalledBy(Type = typeof(MessageRouter), Member = "RegisterCallback")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void Internal_RegisterCallback(string message, Delegate callback)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(Node), Member = "UnregisterAllEvents")]
	[CalledBy(Type = typeof(Node), Member = "UnregisterAllEvents")]
	[CalledBy(Type = typeof(Task), Member = "UnRegisterAllEvents")]
	[CallsUnknownMethods(Count = 16)]
	public void UnRegister(object target)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Task), Member = "UnRegisterEvents")]
	[CalledBy(Type = typeof(Task), Member = "UnRegisterEvent")]
	[CalledBy(Type = typeof(Node), Member = "UnRegisterEvents")]
	[CalledBy(Type = typeof(Node), Member = "UnRegisterEvents")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 4)]
	public void UnRegister(object target, string[] messages)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool Dispatch(string message, object sender = null)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
	public bool Dispatch<T>(string message, T arg, object sender = null)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public MessageRouter()
	{
	}
}
