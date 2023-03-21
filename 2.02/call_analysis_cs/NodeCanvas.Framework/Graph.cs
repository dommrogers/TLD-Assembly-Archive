using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework.Internal;
using NodeCanvas.StateMachines;
using NodeCanvas.Tasks.Actions;
using ParadoxNotion;
using ParadoxNotion.Serialization;
using ParadoxNotion.Services;
using UnityEngine;

namespace NodeCanvas.Framework;

[Serializable]
public abstract class Graph : ScriptableObject, ITaskSystem, ISerializationCallbackReceiver
{
	private sealed class _003C_003Ec__DisplayClass110_0
	{
		public Graph targetGraph;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass110_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CCloneNodes_003Eb__0(Node n)
		{
			return false;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Node, bool> _003C_003E9__115_0;

		public static Func<Node, int> _003C_003E9__115_1;

		public static Func<Node, bool> _003C_003E9__134_0;

		public static Func<Node, bool> _003C_003E9__135_0;

		public static Func<BBParameter, bool> _003C_003E9__150_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal bool _003CUpdateNodeIDs_003Eb__115_0(Node n)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CUpdateNodeIDs_003Eb__115_1(Node n)
		{
			return 0;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal bool _003CGetRootNodes_003Eb__134_0(Node n)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal bool _003CGetLeafNodes_003Eb__135_0(Node n)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		internal bool _003CGetDefinedParameters_003Eb__150_0(BBParameter p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass129_0
	{
		public int searchID;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass129_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetNodeWithID_003Eb__0(Node n)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass156_0
	{
		public Node node;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass156_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal bool _003CRemoveNode_003Eb__0(Node n)
		{
			return false;
		}
	}

	private string _serializedGraph;

	private List<UnityEngine.Object> _objectReferences;

	private bool _deserializationFailed;

	[NonSerialized]
	private bool hasDeserialized;

	private string _category;

	private string _comments;

	private Vector2 _translation;

	private float _zoomFactor;

	private List<Node> _nodes;

	private List<CanvasGroup> _canvasGroups;

	private BlackboardSource _localBlackboard;

	[NonSerialized]
	private Component _agent;

	[NonSerialized]
	private IBlackboard _blackboard;

	[NonSerialized]
	private static List<Graph> runningGraphs;

	[NonSerialized]
	private float timeStarted;

	[NonSerialized]
	private bool initialReferencesUpdated;

	[NonSerialized]
	private bool _isAutoUpdated;

	[NonSerialized]
	private bool _isRunning;

	[NonSerialized]
	private bool _isPaused;

	[NonSerialized]
	private float deltaTimeAccumulated;

	public abstract Type baseNodeType { get; }

	public abstract bool requiresAgent { get; }

	public abstract bool requiresPrimeNode { get; }

	public abstract bool isTree { get; }

	public abstract bool useLocalBlackboard { get; }

	public abstract bool canAcceptVariableDrops { get; }

	public new string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
		set
		{
		}
	}

	public string category
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 17)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		set
		{
		}
	}

	public string comments
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
		set
		{
		}
	}

	public float elapsedTime
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public float deltaTime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	public bool isRunning
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public bool isPaused
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public bool isAutoUpdated
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public List<Node> allNodes
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
		private set
		{
		}
	}

	public Node primeNode
	{
		[CalledBy(Type = typeof(BehaviourTree), Member = "OnGraphStarted")]
		[CalledBy(Type = typeof(BehaviourTree), Member = "OnGraphUpdate")]
		[CalledBy(Type = typeof(BehaviourTree), Member = "Tick")]
		[CalledBy(Type = typeof(NestedFSM), Member = "OnExecute")]
		[CalledBy(Type = typeof(SubTree), Member = "OnExecute")]
		[CalledBy(Type = typeof(RootSwitcher), Member = "OnExecute")]
		[CalledBy(Type = typeof(Graph), Member = "set_primeNode")]
		[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
		[CalledBy(Type = typeof(Graph), Member = "UpdateNodeIDs")]
		[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
		[CalledBy(Type = typeof(Graph), Member = "GetFullGraphHierarchy")]
		[CalledBy(Type = typeof(Graph), Member = "AddNode")]
		[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
		[CalledBy(Type = typeof(FSM), Member = "OnGraphUnpaused")]
		[CalledBy(Type = typeof(DialogueTree), Member = "OnGraphStarted")]
		[CalledBy(Type = typeof(DialogueTree), Member = "OnGraphUnpaused")]
		[CallerCount(Count = 23)]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(NCUtils), Member = "SetInitialStateByTag")]
		[CalledBy(Type = typeof(RootSwitcher), Member = "OnExecute")]
		[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
		[CalledBy(Type = typeof(Graph), Member = "AddNode")]
		[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Graph), Member = "get_primeNode")]
		[Calls(Type = typeof(List<>), Member = "Contains")]
		[Calls(Type = typeof(Node), Member = "Reset")]
		[Calls(Type = typeof(List<>), Member = "Remove")]
		[Calls(Type = typeof(List<>), Member = "Insert")]
		[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		set
		{
		}
	}

	public List<CanvasGroup> canvasGroups
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 16)]
		set
		{
		}
	}

	public Vector2 translation
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector2);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float zoomFactor
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return 0f;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Component agent
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		private set
		{
		}
	}

	public IBlackboard blackboard
	{
		[CalledBy(Type = typeof(SubDialogueTree), Member = "SetVariablesMapping")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(Graph), Member = "UpdateReferences")]
		[CalledBy(Type = typeof(GraphOwner), Member = "GetInstance")]
		[CalledBy(Type = typeof(State_InvokeGraphBase), Member = "OnEnter")]
		[CalledBy(Type = typeof(NestedFSMState), Member = "CheckInstance")]
		[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_InvokeConcurrentGraph), Member = "OnExecute")]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public BlackboardSource localBlackboard
	{
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(BlackboardSource), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
	}

	private UnityEngine.Object NodeCanvas_002EFramework_002EITaskSystem_002EcontextObject
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2043)]
		get
		{
			return null;
		}
	}

	public static event Action<Graph> onGraphSerialized
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public static event Action<Graph> onGraphDeserialized
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event Action<bool> onFinish
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
		[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Serialize")]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Deserialize")]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Validate")]
	protected void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Validate")]
	protected void Reset()
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Serialize()
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Deserialize")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize()
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "CopySerialized")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GraphSerializationData), Member = ".ctor")]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public string Serialize(bool pretyJson, List<UnityEngine.Object> objectReferences)
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "Deserialize")]
	[CalledBy(Type = typeof(Graph), Member = "CopySerialized")]
	[CalledBy(Type = typeof(GraphOwner), Member = "Initialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JSONSerializer), Member = "Deserialize")]
	[Calls(Type = typeof(Graph), Member = "LoadGraphData")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GraphSerializationData Deserialize(string serializedGraph, bool validate, List<UnityEngine.Object> objectReferences)
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphSerializationData), Member = "Reconstruct")]
	[Calls(Type = typeof(Graph), Member = "Validate")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private bool LoadGraphData(GraphSerializationData data, bool validate)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual object OnDerivedDataSerialization()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void OnDerivedDataDeserialization(object data)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void GetSerializationData(out string json, out List<UnityEngine.Object> references)
	{
		json = null;
		references = null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 44)]
	public void SetSerializationObjectReferences(List<UnityEngine.Object> references)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	public string SerializeLocalBlackboard()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JSONSerializer), Member = "Deserialize")]
	[Calls(Type = typeof(BlackboardSource), Member = ".ctor")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public bool DeserializeLocalBlackboard(string json)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(NestedFSM), Member = "CheckInstance")]
	[CalledBy(Type = typeof(SubTree), Member = "CheckInstance")]
	[CalledBy(Type = typeof(GraphOwner), Member = "GetInstance")]
	[CalledBy(Type = typeof(NestedBTState), Member = "CheckInstance")]
	[CalledBy(Type = typeof(NestedFSMState), Member = "CheckInstance")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "CheckInstance")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static T Clone<T>(T graph) where T : Graph
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Serialize")]
	[Calls(Type = typeof(Graph), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public void CopySerialized(Graph target)
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "OnEnable")]
	[CalledBy(Type = typeof(Graph), Member = "Reset")]
	[CalledBy(Type = typeof(Graph), Member = "LoadGraphData")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[Calls(Type = typeof(Graph), Member = "GetAllTasksOfType")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(BlackboardSource), Member = "InitializePropertiesBinding")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	public void Validate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected virtual void OnGraphValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Enumerable), Member = "Any")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(JSONSerializer), Member = "Clone")]
	[Calls(Type = typeof(Node), Member = "Duplicate")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Graph), Member = "set_primeNode")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Connection), Member = "SetSourceNode")]
	[Calls(Type = typeof(Connection), Member = "SetTargetNode")]
	[Calls(Type = typeof(Connection), Member = "Duplicate")]
	[Calls(Type = typeof(Vector2), Member = "op_Inequality")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 57)]
	public static List<Node> CloneNodes(List<Node> originalNodes, Graph targetGraph = null, Vector2 originPosition = default(Vector2))
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void UpdateReferencesFromOwner(GraphOwner owner)
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[CalledBy(Type = typeof(GraphOwner<>), Member = "set_blackboard")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Graph), Member = "set_blackboard")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[Calls(Type = typeof(Graph), Member = "GetAllTasksOfType")]
	[Calls(Type = typeof(Task), Member = "SetOwnerSystem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateReferences(Component newAgent, IBlackboard newBlackboard)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateNodeBBFields()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "GetAllTasksOfType")]
	[Calls(Type = typeof(Task), Member = "SetOwnerSystem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SendTaskOwnerDefaults()
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "Serialize")]
	[CalledBy(Type = typeof(Graph), Member = "set_primeNode")]
	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
	[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
	[CalledBy(Type = typeof(Graph), Member = "ConnectNodes")]
	[CalledBy(Type = typeof(Graph), Member = "RemoveConnection")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Graph), Member = "AssignNodeID")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy")]
	[Calls(Type = typeof(Enumerable), Member = "ToList")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 26)]
	public void UpdateNodeIDs(bool alsoReorderList)
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	[CalledBy(Type = typeof(Graph), Member = "AssignNodeID")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "Contains")]
	[Calls(Type = typeof(Graph), Member = "AssignNodeID")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private int AssignNodeID(Node node, int lastID, ref Node[] parsed)
	{
		return 0;
	}

	[CalledBy(Type = typeof(ClickToStartDialogue), Member = "OnMouseDown")]
	[CalledBy(Type = typeof(NCUtils), Member = "EnterStateByTag")]
	[CalledBy(Type = typeof(NestedFSM), Member = "OnExecute")]
	[CalledBy(Type = typeof(SubTree), Member = "OnExecute")]
	[CalledBy(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CalledBy(Type = typeof(NestedBTState), Member = "OnEnter")]
	[CalledBy(Type = typeof(NestedFSMState), Member = "OnEnter")]
	[CalledBy(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "Internal_Log")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Graph), Member = "UpdateReferences")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(MonoManager), Member = "RegisterForUpdate")]
	[Calls(Type = typeof(Graph), Member = "add_onFinish")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 24)]
	public void StartGraph(Component newAgent, IBlackboard newBlackboard, bool autoUpdate, Action<bool> callback = null)
	{
	}

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(MonoManager), Member = "UnRegisterForUpdate")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 22)]
	public void Stop(bool success = true)
	{
	}

	[CalledBy(Type = typeof(NestedFSM), Member = "OnGraphPaused")]
	[CalledBy(Type = typeof(SubTree), Member = "OnGraphPaused")]
	[CalledBy(Type = typeof(GraphOwner), Member = "PauseBehaviour")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnPause")]
	[CalledBy(Type = typeof(NestedBTState), Member = "OnExit")]
	[CalledBy(Type = typeof(NestedBTState), Member = "OnPause")]
	[CalledBy(Type = typeof(NestedFSMState), Member = "OnPause")]
	[CalledBy(Type = typeof(DialogueTreeController), Member = "PauseDialogue")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnGraphPaused")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(MonoManager), Member = "UnRegisterForUpdate")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	public void Pause()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UpdateGraph()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetAccumulatedDeltaTime(float deltaTime)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected virtual void OnGraphStarted()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected virtual void OnGraphUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected virtual void OnGraphStoped()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected virtual void OnGraphPaused()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected virtual void OnGraphUnpaused()
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "SendGlobalEvent")]
	[CalledBy(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CalledBy(Type = typeof(Node), Member = "SendEvent")]
	[CalledBy(Type = typeof(NestedBTState), Member = "OnFinish")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SendEvent(EventData eventData, object sender)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendEvent")]
	[CalledBy(Type = typeof(SendEvent), Member = "OnUpdate")]
	[CalledBy(Type = typeof(SendEvent<>), Member = "OnUpdate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	public static void SendGlobalEvent(EventData eventData, object sender)
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public Node GetNodeWithID(int searchID)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public List<T> GetAllNodesOfType<T>() where T : Node
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(NCUtils), Member = "SetInitialStateByTag")]
	[CalledBy(Type = typeof(NCUtils), Member = "EnterStateByTag")]
	[CalledBy(Type = typeof(RootSwitcher), Member = "OnGraphStarted")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public T GetNodeWithTag<T>(string tagName) where T : Node
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(NodeToggler), Member = "OnGraphStarted")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 20)]
	public List<T> GetNodesWithTag<T>(string tagName) where T : Node
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 20)]
	public List<T> GetAllTagedNodes<T>() where T : Node
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Where")]
	[Calls(Type = typeof(Enumerable), Member = "ToList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public List<Node> GetRootNodes()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Where")]
	[Calls(Type = typeof(Enumerable), Member = "ToList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public List<Node> GetLeafNodes()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "OfType")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 29)]
	public List<T> GetAllNestedGraphs<T>(bool recursive) where T : Graph
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "GetAllInstancedNestedGraphs")]
	[CalledBy(Type = typeof(GraphOwner), Member = "OnDestroy")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Enumerable), Member = "OfType")]
	[Calls(Type = typeof(Graph), Member = "GetAllInstancedNestedGraphs")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	public List<Graph> GetAllInstancedNestedGraphs()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public static Graph GetElementGraph(object obj)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Graph), Member = "Validate")]
	[CalledBy(Type = typeof(Graph), Member = "UpdateReferences")]
	[CalledBy(Type = typeof(Graph), Member = "SendTaskOwnerDefaults")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Graph), Member = "GetObjectTasks")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 28)]
	public List<T> GetAllTasksOfType<T>() where T : Task
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Graph), Member = "GetAllTasksOfType")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	private void GetObjectTasks<T>(object obj, ref List<T> tasks) where T : Task
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "GetTaskParentElement")]
	[CalledBy(Type = typeof(Graph), Member = "GetParameterParentElement")]
	[CalledBy(Type = typeof(Graph), Member = "GetDefinedParameters")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public HierarchyTree.Element GetFlatGraphHierarchy()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public HierarchyTree.Element GetFullGraphHierarchy()
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "GetNestedGraphHierarchy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graph), Member = "GetNestedGraphHierarchy")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public HierarchyTree.Element GetNestedGraphHierarchy()
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
	[CalledBy(Type = typeof(Graph), Member = "GetFullGraphHierarchy")]
	[CalledBy(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	[Calls(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private HierarchyTree.Element GetTreeNodeElement(Node node, bool recurse, ref int lastID)
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	[CalledBy(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[CalledBy(Type = typeof(Graph), Member = "GetTasksInElement")]
	[CalledBy(Type = typeof(Graph), Member = "GetParametersInElement")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(BBParameter), Member = "GetObjectBBParameters")]
	[Calls(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 32)]
	public static HierarchyTree.Element GetTaskAndParametersStructureInTarget(object obj)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "FindReferenceElement")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public IGraphElement GetTaskParentElement(Task targetTask)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "FindReferenceElement")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public IGraphElement GetParameterParentElement(BBParameter targetParameter)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "GetAllChildrenReferencesOfType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Task[] GetTasksInElement(IGraphElement target)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "GetAllChildrenReferencesOfType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static BBParameter[] GetParametersInElement(IGraphElement target)
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "PromoteDefinedParametersToVariables")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "GetAllChildrenReferencesOfType")]
	[Calls(Type = typeof(Enumerable), Member = "Where")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public BBParameter[] GetDefinedParameters()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "GetDefinedParameters")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CallsUnknownMethods(Count = 3)]
	public void PromoteDefinedParametersToVariables(IBlackboard bb)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Graph), Member = "AddNode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public T AddNode<T>() where T : Node
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Graph), Member = "AddNode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public T AddNode<T>(Vector2 pos) where T : Node
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public Node AddNode(Type nodeType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReflectionTools), Member = "GetFirstGenericParameterConstraintType")]
	[Calls(Type = typeof(Node), Member = "Create")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Graph), Member = "set_primeNode")]
	[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 25)]
	public Node AddNode(Type nodeType, Vector2 pos)
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "ClearGraph")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTIsDefined")]
	[Calls(Type = typeof(Enumerable), Member = "Where")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(Graph), Member = "RemoveConnection")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Graph), Member = "GetNodeWithID")]
	[Calls(Type = typeof(Graph), Member = "set_primeNode")]
	[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 33)]
	public void RemoveNode(Node node, bool recordUndo = true, bool force = false)
	{
	}

	[CalledBy(Type = typeof(BTNode), Member = "AddChild")]
	[CalledBy(Type = typeof(BTNode), Member = "AddChild")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Node), Member = "IsNewConnectionAllowed")]
	[Calls(Type = typeof(Connection), Member = "Create")]
	[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	[CallsDeduplicatedMethods(Count = 1)]
	public Connection ConnectNodes(Node sourceNode, Node targetNode, int sourceIndex = -1, int targetIndex = -1)
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 14)]
	public void RemoveConnection(Connection connection, bool recordUndo = true)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void RecordUndo(string name)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "RemoveNode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void ClearGraph()
	{
	}

	[CalledBy(Type = typeof(BehaviourTree), Member = ".ctor")]
	[CalledBy(Type = typeof(FSM), Member = ".ctor")]
	[CalledBy(Type = typeof(DialogueTree), Member = ".ctor")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected Graph()
	{
	}
}
