using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PropertyBinding : MonoBehaviour
{
	public enum UpdateCondition
	{
		OnStart,
		OnUpdate,
		OnLateUpdate,
		OnFixedUpdate
	}

	public enum Direction
	{
		SourceUpdatesTarget,
		TargetUpdatesSource,
		BiDirectional
	}

	public PropertyReference source;

	public PropertyReference target;

	public Direction direction;

	public UpdateCondition update;

	public bool editMode;

	private object mLastValue;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CallerCount(Count = 0)]
	private void FixedUpdate()
	{
	}

	[Calls(Type = typeof(PropertyReference), Member = "Reset")]
	[Calls(Type = typeof(PropertyReference), Member = "Reset")]
	[CallerCount(Count = 0)]
	private void OnValidate()
	{
	}

	[Calls(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[Calls(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[Calls(Type = typeof(PropertyReference), Member = "Get")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "LateUpdate")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "Update")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "Start")]
	[Calls(Type = typeof(PropertyReference), Member = "Get")]
	[Calls(Type = typeof(PropertyReference), Member = "Get")]
	[Calls(Type = typeof(PropertyReference), Member = "Set")]
	[Calls(Type = typeof(PropertyReference), Member = "Get")]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "FixedUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[CallsUnknownMethods(Count = 14)]
	public void UpdateTarget()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PropertyBinding()
	{
	}
}
