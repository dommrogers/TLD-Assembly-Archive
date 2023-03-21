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
using ParadoxNotion.Serialization;
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
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 53)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 53)]
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
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
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
			return false;
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CAreNodesConnected_003Eb__1(Connection c)
		{
			return false;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass105_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CIsChildOf_003Eb__0(Connection c)
		{
			return false;
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
			return false;
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
		[CallerCount(Count = 65)]
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
			return 0;
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
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		protected set
		{
		}
	}

	public List<Connection> outConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 21)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 21)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		[Calls(TypeFullName = "Interop", Member = "GetRandomBytes")]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 53)]
		set
		{
		}
	}

	public string tag
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 61)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 38)]
		set
		{
		}
	}

	public string comments
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 60)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		set
		{
		}
	}

	public bool isBreakpoint
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual string name
	{
		[CalledBy(Type = typeof(BTComposite), Member = "get_name")]
		[CalledBy(Type = typeof(BinarySelector), Member = "get_name")]
		[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.ActionNode), Member = "get_name")]
		[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.ConditionNode), Member = "get_name")]
		[CalledBy(Type = typeof(NestedFSM), Member = "get_name")]
		[CalledBy(Type = typeof(SubTree), Member = "get_name")]
		[CalledBy(Type = typeof(ConcurrentSuperState), Member = "get_name")]
		[CalledBy(Type = typeof(ConcurrentState), Member = "get_name")]
		[CalledBy(Type = typeof(DTNode), Member = "get_name")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(ReflectionTools), Member = "RTGetAttribute")]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 53)]
		set
		{
		}
	}

	public virtual string description
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReflectionTools), Member = "RTGetAttribute")]
		get
		{
			return null;
		}
	}

	public virtual int priority
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReflectionTools), Member = "RTGetAttribute")]
		get
		{
			return 0;
		}
	}

	public abstract int maxInConnections { get; }

	public abstract int maxOutConnections { get; }

	public abstract Type outConnectionType { get; }

	public abstract bool allowAsPrime { get; }

	public abstract Alignment2x2 commentsAlignment { get; }

	public abstract Alignment2x2 iconAlignment { get; }

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
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public IBlackboard graphBlackboard
	{
		[CallerCount(Count = 41)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
		[CallsDeduplicatedMethods(Count = 1)]
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
			return false;
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
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static Node Create(Graph targetGraph, Type nodeType, Vector2 pos)
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(JSONSerializer), Member = "Clone")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
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

	[CallerCount(Count = 27)]
	[Calls(Type = typeof(Connection), Member = "Reset")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Reset(bool recursively = true)
	{
	}

	[IteratorStateMachine(typeof(_003CYieldBreak_003Ed__85))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator YieldBreak(Action resume)
	{
		return null;
	}

	[CalledBy(Type = typeof(ActionListNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ParlayNPCResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ActionNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ConditionNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Jumper), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleConditionNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	[CalledBy(Type = typeof(GoToNode), Member = "OnExecute")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(MessageRouter), Member = "Register")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterEvents(Component targetAgent, string[] eventNames)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CallsUnknownMethods(Count = 1)]
	public void UnRegisterEvents(string[] eventNames)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CallsUnknownMethods(Count = 1)]
	public void UnRegisterEvents(Component targetAgent, string[] eventNames)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CallsUnknownMethods(Count = 1)]
	public void UnregisterAllEvents()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CallsUnknownMethods(Count = 1)]
	public void UnregisterAllEvents(Component targetAgent)
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "ConnectNodes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsNewConnectionAllowed(Node sourceNode, Node targetNode, Connection refConnection = null)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected virtual bool CanConnectToTarget(Node targetNode)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected virtual bool CanConnectFromSource(Node sourceNode)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public static bool AreNodesConnected(Node a, Node b)
	{
		return false;
	}

	[CalledBy(Type = typeof(Filter), Member = "OnExecute")]
	[CalledBy(Type = typeof(ActionListNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ActionNode), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Select")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Node[] GetParentNodes()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Select")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Node[] GetChildNodes()
	{
		return null;
	}

	[CalledBy(Type = typeof(FSMState), Member = "CanConnectFromSource")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Any")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public bool IsChildOf(Node parentNode)
	{
		return false;
	}

	[CalledBy(Type = typeof(FSMState), Member = "CanConnectToTarget")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Any")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public bool IsParentOf(Node childNode)
	{
		return false;
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnParentDisconnected(int connectionIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnGraphUnpaused()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
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
