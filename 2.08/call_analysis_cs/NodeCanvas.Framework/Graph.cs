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
		[CallerCount(Count = 6)]
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
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetRootNodes_003Eb__134_0(Node n)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass129_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		internal bool _003CGetNodeWithID_003Eb__0(Node n)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass156_0
	{
		public Node node;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass156_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
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
		[CallerCount(Count = 101262)]
		get;
	}

	public abstract bool requiresAgent
	{
		[CallerCount(Count = 101262)]
		[DeduplicatedMethod]
		get;
	}

	public abstract bool requiresPrimeNode
	{
		[CallerCount(Count = 101262)]
		[DeduplicatedMethod]
		get;
	}

	public abstract bool isTree
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	public abstract bool useLocalBlackboard
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	public abstract bool canAcceptVariableDrops
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
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
		[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string category
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

	public string comments
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 16)]
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

	public float elapsedTime
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public Node primeNode
	{
		[CallerCount(Count = 24)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(Graph), Member = "AddNode")]
		[CalledBy(Type = typeof(Graph), Member = "CloneNodes")]
		[Calls(Type = typeof(Graph), Member = "get_primeNode")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(RootSwitcher), Member = "OnExecute")]
		[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
		[CalledBy(Type = typeof(NCUtils), Member = "SetInitialStateByTag")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Node), Member = "Reset")]
		[Calls(Type = typeof(Node), Member = "Reset")]
		[Calls(Type = typeof(Graph), Member = "get_primeNode")]
		[Calls(Type = typeof(Graph), Member = "get_primeNode")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
		set
		{
		}
	}

	public List<CanvasGroup> canvasGroups
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 10)]
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
		[DeduplicatedMethod]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 6)]
		private set
		{
		}
	}

	public IBlackboard blackboard
	{
		[CalledBy(Type = typeof(SubDialogueTree), Member = "SetVariablesMapping")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public BlackboardSource localBlackboard
	{
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(BlackboardSource), Member = ".ctor")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private UnityEngine.Object NodeCanvas_002EFramework_002EITaskSystem_002EcontextObject
	{
		[CallerCount(Count = 797)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public static event Action<Graph> onGraphSerialized
	{
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	public static event Action<Graph> onGraphDeserialized
	{
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public event Action<bool> onFinish
	{
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
		[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
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

	[Calls(Type = typeof(Graph), Member = "Validate")]
	[CallerCount(Count = 0)]
	protected void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Validate")]
	protected void Reset()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Graph), Member = "UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	public void Serialize()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Deserialize")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[CalledBy(Type = typeof(Graph), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	[Calls(Type = typeof(GraphSerializationData), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public string Serialize(bool pretyJson, List<UnityEngine.Object> objectReferences)
	{
		return null;
	}

	[CalledBy(Type = typeof(GraphOwner), Member = "Initialize")]
	[CalledBy(Type = typeof(Graph), Member = "CopySerialized")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[CalledBy(Type = typeof(Graph), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "LoadGraphData")]
	[CallerCount(Count = 3)]
	public GraphSerializationData Deserialize(string serializedGraph, bool validate, List<UnityEngine.Object> objectReferences)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphSerializationData), Member = "Reconstruct")]
	[Calls(Type = typeof(Graph), Member = "Validate")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[CalledBy(Type = typeof(Graph), Member = "Deserialize")]
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

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual void OnDerivedDataDeserialization(object data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void GetSerializationData(out string json, out List<UnityEngine.Object> references)
	{
		json = null;
		references = null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
	public void SetSerializationObjectReferences(List<UnityEngine.Object> references)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	public string SerializeLocalBlackboard()
	{
		return null;
	}

	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlackboardSource), Member = ".ctor")]
	public bool DeserializeLocalBlackboard(string json)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 1)]
	public static T Clone<T>(T graph) where T : Graph
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Deserialize")]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	[Calls(Type = typeof(GraphSerializationData), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public void CopySerialized(Graph target)
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "Reset")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Graph), Member = "LoadGraphData")]
	[Calls(Type = typeof(BlackboardSource), Member = "InitializePropertiesBinding")]
	[CalledBy(Type = typeof(Graph), Member = "OnEnable")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	public void Validate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnGraphValidate()
	{
	}

	[Calls(Type = typeof(Connection), Member = "SetTargetNode")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Connection), Member = "SetSourceNode")]
	[Calls(Type = typeof(Node), Member = "Duplicate")]
	[Calls(Type = typeof(Graph), Member = "set_primeNode")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Connection), Member = "Duplicate")]
	public static List<Node> CloneNodes(List<Node> originalNodes, Graph targetGraph = null, Vector2 originPosition = default(Vector2))
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void UpdateReferencesFromOwner(GraphOwner owner)
	{
	}

	[CalledBy(Type = typeof(GraphOwner<>), Member = "set_blackboard")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[Calls(Type = typeof(Graph), Member = "SendTaskOwnerDefaults")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateReferences(Component newAgent, IBlackboard newBlackboard)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	private void UpdateNodeBBFields()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "Internal_Log")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Graph), Member = "UpdateReferences")]
	[CallsUnknownMethods(Count = 2)]
	public void SendTaskOwnerDefaults()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Graph), Member = "RemoveConnection")]
	[CalledBy(Type = typeof(Graph), Member = "ConnectNodes")]
	[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
	[CalledBy(Type = typeof(Graph), Member = "set_primeNode")]
	[CalledBy(Type = typeof(Graph), Member = "Serialize")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CalledBy(Type = typeof(Graph), Member = "CopySerialized")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Graph), Member = "AssignNodeID")]
	[Calls(Type = typeof(Graph), Member = "AssignNodeID")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	public void UpdateNodeIDs(bool alsoReorderList)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Graph), Member = "AssignNodeID")]
	[CalledBy(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	[Calls(Type = typeof(Graph), Member = "AssignNodeID")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	private int AssignNodeID(Node node, int lastID, ref Node[] parsed)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(NestedFSM), Member = "OnExecute")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[CalledBy(Type = typeof(ClickToStartDialogue), Member = "OnMouseDown")]
	[CalledBy(Type = typeof(NCUtils), Member = "EnterStateByTag")]
	[CalledBy(Type = typeof(SubTree), Member = "OnExecute")]
	[Calls(Type = typeof(Graph), Member = "add_onFinish")]
	[CalledBy(Type = typeof(NestedBTState), Member = "OnEnter")]
	[CalledBy(Type = typeof(NestedFSMState), Member = "OnEnter")]
	[CalledBy(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	[CalledBy(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Graph), Member = "UpdateReferences")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "Internal_Log")]
	public void StartGraph(Component newAgent, IBlackboard newBlackboard, bool autoUpdate, Action<bool> callback = null)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	public void Stop(bool success = true)
	{
	}

	[CalledBy(Type = typeof(NestedBTState), Member = "OnExit")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnGraphPaused")]
	[CalledBy(Type = typeof(DialogueTreeController), Member = "PauseDialogue")]
	[CalledBy(Type = typeof(NestedBTState), Member = "OnPause")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnPause")]
	[CalledBy(Type = typeof(NestedFSMState), Member = "OnPause")]
	[CalledBy(Type = typeof(SubTree), Member = "OnGraphPaused")]
	[CalledBy(Type = typeof(NestedFSM), Member = "OnGraphPaused")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(GraphOwner), Member = "PauseBehaviour")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[CallsDeduplicatedMethods(Count = 6)]
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

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected virtual void OnGraphStarted()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnGraphUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnGraphStoped()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnGraphPaused()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnGraphUnpaused()
	{
	}

	[CalledBy(Type = typeof(NestedBTState), Member = "OnFinish")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(NestedBTState), Member = "OnFinish")]
	[CalledBy(Type = typeof(Node), Member = "SendEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Graph), Member = "SendGlobalEvent")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(GraphOwner), Member = "SendEvent")]
	public void SendEvent(EventData eventData, object sender)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SendEvent<>), Member = "OnUpdate")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendEvent")]
	[CalledBy(Type = typeof(SendEvent), Member = "OnUpdate")]
	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(MissionServicesManager._003CPostSceneLoadCo_003Ed__109), Member = "MoveNext")]
	public static void SendGlobalEvent(EventData eventData, object sender)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Node GetNodeWithID(int searchID)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public List<T> GetAllNodesOfType<T>() where T : Node
	{
		return null;
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public T GetNodeWithTag<T>(string tagName) where T : Node
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 13)]
	public List<T> GetNodesWithTag<T>(string tagName) where T : Node
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	public List<T> GetAllTagedNodes<T>() where T : Node
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	public List<Node> GetRootNodes()
	{
		return null;
	}

	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public List<Node> GetLeafNodes()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 28)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public List<T> GetAllNestedGraphs<T>(bool recursive) where T : Graph
	{
		return null;
	}

	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Graph), Member = "GetAllInstancedNestedGraphs")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CalledBy(Type = typeof(Graph), Member = "GetAllInstancedNestedGraphs")]
	[CalledBy(Type = typeof(GraphOwner), Member = "OnDestroy")]
	public List<Graph> GetAllInstancedNestedGraphs()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static Graph GetElementGraph(object obj)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	public List<T> GetAllTasksOfType<T>() where T : Task
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void GetObjectTasks<T>(object obj, ref List<T> tasks) where T : Task
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Graph), Member = "GetTaskParentElement")]
	[CalledBy(Type = typeof(Graph), Member = "GetDefinedParameters")]
	[CalledBy(Type = typeof(Graph), Member = "GetParameterParentElement")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	[Calls(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[Calls(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	public HierarchyTree.Element GetFlatGraphHierarchy()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	[Calls(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	[CallsUnknownMethods(Count = 2)]
	public HierarchyTree.Element GetFullGraphHierarchy()
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "GetNestedGraphHierarchy")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	[Calls(Type = typeof(Graph), Member = "GetNestedGraphHierarchy")]
	[CallerCount(Count = 1)]
	public HierarchyTree.Element GetNestedGraphHierarchy()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	[CalledBy(Type = typeof(Graph), Member = "GetFullGraphHierarchy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	[CalledBy(Type = typeof(Graph), Member = "GetFullGraphHierarchy")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	[Calls(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[Calls(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	private HierarchyTree.Element GetTreeNodeElement(Node node, bool recurse, ref int lastID)
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Graph), Member = "GetParametersInElement")]
	[CalledBy(Type = typeof(Graph), Member = "GetTasksInElement")]
	[CalledBy(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[CalledBy(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
	[CalledBy(Type = typeof(Graph), Member = "GetTreeNodeElement")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "AddChild")]
	[Calls(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[Calls(Type = typeof(BBParameter), Member = "GetObjectBBParameters")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
	public static HierarchyTree.Element GetTaskAndParametersStructureInTarget(object obj)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "FindReferenceElement")]
	[CallsUnknownMethods(Count = 2)]
	public IGraphElement GetTaskParentElement(Task targetTask)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(HierarchyTree.Element), Member = "FindReferenceElement")]
	[Calls(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
	[CallerCount(Count = 0)]
	public IGraphElement GetParameterParentElement(BBParameter targetParameter)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[CallsUnknownMethods(Count = 1)]
	public static Task[] GetTasksInElement(IGraphElement target)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[CallsUnknownMethods(Count = 1)]
	public static BBParameter[] GetParametersInElement(IGraphElement target)
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "PromoteDefinedParametersToVariables")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
	[CallerCount(Count = 1)]
	public BBParameter[] GetDefinedParameters()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "GetDefinedParameters")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CallsUnknownMethods(Count = 2)]
	public void PromoteDefinedParametersToVariables(IBlackboard bb)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Graph), Member = "AddNode")]
	[CallsUnknownMethods(Count = 3)]
	public T AddNode<T>() where T : Node
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Graph), Member = "AddNode")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
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

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(Graph), Member = "set_primeNode")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Node), Member = "Create")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	public Node AddNode(Type nodeType, Vector2 pos)
	{
		return null;
	}

	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
	[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	[Calls(Type = typeof(Graph), Member = "set_primeNode")]
	[Calls(Type = typeof(Graph), Member = "RemoveConnection")]
	[Calls(Type = typeof(Graph), Member = "RemoveConnection")]
	[CalledBy(Type = typeof(Graph), Member = "ClearGraph")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[CallsUnknownMethods(Count = 8)]
	public void RemoveNode(Node node, bool recordUndo = true, bool force = false)
	{
	}

	[CalledBy(Type = typeof(BTNode), Member = "AddChild")]
	[CalledBy(Type = typeof(BTNode), Member = "AddChild")]
	[Calls(Type = typeof(Connection), Member = "Create")]
	[Calls(Type = typeof(Node), Member = "IsNewConnectionAllowed")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	public Connection ConnectNodes(Node sourceNode, Node targetNode, int sourceIndex = -1, int targetIndex = -1)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(Type = typeof(Graph), Member = "UpdateNodeIDs")]
	[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
	[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
	public void RemoveConnection(Connection connection, bool recordUndo = true)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void RecordUndo(string name)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "RemoveNode")]
	[CallsUnknownMethods(Count = 2)]
	public void ClearGraph()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueTree), Member = ".ctor")]
	[CalledBy(Type = typeof(BehaviourTree), Member = ".ctor")]
	[CalledBy(Type = typeof(FSM), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	protected Graph()
	{
	}
}
