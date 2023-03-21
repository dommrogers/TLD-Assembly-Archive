using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
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
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public _003CYieldBreak_003Ed__85(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CAreNodesConnected_003Eb__0(Connection c)
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal Node _003CGetParentNodes_003Eb__103_0(Connection c)
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal Node _003CGetChildNodes_003Eb__104_0(Connection c)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass105_0
	{
		public Node parentNode;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass105_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CIsChildOf_003Eb__0(Connection c)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass106_0
	{
		public Node childNode;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass106_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
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
		[CallerCount(Count = 7)]
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

	public int ID
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 15)]
		get
		{
			return null;
		}
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		protected set
		{
		}
	}

	public List<Connection> outConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 16)]
		protected set
		{
		}
	}

	public Vector2 position
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[Calls(Type = typeof(Guid), Member = "ToString")]
		[Calls(Type = typeof(Interop), Member = "GetRandomBytes")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	private string customName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 51)]
		set
		{
		}
	}

	public string tag
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 58)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 36)]
		set
		{
		}
	}

	public string comments
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 56)]
		get
		{
			return null;
		}
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public bool isBreakpoint
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual string name
	{
		[CalledBy(Type = typeof(DTNode), Member = "get_name")]
		[CalledBy(Type = typeof(ConcurrentState), Member = "get_name")]
		[CalledBy(Type = typeof(ConcurrentSuperState), Member = "get_name")]
		[CalledBy(Type = typeof(SubTree), Member = "get_name")]
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
		[CallerCount(Count = 51)]
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
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	public abstract int maxOutConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	public abstract Type outConnectionType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	public abstract bool allowAsPrime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	public abstract Alignment2x2 commentsAlignment
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	public abstract Alignment2x2 iconAlignment
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	public Status status
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Status);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		protected set
		{
		}
	}

	public Component graphAgent
	{
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public IBlackboard graphBlackboard
	{
		[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 41)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private bool isChecked
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
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

	private bool breakPointReached
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 44)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public Node()
	{
	}

	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static Node Create(Graph targetGraph, Type nodeType, Vector2 pos)
	{
		return null;
	}

	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Connection), Member = "Reset")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Reset(bool recursively = true)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[IteratorStateMachine(typeof(_003CYieldBreak_003Ed__85))]
	private IEnumerator YieldBreak(Action resume)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GoToNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleConditionNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Jumper), Member = "OnExecute")]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ConditionNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ActionNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ActionListNode), Member = "OnExecute")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(ParlayNPCResponseNode), Member = "OnExecute")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	public void Warn(string msg)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetStatus(Status status)
	{
	}

	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected void SendEvent(EventData eventData)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void RegisterEvents(string[] eventNames)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MessageRouter), Member = "Register")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterEvents(Component targetAgent, string[] eventNames)
	{
	}

	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void UnRegisterEvents(string[] eventNames)
	{
	}

	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public void UnRegisterEvents(Component targetAgent, string[] eventNames)
	{
	}

	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	public void UnregisterAllEvents()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CallsUnknownMethods(Count = 1)]
	public void UnregisterAllEvents(Component targetAgent)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Graph), Member = "ConnectNodes")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected virtual bool CanConnectFromSource(Node sourceNode)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 0)]
	public static bool AreNodesConnected(Node a, Node b)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(Filter), Member = "OnExecute")]
	[CalledBy(Type = typeof(ActionListNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ActionNode), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	protected Coroutine StartCoroutine(IEnumerator routine)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	protected void StopCoroutine(Coroutine routine)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public Node[] GetParentNodes()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public Node[] GetChildNodes()
	{
		return null;
	}

	[CalledBy(Type = typeof(FSMState), Member = "CanConnectFromSource")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public bool IsChildOf(Node parentNode)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(FSMState), Member = "CanConnectToTarget")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsParentOf(Node childNode)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual void OnParentDisconnected(int connectionIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnChildConnected(int connectionIndex)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
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

	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public virtual void OnDrawGizmosSelected()
	{
	}
}
