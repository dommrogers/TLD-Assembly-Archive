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
			[CallsUnknownMethods(Count = 1)]
			[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
			[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
			[Calls(Type = typeof(Convert), Member = "ChangeType")]
			[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
			[CallsDeduplicatedMethods(Count = 4)]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(Type), Member = "GetProperty")]
			get
			{
				return null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 51)]
			set
			{
			}
		}

		public Type type
		{
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
			[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
			[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
			[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return null;
			}
		}

		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallerCount(Count = 0)]
		public Parameter()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		public Parameter(UnityEngine.Object obj, string field)
		{
		}

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CalledBy(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
		[CalledBy(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
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
		[CallerCount(Count = 98)]
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
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
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
		[Calls(Type = typeof(EventDelegate), Member = "Cache")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public bool isValid
	{
		[CalledBy(Type = typeof(EventDelegate), Member = "IsValid")]
		[Calls(Type = typeof(EventDelegate), Member = "Cache")]
		[CalledBy(Type = typeof(EventDelegate), Member = "Equals")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return default(bool);
		}
	}

	public bool isEnabled
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventDelegate), Member = "Cache")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public EventDelegate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	public EventDelegate(Callback call)
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Clear")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public EventDelegate(MonoBehaviour target, string methodName)
	{
	}

	[CalledBy(Type = typeof(EventDelegate), Member = "Equals")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static string GetMethodName(Callback callback)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static bool IsValid(Callback callback)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(EventDelegate), Member = "GetMethodName")]
	[Calls(Type = typeof(EventDelegate), Member = "get_isValid")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Set")]
	[CalledBy(Type = typeof(EventDelegate), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventDelegate), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Set(Callback call)
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(EventDelegate), Member = "Clear")]
	[CallerCount(Count = 3)]
	public void Set(MonoBehaviour target, string methodName)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(EventDelegate), Member = "get_parameters")]
	[CalledBy(Type = typeof(EventDelegate), Member = "get_isValid")]
	[CalledBy(Type = typeof(EventDelegate), Member = "get_isEnabled")]
	[CalledBy(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
	[CalledBy(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
	private void Cache()
	{
	}

	[Calls(Type = typeof(Parameter), Member = "get_type")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
	[CalledBy(Type = typeof(DoubleClickButton), Member = "OnClick")]
	[Calls(Type = typeof(Parameter), Member = "get_type")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Parameter), Member = "get_value")]
	[Calls(Type = typeof(EventDelegate), Member = "Cache")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(DoubleClickButton), Member = "OnClick")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public bool Execute()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(EventDelegate), Member = "Set")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Set")]
	[CalledBy(Type = typeof(EventDelegate), Member = ".ctor")]
	[CallerCount(Count = 3)]
	public void Clear()
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "LastIndexOf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	public override string ToString()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 32)]
	public static void Execute(List<EventDelegate> list)
	{
	}

	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnDecrease")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnIncrease")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnDragFinished")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	[CalledBy(Type = typeof(UIInput), Member = "ExecuteOnChange")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Start")]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CalledBy(Type = typeof(UIToggle), Member = "Start")]
	[CalledBy(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIPopupList), Member = "TriggerCallbacks")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "Awake")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "Awake")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(EventDelegate), Member = "get_isValid")]
	[CallerCount(Count = 16)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	public static bool IsValid(List<EventDelegate> list)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(UITweener), Member = "SetOnFinished")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowNewLocationDiscovered")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static EventDelegate Set(List<EventDelegate> list, Callback callback)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Set(List<EventDelegate> list, EventDelegate del)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeQualityMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeQualityMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeQualityMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeQualityMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeQualityMenuItems")]
	[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
	[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "AttachEventHandler")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeQualityMenuItems")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSelectRegionItemInstantiated")]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeQualityMenuItems")]
	public static EventDelegate Add(List<EventDelegate> list, Callback callback)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 68)]
	public static EventDelegate Add(List<EventDelegate> list, Callback callback, bool oneShot)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Add(List<EventDelegate> list, EventDelegate ev)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UITweener), Member = "Update")]
	[CalledBy(Type = typeof(UITweener), Member = "AddOnFinished")]
	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public static void Add(List<EventDelegate> list, EventDelegate ev, bool oneShot)
	{
	}

	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UISavedOption), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnDisable")]
	public static bool Remove(List<EventDelegate> list, Callback callback)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool Remove(List<EventDelegate> list, EventDelegate ev)
	{
		return default(bool);
	}
}
