using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework.Internal;
using NodeCanvas.StateMachines;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Framework;

[Serializable]
public abstract class Variable
{
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public Variable _003C_003E4__this;

		public Func<object, object> converter;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass37_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal object _003CGetGetConverter_003Eb__0()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		internal object _003CGetGetConverter_003Eb__1()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public Variable _003C_003E4__this;

		public Func<object, object> converter;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass39_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CGetSetConverter_003Eb__0(object x)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		internal void _003CGetSetConverter_003Eb__1(object x)
		{
		}
	}

	private string _name;

	private string _id;

	private bool _protected;

	public string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallsDeduplicatedMethods(Count = 2)]
		set
		{
		}
	}

	public string ID
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Guid), Member = "NewGuid")]
		[Calls(Type = typeof(Guid), Member = "ToString")]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public object value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 26)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public bool isProtected
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

	protected abstract object objectValue { get; set; }

	public abstract Type varType { get; }

	public abstract bool hasBinding { get; }

	public abstract string propertyPath { get; set; }

	public event Action<string> onNameChanged
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

	public event Action<string, object> onValueChanged
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected bool HasValueChangeEvent()
	{
		return false;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "MissionCompleted")]
	[CalledBy(Type = typeof(Variable<>), Member = "set_value")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnOptionSelected")]
	[CalledBy(Type = typeof(ParlayRollChance), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_GetContainerItemCount), Member = "DoContainerCheck")]
	[CalledBy(Type = typeof(Action_ContainerGetCalories), Member = "DoContainerCheck")]
	[CalledBy(Type = typeof(Action_ContainerAllFoodIsNatural), Member = "DoContainerCheck")]
	[CalledBy(Type = typeof(Action_ContainerGetFuelHours), Member = "DoContainerCheck")]
	[CalledBy(Type = typeof(Action_InvokeConcurrentGraph), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_MissionSelector), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_NPCSay), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_CheckNPCNeed), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_GetInvRequirementsCount), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_GetInvItemCount), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_GetWeightOfItems), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayerSay), Member = "DoSay")]
	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected void OnValueChanged(string name, object value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Variable()
	{
	}

	public abstract void BindProperty(MemberInfo prop, GameObject target = null);

	public abstract void UnBindProperty();

	public abstract void InitializePropertyBinding(GameObject go, bool callSetter = false);

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Variable), Member = "GetGetConverter")]
	public bool CanConvertTo(Type toType)
	{
		return false;
	}

	[CalledBy(Type = typeof(BBParameter<>), Member = "BindGetter")]
	[CalledBy(Type = typeof(Variable), Member = "CanConvertTo")]
	[CalledBy(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[CalledBy(TypeFullName = "NodeCanvas.Framework.Internal.BlackboardSource.<>c__DisplayClass30_0", Member = "<GetVariableNames>b__0")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TypeConverter), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 24)]
	public Func<object> GetGetConverter(Type toType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Variable), Member = "GetSetConverter")]
	public bool CanConvertFrom(Type fromType)
	{
		return false;
	}

	[CalledBy(Type = typeof(BBParameter<>), Member = "BindSetter")]
	[CalledBy(Type = typeof(Variable), Member = "CanConvertFrom")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeConverter), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 24)]
	public Action<object> GetSetConverter(Type fromType)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 59)]
	public override string ToString()
	{
		return null;
	}
}
[Serializable]
public class Variable<T> : Variable
{
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public Variable<T> _003C_003E4__this;

		public GameObject go;

		public FieldInfo field;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal T _003CInitializePropertyBinding_003Eb__1()
		{
			return default(T);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CInitializePropertyBinding_003Eb__3(T o)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_1
	{
		public MethodInfo getMethod;

		public Component instance;

		public MethodInfo setMethod;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public _003C_003Ec__DisplayClass22_1()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal T _003CInitializePropertyBinding_003Eb__0()
		{
			return default(T);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal void _003CInitializePropertyBinding_003Eb__2(T o)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_2
	{
		public Component instance;

		public _003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals1;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public _003C_003Ec__DisplayClass22_2()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal T _003CInitializePropertyBinding_003Eb__4()
		{
			return default(T);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal void _003CInitializePropertyBinding_003Eb__5(T o)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_3
	{
		public T value;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public _003C_003Ec__DisplayClass22_3()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		internal T _003CInitializePropertyBinding_003Eb__6()
		{
			return default(T);
		}
	}

	private T _value;

	private string _propertyPath;

	private Func<T> getter;

	private Action<T> setter;

	public override string propertyPath
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 46)]
		set
		{
		}
	}

	public override bool hasBinding
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	protected override object objectValue
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public override Type varType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public new T value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(T);
		}
		[DeduplicatedMethod]
		[CalledBy(Type = typeof(NCUtils), Member = "SpawnChildGraph")]
		[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
		[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "RegisterAsSubFSMOwner")]
		[CalledBy(Type = typeof(State_CinematicSubFSM), Member = "OnEnter")]
		[CalledBy(Type = typeof(State_GameplaySubFSM), Member = "OnEnter")]
		[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnOptionSelected")]
		[CalledBy(Type = typeof(ParlayRollChance), Member = "OnExecute")]
		[CalledBy(Type = typeof(Condition_EnterMissionTrigger), Member = "OnCustomEvent")]
		[CalledBy(Type = typeof(Condition_ExitMissionTrigger), Member = "OnCustomEvent")]
		[CalledBy(Type = typeof(Action_MissionSelector), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_IsInMissionTrigger), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_BuildCustomWeatherSetId), Member = "OnExecute")]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Variable), Member = "OnValueChanged")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Variable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public T GetValue()
	{
		return default(T);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetValue(T newValue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public override void BindProperty(MemberInfo prop, GameObject target = null)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void UnBindProperty()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetProperty")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetField")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ReflectionTools), Member = "IsConstant")]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallsUnknownMethods(Count = 124)]
	public override void InitializePropertyBinding(GameObject go, bool callSetter = false)
	{
	}
}
