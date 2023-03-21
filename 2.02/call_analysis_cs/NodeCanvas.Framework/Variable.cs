using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework.Internal;
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
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass37_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 2)]
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

		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		set
		{
		}
	}

	public string ID
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Guid), Member = "NewGuid")]
		[Calls(Type = typeof(Guid), Member = "ToString")]
		get
		{
			return null;
		}
	}

	public object value
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 26)]
		get
		{
			return null;
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
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
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	protected abstract object objectValue
	{
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		get;
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		set;
	}

	public abstract Type varType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	public abstract bool hasBinding
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	public abstract string propertyPath
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		set;
	}

	public event Action<string> onNameChanged
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
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

	public event Action<string, object> onValueChanged
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected bool HasValueChangeEvent()
	{
		return default(bool);
	}

	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected void OnValueChanged(string name, object value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Variable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract void BindProperty(MemberInfo prop, GameObject target = null);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract void UnBindProperty();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract void InitializePropertyBinding(GameObject go, bool callSetter = false);

	[Calls(Type = typeof(Variable), Member = "GetGetConverter")]
	[CallerCount(Count = 0)]
	public bool CanConvertTo(Type toType)
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TypeConverter), Member = "Get")]
	[CalledBy(Type = typeof(BBParameter<>), Member = "BindGetter")]
	[CalledBy(Type = typeof(Variable), Member = "CanConvertTo")]
	[CalledBy(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[CalledBy(Type = typeof(BlackboardSource._003C_003Ec__DisplayClass30_0), Member = "<GetVariableNames>b__0")]
	[CallsUnknownMethods(Count = 24)]
	public Func<object> GetGetConverter(Type toType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Variable), Member = "GetSetConverter")]
	public bool CanConvertFrom(Type fromType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Variable), Member = "CanConvertFrom")]
	[CalledBy(Type = typeof(BBParameter<>), Member = "BindSetter")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeConverter), Member = "Get")]
	public Action<object> GetSetConverter(Type fromType)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 52)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsUnknownMethods(Count = 1)]
		internal T _003CInitializePropertyBinding_003Eb__1()
		{
			return (T)null;
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
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
			return (T)null;
		}

		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 2)]
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
			return (T)null;
		}

		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 2)]
		internal T _003CInitializePropertyBinding_003Eb__6()
		{
			return (T)null;
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
		[CallerCount(Count = 41)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public override bool hasBinding
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
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
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public override Type varType
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public new T value
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		get
		{
			return (T)null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Variable), Member = "OnValueChanged")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public T GetValue()
	{
		return (T)null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetValue(T newValue)
	{
	}

	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override void BindProperty(MemberInfo prop, GameObject target = null)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void UnBindProperty()
	{
	}

	[CallsUnknownMethods(Count = 124)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ReflectionTools), Member = "IsConstant")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetField")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 27)]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetProperty")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Substring")]
	public override void InitializePropertyBinding(GameObject go, bool callSetter = false)
	{
	}
}
