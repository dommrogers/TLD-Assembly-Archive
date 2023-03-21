using System;
using System.Collections.Generic;
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
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass110_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CCloneNodes_003Eb__0(Node n)
		{
			return default(bool);
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
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal bool _003CUpdateNodeIDs_003Eb__115_0(Node n)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CUpdateNodeIDs_003Eb__115_1(Node n)
		{
			return default(int);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal bool _003CGetRootNodes_003Eb__134_0(Node n)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal bool _003CGetLeafNodes_003Eb__135_0(Node n)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		internal bool _003CGetDefinedParameters_003Eb__150_0(BBParameter p)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass129_0
	{
		public int searchID;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass129_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetNodeWithID_003Eb__0(Node n)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass156_0
	{
		public Node node;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass156_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal bool _003CRemoveNode_003Eb__0(Node n)
		{
			return default(bool);
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

	public abstract Type baseNodeType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	public abstract bool requiresAgent
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	public abstract bool requiresPrimeNode
	{
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		get;
	}

	public abstract bool isTree
	{
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		get;
	}

	public abstract bool useLocalBlackboard
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	public abstract bool canAcceptVariableDrops
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

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
		[CallerCount(Count = 15)]
		get
		{
			return null;
		}
		[CallerCount(Count = 20)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public string comments
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
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
			return default(float);
		}
	}

	public float deltaTime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	public bool isRunning
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
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
			return default(bool);
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
			return default(bool);
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
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 14)]
		private set
		{
		}
	}

	public Node primeNode
	{
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 23)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(Graph), Member = "AddNode")]
		[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
		[CalledBy(Type = typeof(RootSwitcher), Member = "OnExecute")]
		[CalledBy(Type = typeof(NCUtils), Member = "SetInitialStateByTag")]
		[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
		[Calls(Type = typeof(Node), Member = "Reset")]
		[CallsDeduplicatedMethods(Count = 5)]
		[Calls(Type = typeof(Graph), Member = "get_primeNode")]
		[Calls(Type = typeof(Graph), Member = "get_primeNode")]
		[Calls(Type = typeof(Graph), Member = "get_primeNode")]
		[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Node), Member = "Reset")]
		[CallsUnknownMethods(Count = 4)]
		set
		{
		}
	}

	public List<CanvasGroup> canvasGroups
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
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
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Component agent
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		private set
		{
		}
	}

	public IBlackboard blackboard
	{
		[CalledBy(Type = typeof(SubDialogueTree), Member = "SetVariablesMapping")]
		[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(NestedFSMState), Member = "CheckInstance")]
		[CalledBy(Type = typeof(Action_InvokeConcurrentGraph), Member = "OnExecute")]
		[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
		[CalledBy(Type = typeof(State_InvokeGraphBase), Member = "OnEnter")]
		[CalledBy(Type = typeof(Action_InvokeConcurrentGraph), Member = "OnExecute")]
		[CalledBy(Type = typeof(GraphOwner), Member = "GetInstance")]
		[CalledBy(Type = typeof(Graph), Member = "UpdateReferences")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(State_InvokeGraphBase), Member = "OnEnter")]
		set
		{
		}
	}

	public BlackboardSource localBlackboard
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(BlackboardSource), Member = ".ctor")]
		[CallerCount(Count = 22)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
	}

	private UnityEngine.Object NodeCanvas_002EFramework_002EITaskSystem_002EcontextObject
	{
		[CallerCount(Count = 1949)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public static event Action<Graph> onGraphSerialized
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public static event Action<Graph> onGraphDeserialized
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event Action<bool> onFinish
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[CallsDeduplicatedMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
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

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Validate")]
	protected void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[CalledBy(Type = typeof(Graph), Member = "UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize")]
	[CallsUnknownMethods(Count = 1)]
	public void Serialize()
	{
	}

	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Graph), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[Calls(Type = typeof(Graph), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void Deserialize()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GraphSerializationData), Member = ".ctor")]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	[CalledBy(Type = typeof(Graph), Member = "CopySerialized")]
	[CallsUnknownMethods(Count = 15)]
	public string Serialize(bool pretyJson, List<UnityEngine.Object> objectReferences)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GraphOwner), Member = "Initialize")]
	[CalledBy(Type = typeof(Graph), Member = "CopySerialized")]
	[CalledBy(Type = typeof(Graph), Member = "Deserialize")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[Calls(Type = typeof(Graph), Member = "LoadGraphData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public GraphSerializationData Deserialize(string serializedGraph, bool validate, List<UnityEngine.Object> objectReferences)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GraphSerializationData), Member = "Reconstruct")]
	[Calls(Type = typeof(Graph), Member = "Validate")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[CalledBy(Type = typeof(Graph), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 5)]
	private bool LoadGraphData(GraphSerializationData data, bool validate)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual object OnDerivedDataSerialization()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void OnDerivedDataDeserialization(object data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void GetSerializationData(out string json, out List<UnityEngine.Object> references)
	{
		json = null;
		references = null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 41)]
	public void SetSerializationObjectReferences(List<UnityEngine.Object> references)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	public string SerializeLocalBlackboard()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BlackboardSource), Member = ".ctor")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool DeserializeLocalBlackboard(string json)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 2)]
	public static T Clone<T>(T graph) where T : Graph
	{
		return null;
	}

	[Calls(Type = typeof(Graph), Member = "Deserialize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	public void CopySerialized(Graph target)
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "OnEnable")]
	[CalledBy(Type = typeof(Graph), Member = "Reset")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Graph), Member = "LoadGraphData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BlackboardSource), Member = "InitializePropertiesBinding")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 3)]
	public void Validate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void OnGraphValidate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 57)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector2), Member = "op_Inequality")]
	[Calls(Type = typeof(Connection), Member = "Duplicate")]
	[Calls(Type = typeof(Connection), Member = "SetTargetNode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Connection), Member = "SetSourceNode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Node), Member = "Duplicate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Graph), Member = "set_primeNode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static List<Node> CloneNodes(List<Node> originalNodes, Graph targetGraph = null, Vector2 originPosition = default(Vector2))
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void UpdateReferencesFromOwner(GraphOwner owner)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GraphOwner<>), Member = "set_blackboard")]
	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Task), Member = "SetOwnerSystem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Graph), Member = "set_blackboard")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	public void UpdateReferences(Component newAgent, IBlackboard newBlackboard)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	private void UpdateNodeBBFields()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Task), Member = "SetOwnerSystem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public void SendTaskOwnerDefaults()
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(Graph), Member = "RemoveConnection")]
	[CalledBy(Type = typeof(Graph), Member = "ConnectNodes")]
	[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
	[CalledBy(Type = typeof(Graph), Member = "Serialize")]
	[CalledBy(Type = typeof(Graph), Member = "set_primeNode")]
	[Calls(Type = typeof(Graph), Member = "AssignNodeID")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Graph), Member = "AssignNodeID")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	public void UpdateNodeIDs(bool alsoReorderList)
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "AssignNodeID")]
	[CalledBy(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	[CalledBy(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Graph), Member = "AssignNodeID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private int AssignNodeID(Node node, int lastID, ref Node[] parsed)
	{
		return default(int);
	}

	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(ClickToStartDialogue), Member = "OnMouseDown")]
	[CalledBy(Type = typeof(NCUtils), Member = "EnterStateByTag")]
	[CalledBy(Type = typeof(NestedFSM), Member = "OnExecute")]
	[CalledBy(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CalledBy(Type = typeof(NestedBTState), Member = "OnEnter")]
	[CalledBy(Type = typeof(NestedFSMState), Member = "OnEnter")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	[Calls(Type = typeof(Graph), Member = "add_onFinish")]
	[CalledBy(Type = typeof(SubTree), Member = "OnExecute")]
	[CalledBy(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[Calls(Type = typeof(MonoManager), Member = "RegisterForUpdate")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Graph), Member = "UpdateReferences")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "Internal_Log")]
	public void StartGraph(Component newAgent, IBlackboard newBlackboard, bool autoUpdate, Action<bool> callback = null)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(MonoManager), Member = "UnRegisterForUpdate")]
	public void Stop(bool success = true)
	{
	}

	[CalledBy(Type = typeof(NestedBTState), Member = "OnExit")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnGraphPaused")]
	[CalledBy(Type = typeof(DialogueTreeController), Member = "PauseDialogue")]
	[CalledBy(Type = typeof(NestedFSMState), Member = "OnPause")]
	[CalledBy(Type = typeof(NestedBTState), Member = "OnPause")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnPause")]
	[CalledBy(Type = typeof(GraphOwner), Member = "PauseBehaviour")]
	[CalledBy(Type = typeof(SubTree), Member = "OnGraphPaused")]
	[CalledBy(Type = typeof(NestedFSM), Member = "OnGraphPaused")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MonoManager), Member = "UnRegisterForUpdate")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 9)]
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

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected virtual void OnGraphStarted()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void OnGraphUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void OnGraphStoped()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void OnGraphPaused()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void OnGraphUnpaused()
	{
	}

	[CalledBy(Type = typeof(Node), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NestedBTState), Member = "OnFinish")]
	[CalledBy(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CalledBy(Type = typeof(NestedBTState), Member = "OnFinish")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Graph), Member = "SendGlobalEvent")]
	public void SendEvent(EventData eventData, object sender)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendEvent")]
	[CalledBy(Type = typeof(SendEvent), Member = "OnUpdate")]
	[CalledBy(Type = typeof(SendEvent<>), Member = "OnUpdate")]
	[CallsUnknownMethods(Count = 15)]
	public static void SendGlobalEvent(EventData eventData, object sender)
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public T GetNodeWithTag<T>(string tagName) where T : Node
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 20)]
	public List<T> GetNodesWithTag<T>(string tagName) where T : Node
	{
		return null;
	}

	[CallsUnknownMethods(Count = 20)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public List<T> GetAllTagedNodes<T>() where T : Node
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public List<Node> GetRootNodes()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public List<Node> GetLeafNodes()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 29)]
	public List<T> GetAllNestedGraphs<T>(bool recursive) where T : Graph
	{
		return null;
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(GraphOwner), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Graph), Member = "GetAllInstancedNestedGraphs")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Graph), Member = "GetAllInstancedNestedGraphs")]
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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public List<T> GetAllTasksOfType<T>() where T : Task
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	private void GetObjectTasks<T>(object obj, ref List<T> tasks) where T : Task
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Graph), Member = "GetDefinedParameters")]
	[CalledBy(Type = typeof(Graph), Member = "GetTaskParentElement")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Graph), Member = "GetParameterParentElement")]
	[Calls(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	public HierarchyTree.Element GetFlatGraphHierarchy()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	[Calls(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	[Calls(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	public HierarchyTree.Element GetFullGraphHierarchy()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Graph), Member = "GetNestedGraphHierarchy")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "GetNestedGraphHierarchy")]
	[CallsDeduplicatedMethods(Count = 1)]
	public HierarchyTree.Element GetNestedGraphHierarchy()
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	[CalledBy(Type = typeof(Graph), Member = "GetFullGraphHierarchy")]
	[CalledBy(Type = typeof(Graph), Member = "GetFullGraphHierarchy")]
	[CalledBy(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	[Calls(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[Calls(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	private HierarchyTree.Element GetTreeNodeElement(Node node, bool recurse, ref int lastID)
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "GetParametersInElement")]
	[CalledBy(Type = typeof(Graph), Member = "GetTasksInElement")]
	[CalledBy(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[CalledBy(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	[CalledBy(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	[Calls(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	[Calls(Type = typeof(BBParameter), Member = "GetObjectBBParameters")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 32)]
	public static HierarchyTree.Element GetTaskAndParametersStructureInTarget(object obj)
	{
		return null;
	}

	[Calls(Type = typeof(HierarchyTree.Element), Member = "FindReferenceElement")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
	public IGraphElement GetTaskParentElement(Task targetTask)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "FindReferenceElement")]
	[CallsUnknownMethods(Count = 6)]
	public IGraphElement GetParameterParentElement(BBParameter targetParameter)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[CallsUnknownMethods(Count = 2)]
	public static Task[] GetTasksInElement(IGraphElement target)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static BBParameter[] GetParametersInElement(IGraphElement target)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
	[CalledBy(Type = typeof(Graph), Member = "PromoteDefinedParametersToVariables")]
	[CallsUnknownMethods(Count = 8)]
	public BBParameter[] GetDefinedParameters()
	{
		return null;
	}

	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "GetDefinedParameters")]
	[CallsUnknownMethods(Count = 3)]
	public void PromoteDefinedParametersToVariables(IBlackboard bb)
	{
	}

	[Calls(Type = typeof(Graph), Member = "AddNode")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public T AddNode<T>() where T : Node
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Graph), Member = "AddNode")]
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

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Graph), Member = "set_primeNode")]
	[Calls(Type = typeof(Node), Member = "Create")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetFirstGenericParameterConstraintType")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	public Node AddNode(Type nodeType, Vector2 pos)
	{
		return null;
	}

	[Calls(Type = typeof(Graph), Member = "set_primeNode")]
	[CallsUnknownMethods(Count = 33)]
	[CalledBy(Type = typeof(Graph), Member = "ClearGraph")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	[Calls(Type = typeof(Graph), Member = "GetNodeWithID")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Graph), Member = "RemoveConnection")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Graph), Member = "RemoveConnection")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	public void RemoveNode(Node node, bool recordUndo = true, bool force = false)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = "IsNewConnectionAllowed")]
	[Calls(Type = typeof(Connection), Member = "Create")]
	[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	[CalledBy(Type = typeof(BTNode), Member = "AddChild")]
	[CalledBy(Type = typeof(BTNode), Member = "AddChild")]
	public Connection ConnectNodes(Node sourceNode, Node targetNode, int sourceIndex = -1, int targetIndex = -1)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
	[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	public void RemoveConnection(Connection connection, bool recordUndo = true)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void RecordUndo(string name)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "RemoveNode")]
	[CallsUnknownMethods(Count = 4)]
	public void ClearGraph()
	{
	}

	[CalledBy(Type = typeof(FSM), Member = ".ctor")]
	[CalledBy(Type = typeof(DialogueTree), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BehaviourTree), Member = ".ctor")]
	protected Graph()
	{
	}
}
