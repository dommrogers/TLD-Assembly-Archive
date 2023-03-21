using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class EventDelegate
{
	[Serializable]
	public class Parameter
	{
		public UnityEngine.Object obj;

		public string field;

		[NonSerialized]
		private object mValue;

		[NonSerialized]
		public Type expectedType;

		[NonSerialized]
		public bool cached;

		[NonSerialized]
		public PropertyInfo propInfo;

		[NonSerialized]
		public FieldInfo fieldInfo;

		public object value
		{
			[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
			[Calls(Type = typeof(Type), Member = "GetProperty")]
			[Calls(Type = typeof(Convert), Member = "ChangeType")]
			[CallsDeduplicatedMethods(Count = 5)]
			[CallsUnknownMethods(Count = 9)]
			get
			{
				return null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			set
			{
			}
		}

		public Type type
		{
			[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
			[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 1)]
		public Parameter()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 1)]
		public Parameter(UnityEngine.Object obj, string field)
		{
		}

		[CalledBy(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 1)]
		public Parameter(object val)
		{
		}
	}

	public delegate void Callback();

	private MonoBehaviour mTarget;

	private string mMethodName;

	private Parameter[] mParameters;

	public bool oneShot;

	[NonSerialized]
	private Callback mCachedCallback;

	[NonSerialized]
	private bool mRawDelegate;

	[NonSerialized]
	private bool mCached;

	[NonSerialized]
	private MethodInfo mMethod;

	[NonSerialized]
	private ParameterInfo[] mParameterInfos;

	[NonSerialized]
	private object[] mArgs;

	private static int s_Hash;

	public MonoBehaviour target
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string methodName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Parameter[] parameters
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventDelegate), Member = "Cache")]
		get
		{
			return null;
		}
	}

	public bool isValid
	{
		[CalledBy(Type = typeof(EventDelegate), Member = "Equals")]
		[CalledBy(Type = typeof(EventDelegate), Member = "IsValid")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(EventDelegate), Member = "Cache")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public bool isEnabled
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventDelegate), Member = "Cache")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public EventDelegate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	public EventDelegate(Callback call)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EventDelegate), Member = "Clear")]
	public EventDelegate(MonoBehaviour target, string methodName)
	{
	}

	[CalledBy(Type = typeof(EventDelegate), Member = "Equals")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static string GetMethodName(Callback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool IsValid(Callback callback)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(EventDelegate), Member = "GetMethodName")]
	[Calls(Type = typeof(EventDelegate), Member = "get_isValid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override bool Equals(object obj)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override int GetHashCode()
	{
		return 0;
	}

	[CalledBy(Type = typeof(EventDelegate), Member = ".ctor")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Set")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "InitializeHinterlandMailingListWidget")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EventDelegate), Member = "Clear")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void Set(Callback call)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EventDelegate), Member = "Clear")]
	public void Set(MonoBehaviour target, string methodName)
	{
	}

	[CalledBy(Type = typeof(EventDelegate), Member = "get_parameters")]
	[CalledBy(Type = typeof(EventDelegate), Member = "get_isValid")]
	[CalledBy(Type = typeof(EventDelegate), Member = "get_isEnabled")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
	[CalledBy(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 57)]
	private void Cache()
	{
	}

	[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
	[CalledBy(Type = typeof(DoubleClickButton), Member = "OnClick")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EventDelegate), Member = "Cache")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(Parameter), Member = "get_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Parameter), Member = "get_type")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 71)]
	public bool Execute()
	{
		return false;
	}

	[CalledBy(Type = typeof(EventDelegate), Member = ".ctor")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Set")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Set")]
	[CallerCount(Count = 3)]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override string ToString()
	{
		return null;
	}

	[CallerCount(Count = 31)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void Execute(List<EventDelegate> list)
	{
	}

	[CalledBy(Type = typeof(UIPlayAnimation), Member = "Awake")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "Awake")]
	[CalledBy(Type = typeof(UIPopupList), Member = "TriggerCallbacks")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Start")]
	[CalledBy(Type = typeof(UIInput), Member = "ExecuteOnChange")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnDragFinished")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnIncrease")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnDecrease")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(EventDelegate), Member = "get_isValid")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsValid(List<EventDelegate> list)
	{
		return false;
	}

	[CalledBy(Type = typeof(UITweener), Member = "SetOnFinished")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowNewLocationDiscovered")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static EventDelegate Set(List<EventDelegate> list, Callback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Set(List<EventDelegate> list, EventDelegate del)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 71)]
	public static EventDelegate Add(List<EventDelegate> list, Callback callback)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "Play")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Add")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static EventDelegate Add(List<EventDelegate> list, Callback callback, bool oneShot)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Add(List<EventDelegate> list, EventDelegate ev)
	{
	}

	[CalledBy(Type = typeof(UITweener), Member = "Update")]
	[CalledBy(Type = typeof(UITweener), Member = "AddOnFinished")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	public static void Add(List<EventDelegate> list, EventDelegate ev, bool oneShot)
	{
	}

	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnDisable")]
	[CalledBy(Type = typeof(UISavedOption), Member = "OnDisable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool Remove(List<EventDelegate> list, Callback callback)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool Remove(List<EventDelegate> list, EventDelegate ev)
	{
		return false;
	}
}
