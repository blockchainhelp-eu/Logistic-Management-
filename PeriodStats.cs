/**
 * Autogenerated by Thrift Compiler (0.11.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace NodeApi
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class PeriodStats : TBase
  {
    private long _periodDuration;
    private int _poolsCount;
    private int _transactionsCount;
    private Dictionary<string, CumulativeAmount> _balancePerCurrency;
    private int _smartContractsCount;

    public long PeriodDuration
    {
      get
      {
        return _periodDuration;
      }
      set
      {
        __isset.periodDuration = true;
        this._periodDuration = value;
      }
    }

    public int PoolsCount
    {
      get
      {
        return _poolsCount;
      }
      set
      {
        __isset.poolsCount = true;
        this._poolsCount = value;
      }
    }

    public int TransactionsCount
    {
      get
      {
        return _transactionsCount;
      }
      set
      {
        __isset.transactionsCount = true;
        this._transactionsCount = value;
      }
    }

    public Dictionary<string, CumulativeAmount> BalancePerCurrency
    {
      get
      {
        return _balancePerCurrency;
      }
      set
      {
        __isset.balancePerCurrency = true;
        this._balancePerCurrency = value;
      }
    }

    public int SmartContractsCount
    {
      get
      {
        return _smartContractsCount;
      }
      set
      {
        __isset.smartContractsCount = true;
        this._smartContractsCount = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool periodDuration;
      public bool poolsCount;
      public bool transactionsCount;
      public bool balancePerCurrency;
      public bool smartContractsCount;
    }

    public PeriodStats() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I64) {
                PeriodDuration = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I32) {
                PoolsCount = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I32) {
                TransactionsCount = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Map) {
                {
                  BalancePerCurrency = new Dictionary<string, CumulativeAmount>();
                  TMap _map4 = iprot.ReadMapBegin();
                  for( int _i5 = 0; _i5 < _map4.Count; ++_i5)
                  {
                    string _key6;
                    CumulativeAmount _val7;
                    _key6 = iprot.ReadString();
                    _val7 = new CumulativeAmount();
                    _val7.Read(iprot);
                    BalancePerCurrency[_key6] = _val7;
                  }
                  iprot.ReadMapEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.I32) {
                SmartContractsCount = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("PeriodStats");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.periodDuration) {
          field.Name = "periodDuration";
          field.Type = TType.I64;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(PeriodDuration);
          oprot.WriteFieldEnd();
        }
        if (__isset.poolsCount) {
          field.Name = "poolsCount";
          field.Type = TType.I32;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(PoolsCount);
          oprot.WriteFieldEnd();
        }
        if (__isset.transactionsCount) {
          field.Name = "transactionsCount";
          field.Type = TType.I32;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(TransactionsCount);
          oprot.WriteFieldEnd();
        }
        if (BalancePerCurrency != null && __isset.balancePerCurrency) {
          field.Name = "balancePerCurrency";
          field.Type = TType.Map;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteMapBegin(new TMap(TType.String, TType.Struct, BalancePerCurrency.Count));
            foreach (string _iter8 in BalancePerCurrency.Keys)
            {
              oprot.WriteString(_iter8);
              BalancePerCurrency[_iter8].Write(oprot);
            }
            oprot.WriteMapEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (__isset.smartContractsCount) {
          field.Name = "smartContractsCount";
          field.Type = TType.I32;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(SmartContractsCount);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("PeriodStats(");
      bool __first = true;
      if (__isset.periodDuration) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("PeriodDuration: ");
        __sb.Append(PeriodDuration);
      }
      if (__isset.poolsCount) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("PoolsCount: ");
        __sb.Append(PoolsCount);
      }
      if (__isset.transactionsCount) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TransactionsCount: ");
        __sb.Append(TransactionsCount);
      }
      if (BalancePerCurrency != null && __isset.balancePerCurrency) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("BalancePerCurrency: ");
        __sb.Append(BalancePerCurrency);
      }
      if (__isset.smartContractsCount) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SmartContractsCount: ");
        __sb.Append(SmartContractsCount);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
