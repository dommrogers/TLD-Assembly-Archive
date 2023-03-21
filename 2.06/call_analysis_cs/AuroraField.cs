using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.ModularElectrolizer;
using TLD.Serialization;
using UnityEngine;

public class AuroraField : MonoBehaviour
{
	public enum ControlledComponents
	{
		None,
		Electrolizer,
		Toggle
	}

	public float m_ChanceActive;

	public bool m_IsStaticField;

	public float m_Radius;

	private bool m_IsActive;

	private bool m_CanRollChance;

	private Collider[] m_Colliders;

	private static AuroraFieldDataProxy m_AuroraFieldDataProxy;

	private float m_ExtentRadius;

	private const float m_Margin = 0.5f;

	private ControlledComponents m_ControlledComponents;

	private float m_InvSqrRootOfTwo;

	public List<GameObject> m_InfluencedObjects;

	private List<AuroraModularElectrolizer> m_InfluencedAuroraElectrolizers;

	private List<AuroraActivatedToggle> m_InfluencedAAuroraActivatedToggles;

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(AuroraManager), Member = "RegisterAuroraField")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "UnRegisterAuroraField")]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AuroraField), Member = "ComputeRadiusExtent")]
	[CallsUnknownMethods(Count = 3)]
	public void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetExtentRadius()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(AuroraManager), Member = "UnRegisterAuroraField")]
	[Calls(Type = typeof(AuroraManager), Member = "RegisterAuroraField")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "Awake")]
	[CallsUnknownMethods(Count = 4)]
	public void SetDynamic(bool isDynamic)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetControlledComponents(ControlledComponents controlledComponentFlags)
	{
	}

	[CallerCount(Count = 0)]
	public bool DoesFieldControlComponents(ControlledComponents flag)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void UnsetControlledComponents(ControlledComponents flag)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterInvestigate")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveInvestigationPositionOutsideOfField")]
	[CallsUnknownMethods(Count = 5)]
	public Vector3 GetClosestPointOnFieldExtent(Vector3 position, float margin)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveWanderPosOutsideOfField")]
	[CallsUnknownMethods(Count = 8)]
	public Vector3 GetClosestPointOnFieldBorder(Vector3 position)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "UpdateAuroraFields")]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateActivation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	public void OnAuroraEnabled()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuroraField), Member = "ActivateElectrolizers")]
	[Calls(Type = typeof(AuroraField), Member = "ActivateToggles")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "UpdateAuroraFields")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateActivation")]
	public void OnAuroraDisabled()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CalledBy(Type = typeof(AuroraField), Member = "ActivateToggles")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundInsideAuroraField")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(AuroraField), Member = "ActivateElectrolizers")]
	public bool Contains(Vector3 position)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "GetVisibleFieldNearby")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	public bool Contains(Vector3 position, float radius)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	public void Enable(bool enabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public bool IsStaticField()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void ResetAllAuroraFieldLayerToDefault(GameObject rootObject)
	{
	}

	[CalledBy(Type = typeof(Action_AuroraFielEnable), Member = "DoWork")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AuroraField), Member = "ActivateElectrolizers")]
	[Calls(Type = typeof(AuroraField), Member = "ActivateToggles")]
	[CalledBy(Type = typeof(AuroraField), Member = "Deserialize")]
	[CalledBy(Type = typeof(AuroraField), Member = "OnAuroraEnabled")]
	[CalledBy(Type = typeof(AuroraField), Member = "Enable")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "EnableAllStaticFields")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_aurorafields")]
	[CallsUnknownMethods(Count = 3)]
	private void SetFieldActive(bool enabled)
	{
	}

	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallerCount(Count = 0)]
	private bool ShouldActivate()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AuroraField), Member = "OnFieldEnableChanged")]
	[CalledBy(Type = typeof(AuroraField), Member = "OnAuroraDisabled")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void ActivateElectrolizers(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AuroraField), Member = "OnFieldEnableChanged")]
	[CalledBy(Type = typeof(AuroraField), Member = "OnAuroraDisabled")]
	[CalledBy(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void ActivateToggles(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AuroraField), Member = "ActivateElectrolizers")]
	[Calls(Type = typeof(AuroraField), Member = "ActivateToggles")]
	[CallsUnknownMethods(Count = 3)]
	private void OnFieldEnableChanged(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(AuroraField), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private void ComputeRadiusExtent()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public AuroraField()
	{
	}
}
