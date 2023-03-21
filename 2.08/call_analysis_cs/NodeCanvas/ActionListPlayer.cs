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
		[CallerCount(Count = 16)]
		get
		{
			return null;
		}
	}

	private Component NodeCanvas_002EFramework_002EITaskSystem_002Eagent
	{
		[CallerCount(Count = 797)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public IBlackboard blackboard
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 53)]
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
			return default(float);
		}
	}

	private UnityEngine.Object NodeCanvas_002EFramework_002EITaskSystem_002EcontextObject
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 797)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Task), Member = "Create")]
	[CallsUnknownMethods(Count = 2)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static ActionListPlayer Create()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Task), Member = "SetOwnerSystem")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "Internal_Log")]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "set_blackboard")]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "Awake")]
	public void SendTaskOwnerDefaults()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(ActionListPlayer), Member = "Play")]
	[CallerCount(Count = 0)]
	public void Play(Action<bool> OnFinish)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(ActionTask), Member = "ActionUpdater")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "Awake")]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "Play")]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "Play")]
	public void Play(Component agent, IBlackboard blackboard, Action<bool> OnFinish)
	{
	}

	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	[CallerCount(Count = 0)]
	public ActionListPlayer()
	{
	}
}
