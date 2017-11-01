using M3ApiClientInterface;
using M3CSCG.M3.MRS001MI;
using M3CSCG.Properties;
using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;


namespace M3CSCG
{
    class Program
    {
        /// <summary>
        /// Inputs:
        ///     0 M3 Server
        ///     1 M3 Port
        ///     2 M3 User
        ///     3 M3 Password
        ///     4 M3 Program
        ///     5 M3 Transaction
        ///     6 Class\Interface
        ///     7 Namespace
        ///     8 Class\Interface Name
        ///     9 Output Directory
        /// </summary>
        /// <param name="_Args"></param>
        static void Main(string[] _Args)
        {
            try
            {
                DataObjectCollectionReaderProcess<LstFieldsData, List<LstFieldsData>> _DataObjectCollectionReaderProcess = new DataObjectCollectionReaderProcess<LstFieldsData, List<LstFieldsData>>();
                _DataObjectCollectionReaderProcess.ApiData.Api = "MRS001MI";
                _DataObjectCollectionReaderProcess.ApiData.Method = "LstFields";
                _DataObjectCollectionReaderProcess.ConnectionData.Password = _Args[3];
                _DataObjectCollectionReaderProcess.ConnectionData.Port = MyDataConverter.ToUInt16(_Args[1]);
                _DataObjectCollectionReaderProcess.ConnectionData.Server = _Args[0];
                _DataObjectCollectionReaderProcess.ConnectionData.UserName = _Args[2];
                _DataObjectCollectionReaderProcess.RequestFieldDataList.Add(new RequestFieldData("MINM", _Args[4]));
                _DataObjectCollectionReaderProcess.RequestFieldDataList.Add(new RequestFieldData("TRNM", _Args[5]));
                _DataObjectCollectionReaderProcess.RequestFieldDataList.Add(new RequestFieldData("TRTP", "O"));
                if (_DataObjectCollectionReaderProcess.ExecuteProcess())
                {
                    String _Output = null;

                    switch (_Args[6])
                    {
                        case "C":

                            StringBuilder _InitializeStringBuilder = new StringBuilder();

                            StringBuilder _PropertiesStringBuilder = new StringBuilder();

                            StringBuilder _SetFieldsStringBuilder = new StringBuilder();

                            foreach (LstFieldsData _LstFieldsData in _DataObjectCollectionReaderProcess.DataObjectCollection.OrderBy(element => element.FieldDescription))
                            {
                                String _PropertyName = GeneratePropertyName(_LstFieldsData.FieldDescription);

                                //INITIALIZE
                                String _Initialize = Resources.Template_Initialize;
                                _Initialize = _Initialize.Replace(Resources.Parameter_Property, _PropertyName);

                                _InitializeStringBuilder.AppendLine(_Initialize);
                                _InitializeStringBuilder.AppendLine();

                                //PROPERTY
                                String _Property = null;

                                String _SetField = null;

                                switch (_LstFieldsData.FieldType)
                                {
                                    case "A":

                                        _Property = Resources.Template_ClassProperty.Replace(Resources.Parameter_Type, @"String");

                                        _SetField = Resources.Template_SetField_String.Replace(Resources.Parameter_FieldName, _LstFieldsData.FieldName);

                                        break;

                                    case "D":

                                        _Property = Resources.Template_ClassProperty.Replace(Resources.Parameter_Type, @"DateTime?");

                                        _SetField = Resources.Template_SetField_Date.Replace(Resources.Parameter_FieldName, _LstFieldsData.FieldName);
                                        
                                        break;

                                    case "N":

                                        _Property = Resources.Template_ClassProperty.Replace(Resources.Parameter_Type, @"Decimal?");

                                        _SetField = Resources.Template_SetField_Decimal.Replace(Resources.Parameter_FieldName, _LstFieldsData.FieldName);

                                        break;

                                    default:

                                        throw new ValueOutOfRangeException("_LstFieldsData.FieldType");
                                }

                                _Property = _Property.Replace(Resources.Parameter_Name, _PropertyName);

                                _SetField = _SetField.Replace(Resources.Parameter_Property, _PropertyName);

                                _PropertiesStringBuilder.AppendLine(_Property);
                                _PropertiesStringBuilder.AppendLine();

                                _SetFieldsStringBuilder.AppendLine(_SetField);
                                _SetFieldsStringBuilder.AppendLine();
                            }

                            _Output = Resources.Template_Class;
                            _Output = _Output.Replace(Resources.Parameter_NameSpace, _Args[7]);
                            _Output = _Output.Replace(Resources.Parameter_Class, _Args[8]);
                            _Output = _Output.Replace(Resources.Parameter_Properties, _PropertiesStringBuilder.ToString());
                            _Output = _Output.Replace(Resources.Parameter_Initialize, _InitializeStringBuilder.ToString());
                            _Output = _Output.Replace(Resources.Parameter_SetFields, _SetFieldsStringBuilder.ToString());

                            break;

                        case "I":

                            StringBuilder _ContentsStringBuilder = new StringBuilder();
                            foreach (LstFieldsData _LstFieldsData in _DataObjectCollectionReaderProcess.DataObjectCollection.OrderBy(element => element.FieldDescription))
                            {
                                String _ContentLine = Resources.Template_InterfaceProperty;

                                switch (_LstFieldsData.FieldType)
                                {
                                    case "A":

                                        _ContentLine = _ContentLine.Replace(Resources.Parameter_Type, @"String");

                                        break;

                                    case "D":

                                        _ContentLine = _ContentLine.Replace(Resources.Parameter_Type, @"DateTime?");

                                        break;

                                    case "N":

                                        _ContentLine = _ContentLine.Replace(Resources.Parameter_Type, @"Decimal?");

                                        break;

                                    default:

                                        throw new ValueOutOfRangeException("_LstFieldsData.FieldType");
                                }

                                String _PropertyName = GeneratePropertyName(_LstFieldsData.FieldDescription);

                                _ContentLine = _ContentLine.Replace(Resources.Parameter_Name, _PropertyName);

                                _ContentsStringBuilder.AppendLine(_ContentLine);
                                _ContentsStringBuilder.AppendLine();
                            }

                            _Output = Resources.Template_Interface;
                            _Output = _Output.Replace(Resources.Parameter_NameSpace, _Args[7]);
                            _Output = _Output.Replace(Resources.Parameter_InterfaceName, _Args[8]);
                            _Output = _Output.Replace(Resources.Parameter_Contents, _ContentsStringBuilder.ToString());

                            break;

                        default:

                            throw new ValueOutOfRangeException("_Args[6]");
                    }

                    File.WriteAllText(String.Format(@"{0}\{1}.cs", _Args[9], _Args[8]), _Output);
                }
            }
            catch (Exception _Exception)
            {
                Debug.WriteLine(_Exception);

                Console.WriteLine(_Exception);
            }
        }


        private static String GeneratePropertyName(String _Input)
        {
            _Input = RemoveAndReplaceWithUpper(_Input, @" ");
            _Input = RemoveAndReplaceWithUpper(_Input, @"-");
            _Input = RemoveAndReplaceWithUpper(_Input, @"/");
            _Input = RemoveAndReplaceWithUpper(_Input, @"\");
            _Input = RemoveAndReplaceWithUpper(_Input, @"(");
            _Input = RemoveAndReplaceWithUpper(_Input, @")");

            return _Input;
        }

        private static String RemoveAndReplaceWithUpper(String _Text, String _ToRemove)
        {
            Boolean _Loop = true;
            while (_Loop)
            {
                if (_Text.Contains(_ToRemove))
                {
                    Int32 _Index = _Text.IndexOf(_ToRemove);

                    _Text = _Text.Remove(_Index, 1);

                    if ((_Index + 1) <= _Text.Length - 1)
                    {
                        String _CharacterToUpper = _Text[_Index].ToString();

                        _Text = _Text.Remove(_Index, 1);

                        _Text = _Text.Insert(_Index, _CharacterToUpper.ToUpper());
                    }
                }
                else
                {
                    _Loop = false;
                }
            }

            return _Text;
        }
    }
}