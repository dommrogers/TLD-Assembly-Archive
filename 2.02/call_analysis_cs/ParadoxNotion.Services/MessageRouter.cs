using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ParadoxNotion.Services;

public class MessageRouter : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IDragHandler, IPointerUpHandler, IPointerClickHandler, ISelectHandler, IScrollHandler, IUpdateSelectedHandler, IPointerDownHandler, IDeselectHandler, IMoveHandler, ISubmitHandler
{
	public class MessageData
	{
		private GameObject _003Creceiver_003Ek__BackingField;

		private object _003Csender_003Ek__BackingField;

		public GameObject receiver
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 52)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CallerCount(Count = 101)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set
			{
			}
		}

		public object sender
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 71)]
			private set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 83)]
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
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			private set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
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
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(MessageRouter), Member = "OnAnimatorMove")]
		[CalledBy(Type = typeof(MessageRouter), Member = "OnAnimatorMove")]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnDrop(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnScroll(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnUpdateSelected(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnSelect(BaseEventData eventData)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnDeselect(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnMove(AxisEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnSubmit(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnAnimatorIK(int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[Calls(Type = typeof(MessageRouter), Member = "get_animator")]
	[Calls(Type = typeof(MessageRouter), Member = "get_animator")]
	[CallsUnknownMethods(Count = 4)]
	private void OnAnimatorMove()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallerCount(Count = 0)]
	private void OnBecameInvisible()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnBecameVisible()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnCollisionExit(Collision collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnCollisionStay(Collision collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnCollisionEnter2D(Collision2D collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnCollisionExit2D(Collision2D collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnCollisionStay2D(Collision2D collisionInfo)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnTriggerStay(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnTriggerExit2D(Collider2D other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnTriggerStay2D(Collider2D other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallerCount(Count = 0)]
	private void OnMouseDown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnMouseDrag()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnMouseEnter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnMouseExit()
	{
	}

	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnMouseOver()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallerCount(Count = 0)]
	private void OnMouseUp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnParticleCollision(GameObject other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTransformChildrenChanged()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnTransformParentChanged()
	{
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[CalledBy(Type = typeof(Node), Member = "RegisterEvents")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CalledBy(Type = typeof(Task), Member = "RegisterEvents")]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 21)]
	public void Register(object target, string[] messages)
	{
	}

	[Calls(Type = typeof(MessageRouter), Member = "Internal_RegisterCallback")]
	[CallerCount(Count = 0)]
	public void RegisterCallback(string message, Action callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Internal_RegisterCallback")]
	[CallsUnknownMethods(Count = 1)]
	public void RegisterCallback<T>(string message, Action<T> callback)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(MessageRouter), Member = "RegisterCallback")]
	[CalledBy(Type = typeof(MessageRouter), Member = "RegisterCallback")]
	[CallsUnknownMethods(Count = 11)]
	private void Internal_RegisterCallback(string message, Delegate callback)
	{
	}

	[CalledBy(Type = typeof(Task), Member = "UnRegisterAllEvents")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[CalledBy(Type = typeof(Node), Member = "UnregisterAllEvents")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Node), Member = "UnregisterAllEvents")]
	public void UnRegister(object target)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(Node), Member = "UnRegisterEvents")]
	[CalledBy(Type = typeof(Node), Member = "UnRegisterEvents")]
	[CalledBy(Type = typeof(Task), Member = "UnRegisterEvent")]
	[CalledBy(Type = typeof(Task), Member = "UnRegisterEvents")]
	[CallsUnknownMethods(Count = 17)]
	public void UnRegister(object target, string[] messages)
	{
	}

	[CalledBy(Type = typeof(MessageRouter), Member = "OnEnable")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnDisable")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnMouseDown")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnTransformChildrenChanged")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnTransformParentChanged")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnMouseUp")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnDestroy")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnMouseOver")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnBecameVisible")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnMouseEnter")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnMouseDrag")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnBecameInvisible")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnAnimatorMove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnMouseExit")]
	public bool Dispatch(string message, object sender = null)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
	public bool Dispatch<T>(string message, T arg, object sender = null)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public MessageRouter()
	{
	}
}
