using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ParadoxNotion.Services;

public class MessageRouter : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IDragHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler
{
	public class MessageData
	{
		private GameObject _003Creceiver_003Ek__BackingField;

		private object _003Csender_003Ek__BackingField;

		public GameObject receiver
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 92)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 283)]
			private set
			{
			}
		}

		public object sender
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 86)]
			private set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 234)]
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
				return default(T);
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
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	public void OnDrop(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	public void OnScroll(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	public void OnUpdateSelected(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	public void OnSelect(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	public void OnDeselect(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	public void OnMove(AxisEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	public void OnSubmit(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnAnimatorIK(int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[Calls(Type = typeof(MessageRouter), Member = "get_animator")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnAnimatorMove()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnBecameInvisible()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnBecameVisible()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnCollisionExit(Collision collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnCollisionStay(Collision collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnCollisionEnter2D(Collision2D collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnCollisionExit2D(Collision2D collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnCollisionStay2D(Collision2D collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnTriggerStay(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnTriggerExit2D(Collider2D other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnTriggerStay2D(Collider2D other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnMouseDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnMouseDrag()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnMouseEnter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnMouseExit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnMouseOver()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnMouseUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnTransformChildrenChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	private void OnTransformParentChanged()
	{
	}

	[CalledBy(Type = typeof(Node), Member = "RegisterEvents")]
	[CalledBy(Type = typeof(Task), Member = "RegisterEvents")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public void Register(object target, string[] messages)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Internal_RegisterCallback")]
	public void RegisterCallback(string message, Action callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Internal_RegisterCallback")]
	public void RegisterCallback<T>(string message, Action<T> callback)
	{
	}

	[CalledBy(Type = typeof(MessageRouter), Member = "RegisterCallback")]
	[CalledBy(Type = typeof(MessageRouter), Member = "RegisterCallback")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void Internal_RegisterCallback(string message, Delegate callback)
	{
	}

	[CalledBy(Type = typeof(Node), Member = "UnregisterAllEvents")]
	[CalledBy(Type = typeof(Node), Member = "UnregisterAllEvents")]
	[CalledBy(Type = typeof(Task), Member = "UnRegisterAllEvents")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public void UnRegister(object target)
	{
	}

	[CalledBy(Type = typeof(Node), Member = "UnRegisterEvents")]
	[CalledBy(Type = typeof(Node), Member = "UnRegisterEvents")]
	[CalledBy(Type = typeof(Task), Member = "UnRegisterEvents")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void UnRegister(object target, string[] messages)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	public bool Dispatch(string message, object sender = null)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 11)]
	public bool Dispatch<T>(string message, T arg, object sender = null)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public MessageRouter()
	{
	}
}
