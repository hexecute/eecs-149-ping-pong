﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace SDKTemplate
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[17];
            _typeNameTable[0] = "SDKTemplate.MainPage";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "System.Collections.Generic.List`1<SDKTemplate.Scenario>";
            _typeNameTable[4] = "Object";
            _typeNameTable[5] = "SDKTemplate.Scenario";
            _typeNameTable[6] = "String";
            _typeNameTable[7] = "System.Type";
            _typeNameTable[8] = "SDKTemplate.ScenarioBindingConverter";
            _typeNameTable[9] = "SDKTemplate.ScenarioList";
            _typeNameTable[10] = "BluetoothGattHeartRate.ChartControl";
            _typeNameTable[11] = "Windows.UI.Xaml.Controls.Canvas";
            _typeNameTable[12] = "Windows.UI.Xaml.Controls.Panel";
            _typeNameTable[13] = "Int32";
            _typeNameTable[14] = "BluetoothGattHeartRate.Scenario1_DeviceEvents";
            _typeNameTable[15] = "BluetoothGattHeartRate.Scenario2_ReadCharacteristicValue";
            _typeNameTable[16] = "BluetoothGattHeartRate.Scenario3_WriteCharacteristicValue";

            _typeTable = new global::System.Type[17];
            _typeTable[0] = typeof(global::SDKTemplate.MainPage);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::System.Collections.Generic.List<global::SDKTemplate.Scenario>);
            _typeTable[4] = typeof(global::System.Object);
            _typeTable[5] = typeof(global::SDKTemplate.Scenario);
            _typeTable[6] = typeof(global::System.String);
            _typeTable[7] = typeof(global::System.Type);
            _typeTable[8] = typeof(global::SDKTemplate.ScenarioBindingConverter);
            _typeTable[9] = typeof(global::SDKTemplate.ScenarioList);
            _typeTable[10] = typeof(global::BluetoothGattHeartRate.ChartControl);
            _typeTable[11] = typeof(global::Windows.UI.Xaml.Controls.Canvas);
            _typeTable[12] = typeof(global::Windows.UI.Xaml.Controls.Panel);
            _typeTable[13] = typeof(global::System.Int32);
            _typeTable[14] = typeof(global::BluetoothGattHeartRate.Scenario1_DeviceEvents);
            _typeTable[15] = typeof(global::BluetoothGattHeartRate.Scenario2_ReadCharacteristicValue);
            _typeTable[16] = typeof(global::BluetoothGattHeartRate.Scenario3_WriteCharacteristicValue);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_MainPage() { return new global::SDKTemplate.MainPage(); }
        private object Activate_3_List() { return new global::System.Collections.Generic.List<global::SDKTemplate.Scenario>(); }
        private object Activate_5_Scenario() { return new global::SDKTemplate.Scenario(); }
        private object Activate_8_ScenarioBindingConverter() { return new global::SDKTemplate.ScenarioBindingConverter(); }
        private object Activate_9_ScenarioList() { return new global::SDKTemplate.ScenarioList(); }
        private object Activate_10_ChartControl() { return new global::BluetoothGattHeartRate.ChartControl(); }
        private object Activate_14_Scenario1_DeviceEvents() { return new global::BluetoothGattHeartRate.Scenario1_DeviceEvents(); }
        private object Activate_15_Scenario2_ReadCharacteristicValue() { return new global::BluetoothGattHeartRate.Scenario2_ReadCharacteristicValue(); }
        private object Activate_16_Scenario3_WriteCharacteristicValue() { return new global::BluetoothGattHeartRate.Scenario3_WriteCharacteristicValue(); }
        private void VectorAdd_3_List(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::SDKTemplate.Scenario>)instance;
            var newItem = (global::SDKTemplate.Scenario)item;
            collection.Add(newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  SDKTemplate.MainPage
                userType = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_MainPage;
                userType.AddMemberName("Scenarios");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  System.Collections.Generic.List`1<SDKTemplate.Scenario>
                userType = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.CollectionAdd = VectorAdd_3_List;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 4:   //  Object
                xamlType = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 5:   //  SDKTemplate.Scenario
                userType = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_5_Scenario;
                userType.AddMemberName("Title");
                userType.AddMemberName("ClassType");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 6:   //  String
                xamlType = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  System.Type
                userType = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 8:   //  SDKTemplate.ScenarioBindingConverter
                userType = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_8_ScenarioBindingConverter;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  SDKTemplate.ScenarioList
                userType = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_9_ScenarioList;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 10:   //  BluetoothGattHeartRate.ChartControl
                userType = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Canvas"));
                userType.Activator = Activate_10_ChartControl;
                userType.AddMemberName("DataPointCount");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 11:   //  Windows.UI.Xaml.Controls.Canvas
                xamlType = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 12:   //  Windows.UI.Xaml.Controls.Panel
                xamlType = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 13:   //  Int32
                xamlType = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 14:   //  BluetoothGattHeartRate.Scenario1_DeviceEvents
                userType = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_14_Scenario1_DeviceEvents;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 15:   //  BluetoothGattHeartRate.Scenario2_ReadCharacteristicValue
                userType = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_15_Scenario2_ReadCharacteristicValue;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 16:   //  BluetoothGattHeartRate.Scenario3_WriteCharacteristicValue
                userType = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_16_Scenario3_WriteCharacteristicValue;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_MainPage_Scenarios(object instance)
        {
            var that = (global::SDKTemplate.MainPage)instance;
            return that.Scenarios;
        }
        private object get_1_Scenario_Title(object instance)
        {
            var that = (global::SDKTemplate.Scenario)instance;
            return that.Title;
        }
        private void set_1_Scenario_Title(object instance, object Value)
        {
            var that = (global::SDKTemplate.Scenario)instance;
            that.Title = (global::System.String)Value;
        }
        private object get_2_Scenario_ClassType(object instance)
        {
            var that = (global::SDKTemplate.Scenario)instance;
            return that.ClassType;
        }
        private void set_2_Scenario_ClassType(object instance, object Value)
        {
            var that = (global::SDKTemplate.Scenario)instance;
            that.ClassType = (global::System.Type)Value;
        }
        private object get_3_ChartControl_DataPointCount(object instance)
        {
            var that = (global::BluetoothGattHeartRate.ChartControl)instance;
            return that.DataPointCount;
        }
        private void set_3_ChartControl_DataPointCount(object instance, object Value)
        {
            var that = (global::BluetoothGattHeartRate.ChartControl)instance;
            that.DataPointCount = (global::System.Int32)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlMember xamlMember = null;
            global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "SDKTemplate.MainPage.Scenarios":
                userType = (global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SDKTemplate.MainPage");
                xamlMember = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlMember(this, "Scenarios", "System.Collections.Generic.List`1<SDKTemplate.Scenario>");
                xamlMember.Getter = get_0_MainPage_Scenarios;
                xamlMember.SetIsReadOnly();
                break;
            case "SDKTemplate.Scenario.Title":
                userType = (global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SDKTemplate.Scenario");
                xamlMember = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlMember(this, "Title", "String");
                xamlMember.Getter = get_1_Scenario_Title;
                xamlMember.Setter = set_1_Scenario_Title;
                break;
            case "SDKTemplate.Scenario.ClassType":
                userType = (global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SDKTemplate.Scenario");
                xamlMember = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlMember(this, "ClassType", "System.Type");
                xamlMember.Getter = get_2_Scenario_ClassType;
                xamlMember.Setter = set_2_Scenario_ClassType;
                break;
            case "BluetoothGattHeartRate.ChartControl.DataPointCount":
                userType = (global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BluetoothGattHeartRate.ChartControl");
                xamlMember = new global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlMember(this, "DataPointCount", "Int32");
                xamlMember.Getter = get_3_ChartControl_DataPointCount;
                xamlMember.Setter = set_3_ChartControl_DataPointCount;
                break;
            }
            return xamlMember;
        }
    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlSystemBaseType
    {
        global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::SDKTemplate.BluetoothGattHeartRate_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


