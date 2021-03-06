﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BitFlyer.Apis
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CurrencyCode
    {
        [EnumMember(Value = "JPY")]
        Jpy,

        [EnumMember(Value = "BTC")]
        Btc,

        [EnumMember(Value = "ETH")]
        Eth
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Side
    {
        [EnumMember(Value = "BUY")]
        Buy,

        [EnumMember(Value = "SELL")]
        Sell,

        [EnumMember(Value = "BUYSELL")]
        BuySell
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductCode
    {
        [EnumMember(Value = "BTC_JPY")]
        BtcJpy,

        [EnumMember(Value = "FX_BTC_JPY")]
        FxBtcJpy,

        [EnumMember(Value = "ETH_BTC")]
        EthBtc
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BitflyerSystemHealth
    {
        [EnumMember(Value = "NORMAL")]
        Normal,

        [EnumMember(Value = "BUSY")]
        Busy,

        [EnumMember(Value = "VERY BUSY")]
        VeryBusy,

        [EnumMember(Value = "STOP")]
        Stop
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DepositStatus
    {
        [EnumMember(Value = "PENDING")]
        Pending,

        [EnumMember(Value = "COMPLETED")]
        Completed
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChildOrderType
    {
        [EnumMember(Value = "LIMIT")]
        Limit,

        [EnumMember(Value = "MARKET")]
        Market
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TimeInForce
    {
        [EnumMember(Value = "GTC")]
        GoodTilCanceled,

        [EnumMember(Value = "IOC")]
        ImmediateOrCancel,

        [EnumMember(Value = "FOK")]
        FillOrKill
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderMethod
    {
        [EnumMember(Value = "SIMPLE")]
        Simple,

        [EnumMember(Value = "IFD")]
        IfDone,

        [EnumMember(Value = "OCO")]
        OneCancelsTheOther,

        [EnumMember(Value = "IFDOCO")]
        IfDoneOneCancelsTheOther
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConditionType
    {
        [EnumMember(Value = "LIMIT")]
        Limit,

        [EnumMember(Value = "MARKET")]
        Market,

        [EnumMember(Value = "STOP")]
        Stop,

        [EnumMember(Value = "STOP_LIMIT")]
        StopLimit,

        [EnumMember(Value = "TRAIL")]
        Trail
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AddresseType
    {
        [EnumMember(Value = "NORMAL")]
        Normal
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChildOrderState
    {
        [EnumMember(Value = "ACTIVE")]
        Active,

        [EnumMember(Value = "COMPLETED")]
        Completed,

        [EnumMember(Value = "CANCELED")]
        Canceled,

        [EnumMember(Value = "EXPIRED")]
        Expired,

        [EnumMember(Value = "REJECTED")]
        Rejected
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ParentOrderState
    {
        [EnumMember(Value = "ACTIVE")]
        Active,

        [EnumMember(Value = "COMPLETED")]
        Completed,

        [EnumMember(Value = "CANCELED")]
        Canceled,

        [EnumMember(Value = "EXPIRED")]
        Expired,

        [EnumMember(Value = "REJECTED")]
        Rejected
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PubnubChannel
    {
        [EnumMember(Value = "lightning_board_snapshot_BTC_JPY")]
        BoardSnapshotBtcJpy,

        [EnumMember(Value = "lightning_board_snapshot_FX_BTC_JPY")]
        BoardSnapshotFxBtcJpy,

        [EnumMember(Value = "lightning_board_snapshot_ETH_BTC")]
        BoardSnapshotEthBtc,

        [EnumMember(Value = "lightning_board_BTC_JPY")]
        BoardBtcJpy,

        [EnumMember(Value = "lightning_board_FX_BTC_JPY")]
        BoardFxBtcJpy,

        [EnumMember(Value = "lightning_board_ETH_BTC")]
        BoardEthBtc,

        [EnumMember(Value = "lightning_ticker_BTC_JPY")]
        TickerBtcJpy,

        [EnumMember(Value = "lightning_ticker_FX_BTC_JPY")]
        TickerFxBtcJpy,

        [EnumMember(Value = "lightning_ticker_ETH_BTC")]
        TickerEthBtc,

        [EnumMember(Value = "lightning_executions_BTC_JPY")]
        ExecutionsBtcJpy,

        [EnumMember(Value = "lightning_executions_FX_BTC_JPY")]
        ExecutionsFxBtcJpy,

        [EnumMember(Value = "lightning_executions_ETH_BTC")]
        ExecutionsEthBtc
    }
}
