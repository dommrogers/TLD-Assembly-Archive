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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	private void Update()
	{
	}

	[Calls(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CallerCount(Count = 0)]
	private void FixedUpdate()
	{
	}

	[Calls(Type = typeof(PropertyReference), Member = "Reset")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyReference), Member = "Reset")]
	private void OnValidate()
	{
	}

	[Calls(Type = typeof(PropertyReference), Member = "Set")]
	[Calls(Type = typeof(PropertyReference), Member = "Get")]
	[Calls(Type = typeof(PropertyReference), Member = "Get")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "Start")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "Update")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "LateUpdate")]
	[Calls(Type = typeof(PropertyReference), Member = "Get")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "FixedUpdate")]
	[Calls(Type = typeof(PropertyReference), Member = "Get")]
	[Calls(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[Calls(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[ContextMenu("Update Now")]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateTarget()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PropertyBinding()
	{
	}
}
