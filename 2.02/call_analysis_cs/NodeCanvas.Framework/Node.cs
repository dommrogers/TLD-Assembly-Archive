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
	private sealed class _003CYieldBreak_003Ed__85 : IEnumerator, IDisposable, IEnumerator<object>
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action resume;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 29)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		public _003CYieldBreak_003Ed__85(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass100_0
	{
		public Node b;

		public Node a;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass106_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
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
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 14)]
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
		[Calls(Type = typeof(Guid), Member = "NewGuid")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private string customName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CallerCount(Count = 41)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public string tag
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
		set
		{
		}
	}

	public string comments
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
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
		[CalledBy(Type = typeof(NestedFSM), Member = "get_name")]
		[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.ConditionNode), Member = "get_name")]
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(BinarySelector), Member = "get_name")]
		[CalledBy(Type = typeof(BTComposite), Member = "get_name")]
		[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.ActionNode), Member = "get_name")]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	public virtual string description
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public virtual int priority
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public abstract int maxInConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	public abstract int maxOutConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	public abstract Type outConnectionType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	public abstract bool allowAsPrime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	public abstract Alignment2x2 commentsAlignment
	{
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		get;
	}

	public abstract Alignment2x2 iconAlignment
	{
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		protected set
		{
		}
	}

	public Component graphAgent
	{
		[CallerCount(Count = 24)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public IBlackboard graphBlackboard
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
		[CallerCount(Count = 41)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return null;
		}
	}

	private bool isChecked
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	[CallerCount(Count = 44)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public Node()
	{
	}

	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static Node Create(Graph targetGraph, Type nodeType, Vector2 pos)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public Node Duplicate(Graph targetGraph)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnCreate(Graph assignedGraph)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnValidate(Graph assignedGraph)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void OnDestroy()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Status Execute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Connection), Member = "Reset")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	public void Reset(bool recursively = true)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	private IEnumerator YieldBreak(Action resume)
	{
		return null;
	}

	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ActionNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(GoToNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleConditionNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Jumper), Member = "OnExecute")]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ConditionNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ParlayRollChance), Member = "OnExecute")]
	[CalledBy(Type = typeof(ActionListNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(ParlayNPCResponseNode), Member = "OnExecute")]
	public Status Error(object msg)
	{
		return default(Status);
	}

	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Status Fail(string msg)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	public void Warn(string msg)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[Calls(Type = typeof(MessageRouter), Member = "Register")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void RegisterEvents(Component targetAgent, string[] eventNames)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CallsUnknownMethods(Count = 2)]
	public void UnRegisterEvents(string[] eventNames)
	{
	}

	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void UnRegisterEvents(Component targetAgent, string[] eventNames)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CallsUnknownMethods(Count = 2)]
	public void UnregisterAllEvents()
	{
	}

	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void UnregisterAllEvents(Component targetAgent)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[CalledBy(Type = typeof(Graph), Member = "ConnectNodes")]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsNewConnectionAllowed(Node sourceNode, Node targetNode, Connection refConnection = null)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 22)]
	public static bool AreNodesConnected(Node a, Node b)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ActionNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ActionListNode), Member = "OnExecute")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Filter), Member = "OnExecute")]
	protected Coroutine StartCoroutine(IEnumerator routine)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	protected void StopCoroutine(Coroutine routine)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public Node[] GetParentNodes()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public Node[] GetChildNodes()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(FSMState), Member = "CanConnectFromSource")]
	[CallsUnknownMethods(Count = 15)]
	public bool IsChildOf(Node parentNode)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(FSMState), Member = "CanConnectToTarget")]
	[CallsUnknownMethods(Count = 15)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected virtual Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected virtual void OnReset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnParentConnected(int connectionIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnParentDisconnected(int connectionIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnChildConnected(int connectionIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnChildDisconnected(int connectionIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnGraphStarted()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnGraphStoped()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void OnGraphPaused()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnGraphUnpaused()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsUnknownMethods(Count = 5)]
	public override string ToString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual void OnDrawGizmos()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public virtual void OnDrawGizmosSelected()
	{
	}
}
