using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Serialization;
using ParadoxNotion.Services;
using UnityEngine;

namespace NodeCanvas;

public class ActionListPlayer : MonoBehaviour, ITaskSystem, ISerializationCallbackReceiver
{
	public bool playOnAwake;

	private string _serializedList;

	private List<UnityEngine.Object> _objectReferences;

	private Blackboard _blackboard;

	[NonSerialized]
	private ActionList _actionList;

	public ActionList actionList
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
		get
		{
			return null;
		}
	}

	private Component NodeCanvas_002EFramework_002EITaskSystem_002Eagent
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 827)]
		get
		{
			return null;
		}
	}

	public IBlackboard blackboard
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 60)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ActionListPlayer), Member = "SendTaskOwnerDefaults")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public float elapsedTime
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	private UnityEngine.Object NodeCanvas_002EFramework_002EITaskSystem_002EcontextObject
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 827)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JSONSerializer), Member = "Deserialize")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Task), Member = "Create")]
	[CallsUnknownMethods(Count = 2)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsUnknownMethods(Count = 6)]
	public static ActionListPlayer Create()
	{
		return null;
	}

	[CalledBy(Type = typeof(ActionListPlayer), Member = "set_blackboard")]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "Awake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Task), Member = "SetOwnerSystem")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 5)]
	public void SendTaskOwnerDefaults()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	private void NodeCanvas_002EFramework_002EITaskSystem_002ESendEvent(EventData eventData, object sender)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void NodeCanvas_002EFramework_002EITaskSystem_002ERecordUndo(string name)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionListPlayer), Member = "SendTaskOwnerDefaults")]
	[Calls(Type = typeof(ActionListPlayer), Member = "Play")]
	private void Awake()
	{
	}

	[ContextMenu("Play")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionListPlayer), Member = "Play")]
	public void Play()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionListPlayer), Member = "Play")]
	public void Play(Action<bool> OnFinish)
	{
	}

	[CalledBy(Type = typeof(ActionListPlayer), Member = "Awake")]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "Play")]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "Play")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(ActionTask), Member = "ActionUpdater")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Play(Component agent, IBlackboard blackboard, Action<bool> OnFinish)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[CallsUnknownMethods(Count = 1)]
	public Status ExecuteAction()
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[CallsUnknownMethods(Count = 1)]
	public Status ExecuteAction(Component agent)
	{
		return default(Status);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ActionListPlayer()
	{
	}
}
