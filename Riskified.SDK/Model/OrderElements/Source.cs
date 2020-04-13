﻿using System.Runtime.Serialization;
namespace Riskified.SDK.Model.OrderElements
{
    public enum Source
    {
        [EnumMember(Value = "desktop_web")]
        DesktopWeb,
        [EnumMember(Value = "mobile_web")]
        MobileWeb,
        [EnumMember(Value = "mobile_app")]
        MobileApp,
        [EnumMember(Value = "web")]
        Web,
        [EnumMember(Value = "chat")]
        Chat,
        [EnumMember(Value = "third_party")]
        ThirdParty,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "in_store")]
        InStore,
        [EnumMember(Value = "shopify_draft_order")]
        ShopifyDraftOrder,
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "mobile_app_android")]
        MobileAppAndroid,
        [EnumMember(Value = "mobile_app_ios")]
        MobileAppIos,
    }
}

