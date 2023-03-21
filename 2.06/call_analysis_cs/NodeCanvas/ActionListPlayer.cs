using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
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
		[CallerCount(Count = 18)]
		get
		{
			return null;
		}
	}

	private Component NodeCanvas_002EFramework_002EITaskSystem_002Eagent
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 781)]
		get
		{
			return null;
		}
	}

	public IBlackboard blackboard
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 56)]
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
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
		get
		{
			return default(float);
		}
	}

	private UnityEngine.Object NodeCanvas_002EFramework_002EITaskSystem_002EcontextObject
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 781)]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Task), Member = "Create")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public static ActionListPlayer Create()
	{
		return null;
	}

	[CalledBy(Type = typeof(ActionListPlayer), Member = "Awake")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "set_blackboard")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Task), Member = "SetOwnerSystem")]
	[Calls(Type = typeof(Task), Member = "SetOwnerSystem")]
	[CallerCount(Count = 2)]
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

	[Calls(Type = typeof(ActionListPlayer), Member = "SendTaskOwnerDefaults")]
	[Calls(Type = typeof(ActionListPlayer), Member = "Play")]
	[CallerCount(Count = 0)]
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
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "Play")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "Play")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ActionTask), Member = "ActionUpdater")]
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

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ActionListPlayer()
	{
	}
}
