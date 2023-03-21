using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.DialogueTrees;
using NodeCanvas.StateMachines;
using ParadoxNotion;
using ParadoxNotion.Services;
using UnityEngine;

namespace NodeCanvas.Framework;

[Serializable]
public abstract class Node : IGraphElement
{
	private sealed class _003CYieldBreak_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action resume;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(Count = 28)]
			[DeduplicatedMethod]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CYieldBreak_003Ed__85(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass100_0
	{
		public Node b;

		public Node a;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass100_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal bool _003CAreNodesConnected_003Eb__0(Connection c)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CAreNodesConnected_003Eb__1(Connection c)
		{
			return default(bool);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Connection, Node> _003C_003E9__103_0;

		public static Func<Connection, Node> _003C_003E9__104_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 1)]
		internal Node _003CGetParentNodes_003Eb__103_0(Connection c)
		{
			return null;
		}

		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal Node _003CGetChildNodes_003Eb__104_0(Connection c)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass105_0
	{
		public Node parentNode;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass105_0()
		{
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CIsChildOf_003Eb__0(Connection c)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass106_0
	{
		public Node childNode;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass106_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal bool _003CIsParentOf_003Eb__0(Connection c)
		{
			return default(bool);
		}
	}

	private Vector2 _position;

	private string _UID;

	private string _name;

	private string _tag;

	private string _comment;

	private bool _isBreakpoint;

	private Graph _graph;

	private List<Connection> _inConnections;

	private List<Connection> _outConnections;

	private int _ID;

	[NonSerialized]
	private Status _status;

	[NonSerialized]
	private string _nameCache;

	[NonSerialized]
	private string _descriptionCache;

	[NonSerialized]
	private int _priorityCache;

	private bool _003CisChecked_003Ek__BackingField;

	private bool _003CbreakPointReached_003Ek__BackingField;

	public Graph graph
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 60)]
		set
		{
		}
	}

	public int ID
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public List<Connection> inConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 13)]
		protected set
		{
		}
	}

	public List<Connection> outConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		protected set
		{
		}
	}

	public Vector2 position
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Vector2);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string UID
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Interop), Member = "GetRandomBytes")]
		[Calls(Type = typeof(Guid), Member = "ToString")]
		get
		{
			return null;
		}
	}

	private string customName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
		[CallerCount(Count = 55)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public string tag
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 40)]
		set
		{
		}
	}

	public string comments
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 53)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 21)]
		set
		{
		}
	}

	public bool isBreakpoint
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public virtual string name
	{
		[CalledBy(Type = typeof(SubTree), Member = "get_name")]
		[CalledBy(Type = typeof(DTNode), Member = "get_name")]
		[CalledBy(Type = typeof(ConcurrentState), Member = "get_name")]
		[CalledBy(Type = typeof(ConcurrentSuperState), Member = "get_name")]
		[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.ConditionNode), Member = "get_name")]
		[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.ActionNode), Member = "get_name")]
		[CalledBy(Type = typeof(NestedFSM), Member = "get_name")]
		[CalledBy(Type = typeof(BTComposite), Member = "get_name")]
		[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(BinarySelector), Member = "get_name")]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 55)]
		set
		{
		}
	}

	public virtual string description
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public virtual int priority
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public abstract int maxInConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	public abstract int maxOutConnections
	{
		[CallerCount(Count = 101261)]
		[DeduplicatedMethod]
		get;
	}

	public abstract Type outConnectionType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	public abstract bool allowAsPrime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	public abstract Alignment2x2 commentsAlignment
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	public abstract Alignment2x2 iconAlignment
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	public Status status
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Status);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		protected set
		{
		}
	}

	public Component graphAgent
	{
		[CallerCount(Count = 24)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public IBlackboard graphBlackboard
	{
		[CallerCount(Count = 41)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private bool isChecked
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	private bool breakPointReached
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 44)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Node()
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	public static Node Create(Graph targetGraph, Type nodeType, Vector2 pos)
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[CallerCount(Count = 1)]
	public Node Duplicate(Graph targetGraph)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnCreate(Graph assignedGraph)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnValidate(Graph assignedGraph)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Status Execute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(Connection), Member = "Reset")]
	public void Reset(bool recursively = true)
	{
	}

	[IteratorStateMachine(typeof(_003CYieldBreak_003Ed__85))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator YieldBreak(Action resume)
	{
		return null;
	}

	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ConditionNode), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GoToNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleConditionNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Jumper), Member = "OnExecute")]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ConditionNode), Member = "OnExecute")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(ParlayNPCResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ActionListNode), Member = "OnExecute")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ActionNode), Member = "OnExecute")]
	public Status Error(object msg)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	public Status Fail(string msg)
	{
		return default(Status);
	}

	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[CallerCount(Count = 0)]
	public void Warn(string msg)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetStatus(Status status)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 1)]
	protected void SendEvent(EventData eventData)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void RegisterEvents(string[] eventNames)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(MessageRouter), Member = "Register")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void RegisterEvents(Component targetAgent, string[] eventNames)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	public void UnRegisterEvents(string[] eventNames)
	{
	}

	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UnRegisterEvents(Component targetAgent, string[] eventNames)
	{
	}

	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UnregisterAllEvents()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	public void UnregisterAllEvents(Component targetAgent)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[CalledBy(Type = typeof(Graph), Member = "ConnectNodes")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	public static bool IsNewConnectionAllowed(Node sourceNode, Node targetNode, Connection refConnection = null)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected virtual bool CanConnectToTarget(Node targetNode)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected virtual bool CanConnectFromSource(Node sourceNode)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static bool AreNodesConnected(Node a, Node b)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ActionNode), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Filter), Member = "OnExecute")]
	[CalledBy(Type = typeof(ActionListNode), Member = "OnExecute")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[CallerCount(Count = 3)]
	protected Coroutine StartCoroutine(IEnumerator routine)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	protected void StopCoroutine(Coroutine routine)
	{
	}

	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Node[] GetParentNodes()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 7)]
	public Node[] GetChildNodes()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsChildOf(Node parentNode)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsParentOf(Node childNode)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual string GetAdditionalState()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected virtual Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnReset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnParentConnected(int connectionIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnParentDisconnected(int connectionIndex)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual void OnChildConnected(int connectionIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnChildDisconnected(int connectionIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnGraphStarted()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnGraphStoped()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnGraphPaused()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual void OnGraphUnpaused()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CallsDeduplicatedMethods(Count = 3)]
	public override string ToString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public virtual void OnDrawGizmos()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public virtual void OnDrawGizmosSelected()
	{
	}
}
