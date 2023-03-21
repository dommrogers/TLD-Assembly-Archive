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
			[CallerCount(Count = 59)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 103)]
			private set
			{
			}
		}

		public object sender
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 77)]
			private set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 88)]
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
		[CalledBy(Type = typeof(MessageRouter), Member = "OnAnimatorMove")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnDrop(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnScroll(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnUpdateSelected(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnSelect(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnDeselect(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnMove(AxisEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnSubmit(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAnimatorIK(int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[Calls(Type = typeof(MessageRouter), Member = "get_animator")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void OnAnimatorMove()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnBecameInvisible()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnBecameVisible()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnCollisionExit(Collision collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnCollisionStay(Collision collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnCollisionEnter2D(Collision2D collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnCollisionExit2D(Collision2D collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnCollisionStay2D(Collision2D collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTriggerStay(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTriggerExit2D(Collider2D other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTriggerStay2D(Collider2D other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnMouseDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnMouseDrag()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnMouseEnter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnMouseExit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnMouseOver()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnMouseUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnParticleCollision(GameObject other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTransformChildrenChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTransformParentChanged()
	{
	}

	[CalledBy(Type = typeof(Node), Member = "RegisterEvents")]
	[CalledBy(Type = typeof(Task), Member = "RegisterEvents")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	public void Register(object target, string[] messages)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageRouter), Member = "Internal_RegisterCallback")]
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

	[CalledBy(Type = typeof(MessageRouter), Member = "RegisterCallback")]
	[CalledBy(Type = typeof(MessageRouter), Member = "RegisterCallback")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void Internal_RegisterCallback(string message, Delegate callback)
	{
	}

	[CalledBy(Type = typeof(Node), Member = "UnregisterAllEvents")]
	[CalledBy(Type = typeof(Node), Member = "UnregisterAllEvents")]
	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[CalledBy(Type = typeof(Task), Member = "UnRegisterAllEvents")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >.KeyCollection.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	public void UnRegister(object target)
	{
	}

	[CalledBy(Type = typeof(Node), Member = "UnRegisterEvents")]
	[CalledBy(Type = typeof(Node), Member = "UnRegisterEvents")]
	[CalledBy(Type = typeof(Task), Member = "UnRegisterEvent")]
	[CalledBy(Type = typeof(Task), Member = "UnRegisterEvents")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	public void UnRegister(object target, string[] messages)
	{
	}

	[CalledBy(Type = typeof(MessageRouter), Member = "OnAnimatorMove")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnBecameInvisible")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnBecameVisible")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnMouseDown")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnMouseDrag")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnMouseEnter")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnMouseExit")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnMouseOver")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnMouseUp")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnEnable")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnDisable")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnDestroy")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnTransformChildrenChanged")]
	[CalledBy(Type = typeof(MessageRouter), Member = "OnTransformParentChanged")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool Dispatch(string message, object sender = null)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 28)]
	public bool Dispatch<T>(string message, T arg, object sender = null)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public MessageRouter()
	{
	}
}
