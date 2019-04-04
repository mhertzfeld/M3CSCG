using Lawson.M3.MvxSock;
using M3ApiClientInterface;
using System;


namespace M3CSCG.M3.MRS001MI
{
    internal class LstFieldsData
        : M3ApiClientInterface.DataObjectInterface
    {
        //PROPERTIES
        public String FieldDescription { get; set; }

        public String FieldName { get; set; }

        public String FieldType { get; set; }

        public String InputOutput { get; set; }

        public String Length { get; set; }

        public String ProgramName { get; set; }

        public String TransactionName { get; set; }


        //INITIALIZE
        public LstFieldsData()
        {
            FieldDescription = null;

            FieldName = null;

            FieldType = null;

            InputOutput = null;

            Length = null;

            ProgramName = null;

            TransactionName = null;
        }


        //METHODS
        public void SetFields(ref SERVER_ID _ServerId)
        {
            FieldDescription = DataConverter.ToString(MvxSock.GetField(ref _ServerId, "FLDS"));

            FieldName = DataConverter.ToString(MvxSock.GetField(ref _ServerId, "FLNM"));

            FieldType = DataConverter.ToString(MvxSock.GetField(ref _ServerId, "TYPE"));

            InputOutput = DataConverter.ToString(MvxSock.GetField(ref _ServerId, "TRTP"));

            Length = DataConverter.ToString(MvxSock.GetField(ref _ServerId, "LENG"));

            ProgramName = DataConverter.ToString(MvxSock.GetField(ref _ServerId, "MINM"));

            TransactionName = DataConverter.ToString(MvxSock.GetField(ref _ServerId, "TRNM"));
        }
    }
}